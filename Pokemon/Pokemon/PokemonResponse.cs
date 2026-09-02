using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Pokemon
{
    public sealed class PokemonSprites
    {
        [JsonPropertyName("front_default")]
        public string? FrontDefault { get; init; }
    }

    public sealed class PokemonTypeSlot
    {
        public PokemonType Type { get; init; } = new();
    }

    public sealed class PokemonType
    {
        public string Name { get; init; } = "";
    }
    public class PokemonResponse
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public decimal Height { get; init; }
        public decimal HeightInMeters { get => Height / 10; }
        public decimal Weight { get; init; }
        public decimal WeightInKg { get =>  Weight * 10; }
        public PokemonSprites Sprites { get; init; } = new();
        public List<PokemonTypeSlot> Types { get; init; } = [];
    }
}
