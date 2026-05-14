using System.Text.Json.Serialization;

namespace Pokedex.PokemonData;

public class PokemonSpecies
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    [JsonPropertyName("base_happiness")]
    public int BaseHappiness { get; set; }

    [JsonPropertyName("capture_rate")]
    public int CaptureRate { get; set; }

    public PokemonSpeciesInfo Color { get; set; } = new();
    public PokemonSpeciesInfo Habitat { get; set; } = new();

    [JsonPropertyName("flavor_text_entries")]
    public List<FlavorTextEntry> FlavorTextEntries { get; set; } = new();

    [JsonPropertyName("evolution_chain")]
    public EvolutionChainInfo EvolutionChain { get; set; } = new();

    [JsonPropertyName("genera")]
    public List<PokemonGenus> Genera { get; set; } = new();
}

public class PokemonSpeciesInfo
{
    public string Name { get; set; } = "";
    public string Url { get; set; } = "";
}

public class FlavorTextEntry
{
    [JsonPropertyName("flavor_text")]
    public string FlavorText { get; set; } = "";

    public LanguageInfo Language { get; set; } = new();

    public VersionInfo Version { get; set; } = new();
}

public class LanguageInfo
{
    public string Name { get; set; } = "";
}

public class VersionInfo
{
    public string Name { get; set; } = "";
}

public class EvolutionChainInfo
{
    public string Url { get; set; } = "";
}

public class PokemonGenus
{
    public string Genus { get; set; } = "";

    public LanguageInfo Language { get; set; } = new();
}