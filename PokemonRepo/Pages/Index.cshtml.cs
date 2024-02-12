using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokemonRepo.Api;
using PokemonRepo.Models.ViewModels;

namespace PokemonRepo.Pages
{
    public class IndexModel : PageModel
    {
        public PokemonViewModel? Pokemon { get; set; }
        public string? ErrorMessage { get; set; }
        [BindProperty]
        public string? PokemonName { get; set; }

        public async Task OnGet()
        {
            // Körs när Index-sidan ska visas
        }

        public async Task<IActionResult> OnPost()
        {
            if (PokemonName == null)
            {
                ErrorMessage = "Try searching for something else!";

                return Page();
            }

            try
            {
                Pokemon = await new PokemonApiCaller().GetPokemon(PokemonName);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            return Page();
        }
    }
}
