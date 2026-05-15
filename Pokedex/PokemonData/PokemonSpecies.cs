using System.Text.Json.Serialization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace Pokedex.PokemonData;

public class PokemonSpecies
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    [JsonPropertyName("flavor_text_entries")]
    public List<FlavorTextEntry> FlavorTextEntries { get; set; } = new();

    [JsonPropertyName("evolution_chain")]
    public EvolutionChainInfo EvolutionChain { get; set; } = new();

    [JsonPropertyName("genera")]
    public List<PokemonGenus> Genera { get; set; } = new();
}


public class PokemonEvolutionChain
{
    public EvolutionChainLink Chain { get; set; } = new();
}

public class EvolutionChainLink
{
    public EvolutionSpecies Species { get; set;} = new ();
    [JsonPropertyName("evolves_to")]
    public List<EvolutionChainLink> EvolvesTo { get; set; } = new ();
}


public class EvolutionSpecies
{
    public string Name { get; set; } = "";
    public string Url { get; set; } = "";
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