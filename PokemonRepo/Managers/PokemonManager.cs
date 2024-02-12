using PokemonRepo.Models;
using PokemonRepo.Models.ViewModels;

namespace PokemonRepo.Managers
{
    public class PokemonManager
    {
        public PokemonViewModel ProjectApiModelToViewModel(RootModel rootModel)
        {
            PokemonViewModel pokemonViewModel = new()
            {
                Name = rootModel.Name,
                Height = rootModel.Height,
                Weight = rootModel.Weight,
                Types = rootModel.Types.Select(t => t.Type.Name).ToList(),
                Abilities = rootModel.Abilities.Select(a => new AbilityViewModel()
                {
                    Name = a.Ability.Name
                }).ToList(),
            };

            return pokemonViewModel;
        }
    }
}
