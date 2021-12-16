using Newtonsoft.Json;

namespace GenshinScanner.Data
{
    public class Character
    {
        // JSON properties
        [JsonProperty] public string Name {get; set; }
        [JsonProperty] public int ID {get; set; }
        [JsonProperty] public int Element {get; set; }
        [JsonProperty] public int Level {get; set; }
        [JsonProperty] public bool Ascension {get; set; }
        [JsonProperty] public int Experience {get; set; }
#pragma warning disable CS0436 // Type conflicts with imported type
        [JsonProperty] public Weapon EquippedWeapon {get; set; }
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning disable CS0436 // Type conflicts with imported type
        [JsonProperty] public Artifact[] EquippedArtifacts {get; set; }
#pragma warning restore CS0436 // Type conflicts with imported type
        [JsonProperty] public int Constellation {get; set; }
        [JsonProperty] public int[] Talents {get; set; }
    }
}