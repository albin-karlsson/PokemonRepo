namespace PokemonRepo.Models.ViewModels
{
    public class PokemonViewModel
    {
        public string? Name { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public List<string>? Types { get; set; }
        public List<AbilityViewModel>? Abilities { get; set; }
    }
}
