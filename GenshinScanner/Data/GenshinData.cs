using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;

namespace GenshinScanner.Data
{
    public class GenshinData
    {
        [JsonProperty]
        private static List<Character> Characters = new List<Character>();
    }
}