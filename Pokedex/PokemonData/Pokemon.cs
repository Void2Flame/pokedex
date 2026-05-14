using System.Text.Json.Serialization;

namespace Pokedex.PokemonData;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Height { get; set; }
    public int Weight { get; set; }
    public PokemonSprites Sprites { get; set; } = new();

    public PokemonCries Cries { get; set; } = new();

    public List <PokemonTypeSlot> Types { get; set; } = new();

    public List<PokemonAbilitySlot> Abilities { get; set; } = new();

}

public class PokemonSprites
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}

public class PokemonCries
{
    public string? Latest { get; set; }
    public string? Legacy { get; set; }
}


public class PokemonTypeSlot
{
    public int Slot { get; set; }

    public PokemonTypeInfo Type { get; set; } = new();
}

public class PokemonTypeInfo
{
    public string Name { get; set; } = "";
    public string Url { get; set; } = "";
}

public class PokemonAbilitySlot
{
    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; set; }

    public int Slot { get; set; }

    public PokemonAbilityInfo Ability { get; set; } = new();
}

public class PokemonAbilityInfo
{
    public string Name { get; set; } = "";
    public string Url { get; set; } = "";
}