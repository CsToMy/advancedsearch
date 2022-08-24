using Newtonsoft.Json;

namespace Common
{
    public class Product
    {
        [JsonProperty("Id")]
        public int? Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Category")]
        public string Category { get; set; }
        [JsonProperty("Price")]
        public double Price { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Dimensions")]
        public Dimension Dimensions { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
