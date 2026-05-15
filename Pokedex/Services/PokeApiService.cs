using System.Net.Http.Json;
using Pokedex.PokemonData;

namespace Pokedex.Services;

public class PokeApiService
{
    private readonly HttpClient _httpClient;

    public PokeApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Pokemon?> GetPokemonAsync(string nameOrId)
    {
        return await _httpClient.GetFromJsonAsync<Pokemon>($"pokemon/{nameOrId.ToLower()}");
    }

    public async Task<PokemonSpecies?> GetPokemonSpeciesAsync(string nameOrId)
    {
        return await _httpClient.GetFromJsonAsync<PokemonSpecies>(
        $"pokemon-species/{nameOrId.ToLower()}"
        );
    }

    public async Task<PokemonEvolutionChain?> GetEvolutionChainAsync(string evolutionChainUrl)
    {
        return await _httpClient.GetFromJsonAsync<PokemonEvolutionChain>(evolutionChainUrl);
    }

    public async Task<List<PokemonListItem>> GetAllPokemonAsync ()
    {
        var response = await _httpClient.GetFromJsonAsync<PokemonListReponse>(
            "pokemon-species?limit=1300"
        );

        return response?.Results ?? new List<PokemonListItem>();
    }

}