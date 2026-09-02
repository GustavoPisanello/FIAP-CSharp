using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Pokemon
{
    internal class PokemonInput
    {
        [JsonPropertyName("nomes")]
        public required List<string> names { get; set; }
    }
}
