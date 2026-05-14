using System.Text.Json.Serialization;

namespace Pokedex.PokemonData;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Height { get; set; }
    public int Weight { get; set; }
    public PokemonSprites Sprites { get; set; } = new();
}

public class PokemonSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}