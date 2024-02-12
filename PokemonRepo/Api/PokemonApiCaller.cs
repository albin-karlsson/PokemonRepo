using Newtonsoft.Json;
using PokemonRepo.Managers;
using PokemonRepo.Models;
using PokemonRepo.Models.ViewModels;

namespace PokemonRepo.Api
{
    public class PokemonApiCaller
    {
        // https://pokeapi.co/api/v2/pokemon/charizard
        public async Task<PokemonViewModel> GetPokemon(string pokemonName)
        {
            // 1 
            HttpClient client = new(); // TODO: Refactor the client?

            // 2 
            client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");

            // 3 
            HttpResponseMessage response = await client.GetAsync(pokemonName.ToLower());

            // 4
            if (response.IsSuccessStatusCode)
            {
                // 5
                string pokemonJson = await response.Content.ReadAsStringAsync();

                // 6
                RootModel? pokemonRoot = JsonConvert.DeserializeObject<RootModel>(pokemonJson);

                // 7
                if (pokemonRoot != null)
                {
                    PokemonViewModel pokemonViewModel = new PokemonManager().ProjectApiModelToViewModel(pokemonRoot);

                    return pokemonViewModel;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task GetAllPokemons()
        {
            throw new NotImplementedException();
        }
    }
}
