using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoLivros
{
    internal class Livro
    {
        public  required string Nome {  get; set; }
        public int NumeroDePaginas { get; set; }

        public DateTime DataDeCompra { get; set; }
    }
}
