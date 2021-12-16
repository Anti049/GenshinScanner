using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;

namespace GenshinScanner.Data
{
    public class GenshinData
    {
#pragma warning disable CS0436 // Type conflicts with imported type
#pragma warning disable CS0436 // Type conflicts with imported type
        [JsonProperty] private static List<Character> Characters = new List<Character>();
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning disable CS0436 // Type conflicts with imported type
#pragma warning disable CS0436 // Type conflicts with imported type
        [JsonProperty] private static InventoryData Inventory = new InventoryData();
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning restore CS0436 // Type conflicts with imported type
        
    }
}