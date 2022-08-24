using Newtonsoft.Json;

namespace Common
{
    public class ProductExt: Product
    {
        [JsonProperty("CurrentPage")]
        public int CurrentPage { get; set; }
        [JsonProperty("PageSize")]
        public int PageSize { get; set; }
        [JsonProperty("PriceFrom")]
        public double? PriceFrom { get; set; }
        [JsonProperty("PriceTo")]
        public double? PriceTo { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
