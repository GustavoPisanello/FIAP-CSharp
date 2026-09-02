using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    public record PokemonDetalhado
    {
        public int ID { get; set; }

        public required string Name { get; set; }

        public decimal HeightInMeters { get; set; }

        public decimal WeightInKg { get; set; }

        public required List<string> TypeList { get; set; }

        public required string ImageUrl { get; set; }
    }
}
