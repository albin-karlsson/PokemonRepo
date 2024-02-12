using Newtonsoft.Json;

namespace PokemonRepo.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AbilityRootModel
    {
        [JsonProperty("ability")]
        public AbilityModel Ability { get; set; }

        [JsonProperty("is_hidden")]
        public bool? IsHidden { get; set; }

        [JsonProperty("slot")]
        public int? Slot { get; set; }
    }

    public class AbilityModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AnimatedModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public object BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class BlackWhiteModel
    {
        [JsonProperty("animated")]
        public AnimatedModel Animated { get; set; }

        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public object BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class CriesModel
    {
        [JsonProperty("latest")]
        public string Latest { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }
    }

    public class CrystalModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_transparent")]
        public string BackShinyTransparent { get; set; }

        [JsonProperty("back_transparent")]
        public string BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_transparent")]
        public string FrontShinyTransparent { get; set; }

        [JsonProperty("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class DiamondPearlModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public object BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class DreamWorldModel
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }
    }

    public class EmeraldModel
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }
    }

    public class FireredLeafgreenModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }
    }

    public class FormModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GameIndexModel
    {
        [JsonProperty("game_index")]
        public int? GameIndex { get; set; }

        [JsonProperty("version")]
        public VersionModel Version { get; set; }
    }

    public class GenerationIModel
    {
        [JsonProperty("red-blue")]
        public RedBlueModel RedBlue { get; set; }

        [JsonProperty("yellow")]
        public YellowModel Yellow { get; set; }
    }

    public class GenerationIiModel
    {
        [JsonProperty("crystal")]
        public CrystalModel Crystal { get; set; }

        [JsonProperty("gold")]
        public GoldModel Gold { get; set; }

        [JsonProperty("silver")]
        public SilverModel Silver { get; set; }
    }

    public class GenerationIiiModel
    {
        [JsonProperty("emerald")]
        public EmeraldModel Emerald { get; set; }

        [JsonProperty("firered-leafgreen")]
        public FireredLeafgreenModel FireredLeafgreen { get; set; }

        [JsonProperty("ruby-sapphire")]
        public RubySapphireModel RubySapphire { get; set; }
    }

    public class GenerationIvModel
    {
        [JsonProperty("diamond-pearl")]
        public DiamondPearlModel DiamondPearl { get; set; }

        [JsonProperty("heartgold-soulsilver")]
        public HeartgoldSoulsilverModel HeartgoldSoulsilver { get; set; }

        [JsonProperty("platinum")]
        public PlatinumModel Platinum { get; set; }
    }

    public class GenerationVModel
    {
        [JsonProperty("black-white")]
        public BlackWhiteModel BlackWhite { get; set; }
    }

    public class GenerationViModel
    {
        [JsonProperty("omegaruby-alphasapphire")]
        public OmegarubyAlphasapphireModel OmegarubyAlphasapphire { get; set; }

        [JsonProperty("x-y")]
        public XYModel XY { get; set; }
    }

    public class GenerationViiModel
    {
        [JsonProperty("icons")]
        public IconsModel Icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon")]
        public UltraSunUltraMoonModel UltraSunUltraMoon { get; set; }
    }

    public class GenerationViiiModel
    {
        [JsonProperty("icons")]
        public IconsModel Icons { get; set; }
    }

    public class GoldModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class HeartgoldSoulsilverModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public object BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class HomeModel
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class IconsModel
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }
    }

    public class MoveRootModel
    {
        [JsonProperty("move")]
        public MoveModel Move { get; set; }

        [JsonProperty("version_group_details")]
        public List<VersionGroupDetailModel> VersionGroupDetails { get; set; }
    }

    public class MoveModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MoveLearnMethodModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class OfficialArtworkModel
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }
    }

    public class OmegarubyAlphasapphireModel
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class OtherModel
    {
        [JsonProperty("dream_world")]
        public DreamWorldModel DreamWorld { get; set; }

        [JsonProperty("home")]
        public HomeModel Home { get; set; }

        [JsonProperty("official-artwork")]
        public OfficialArtworkModel OfficialArtwork { get; set; }

        [JsonProperty("showdown")]
        public ShowdownModel Showdown { get; set; }
    }

    public class PlatinumModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public object BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class RedBlueModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_gray")]
        public string BackGray { get; set; }

        [JsonProperty("back_transparent")]
        public string BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_gray")]
        public string FrontGray { get; set; }

        [JsonProperty("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class RootModel
    {
        [JsonProperty("abilities")]
        public List<AbilityRootModel> Abilities { get; set; }

        [JsonProperty("base_experience")]
        public int? BaseExperience { get; set; }

        [JsonProperty("cries")]
        public CriesModel Cries { get; set; }

        [JsonProperty("forms")]
        public List<FormModel> Forms { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndexModel> GameIndices { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("held_items")]
        public List<object> HeldItems { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

        [JsonProperty("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }

        [JsonProperty("moves")]
        public List<MoveRootModel> Moves { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("past_abilities")]
        public List<object> PastAbilities { get; set; }

        [JsonProperty("past_types")]
        public List<object> PastTypes { get; set; }

        [JsonProperty("species")]
        public SpeciesModel Species { get; set; }

        [JsonProperty("sprites")]
        public SpritesModel Sprites { get; set; }

        [JsonProperty("stats")]
        public List<StatModel> Stats { get; set; }

        [JsonProperty("types")]
        public List<TypeRootModel> Types { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }
    }

    public class RubySapphireModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }
    }

    public class ShowdownModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public object BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class SilverModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_transparent")]
        public string FrontTransparent { get; set; }
    }

    public class SpeciesModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SpritesModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public object BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }

        [JsonProperty("other")]
        public OtherModel Other { get; set; }

        [JsonProperty("versions")]
        public VersionsModel Versions { get; set; }
    }

    public class StatRootModel
    {
        [JsonProperty("base_stat")]
        public int? BaseStat { get; set; }

        [JsonProperty("effort")]
        public int? Effort { get; set; }

        [JsonProperty("stat")]
        public StatModel Stat { get; set; }
    }

    public class StatModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class TypeRootModel
    {
        [JsonProperty("slot")]
        public int? Slot { get; set; }

        [JsonProperty("type")]
        public TypeModel Type { get; set; }
    }

    public class TypeModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class UltraSunUltraMoonModel
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class VersionModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VersionGroupModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VersionGroupDetailModel
    {
        [JsonProperty("level_learned_at")]
        public int? LevelLearnedAt { get; set; }

        [JsonProperty("move_learn_method")]
        public MoveLearnMethodModel MoveLearnMethod { get; set; }

        [JsonProperty("version_group")]
        public VersionGroupModel VersionGroup { get; set; }
    }

    public class VersionsModel
    {
        [JsonProperty("generation-i")]
        public GenerationIModel GenerationI { get; set; }

        [JsonProperty("generation-ii")]
        public GenerationIiModel GenerationIi { get; set; }

        [JsonProperty("generation-iii")]
        public GenerationIiiModel GenerationIii { get; set; }

        [JsonProperty("generation-iv")]
        public GenerationIvModel GenerationIv { get; set; }

        [JsonProperty("generation-v")]
        public GenerationVModel GenerationV { get; set; }

        [JsonProperty("generation-vi")]
        public GenerationViModel GenerationVi { get; set; }

        [JsonProperty("generation-vii")]
        public GenerationViiModel GenerationVii { get; set; }

        [JsonProperty("generation-viii")]
        public GenerationViiiModel GenerationViii { get; set; }
    }

    public class XYModel
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }
    }

    public class YellowModel
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_gray")]
        public string BackGray { get; set; }

        [JsonProperty("back_transparent")]
        public string BackTransparent { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_gray")]
        public string FrontGray { get; set; }

        [JsonProperty("front_transparent")]
        public string FrontTransparent { get; set; }
    }
}
