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
        [JsonProperty] public Weapon EquippedWeapon {get; set; }
        [JsonProperty] public Artifact[] EquippedArtifacts {get; set; }
        [JsonProperty] public int Constellation {get; set; }
        [JsonProperty] public int[] Talents {get; set; }
    }
}