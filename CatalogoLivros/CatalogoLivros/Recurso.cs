using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoLivros
{
    public class Recurso
    {
        public int Id {  get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
    }
}
