using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    public class Movimento
    {
        public required DateTimeOffset CreatedAt { get; set; }

        public required string Descricao { get; set; }

        public required decimal Valor { get; set; }

    }
}
