using Pokemon;
using System.Net.Http.Json;
using System.Text.Json;

var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);

string json = await File.ReadAllTextAsync("kanto.json");

PokemonInput entrada = JsonSerializer.Deserialize<PokemonInput>(json, options) ?? throw new JsonException("Arquivo não encontrado");

using var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://pokeapi.co/api/v2/")
};

List<PokemonResponse> pokemonList = new List<PokemonResponse>();

foreach (string name in entrada.names)
{
    PokemonResponse? response = await httpClient.GetFromJsonAsync<PokemonResponse>($"pokemon/{name}");

    pokemonList.Add(response);
}

