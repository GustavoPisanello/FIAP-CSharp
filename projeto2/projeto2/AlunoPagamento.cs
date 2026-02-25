using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2
{
    public class AlunoPagamento : Aluno
    {
        public int idPagamento { get; set; }

        public int idAluno { get; set; }

        private bool flMensalidadeDia { get; }

        public AlunoPagamento(string nome, int idAluno, bool _flMensalidadeDia)
        {
            flMensalidadeDia = _flMensalidadeDia;
            this.nome = nome;
            this.idAluno = idAluno;
        }

}
}
