using Newtonsoft.Json;

namespace PriceAlert_Ragnatales.Models
{
    internal class Item
    {
        [JsonProperty("nameid")]
        public int id { get; set; }
        public string? jname { get; set; }
    }
}
