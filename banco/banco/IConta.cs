using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    internal interface IConta
    {
        public int Numero { get; }
        public string Titular { get; }

        public decimal Saldo { get; }

        public TipoConta Tipo { get; set; }

        public List<Movimento> HistoricoMovimento { get; }

        public void Depositar(decimal valor);
        public void Sacar(decimal valor);
    }
}
