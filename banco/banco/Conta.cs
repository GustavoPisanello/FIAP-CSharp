using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    public abstract class Conta : IConta
    {
        public int Numero { get;}
        public string Titular { get; }
        public decimal Saldo { get; private set; }
        public abstract TipoConta Tipo { get; set; }

        public List<Movimento> HistoricoMovimento { get; }

        public Conta(int numero, string titular)
        {
            if (numero <= 0) throw new ArgumentException(nameof(numero), "Número precisa ser maior que 0");

            if (string.IsNullOrWhiteSpace(titular)) throw new ArgumentException(nameof(titular), "Titular precisa estar preenchido");

            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public abstract void Sacar(decimal valor);

        protected void Creditar(decimal valor, string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao)) throw new ArgumentException(nameof(descricao), "A descrição é obrigatória");
            if (valor <= 0) throw new ArgumentException(nameof(valor), "O crédito não pode ser menor que 0.");

            Saldo += valor;
            Movimento movimento = new Movimento
            {
                Valor = valor,
                Descricao = descricao,
                CreatedAt = DateTime.Now
            };

            HistoricoMovimento.Add(movimento);
         }

        public void Depositar(decimal valor)
        {
            Creditar(valor, "Depósito");
        }

        protected abstract decimal ObterSaldoDisponivel();
    }
}
