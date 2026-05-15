using Microsoft.AspNetCore.SignalR;

namespace Pokedex.PokemonData;

public class PokemonListReponse
{

    public int Count { get; set; }
    public string? Next { get; set; }
    public string? Previous { get; set; }

    public List<PokemonListItem> Results { get; set; } = new();
}

public class PokemonListItem
{
    public string Name { get; set; } = "";
    public string Url { get; set; } = "";
}