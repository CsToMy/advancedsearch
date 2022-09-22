using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace Common
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Product
    {
        [JsonProperty("Id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "Name", DefaultValueHandling = DefaultValueHandling.Include, Required = Required.Always)]
        public string Name { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "Category", DefaultValueHandling = DefaultValueHandling.Include, Required = Required.Always)]
        public string Category { get; set; } = string.Empty;
        
        [JsonProperty(PropertyName = "Price", DefaultValueHandling = DefaultValueHandling.Include, Required = Required.Always)]
        public double Price { get; set; }
        
        [JsonProperty(PropertyName = "Description", DefaultValueHandling = DefaultValueHandling.Include, Required = Required.AllowNull)]
        public string? Description { get; set; }

        [JsonProperty("Dimensions")]
        public Dimension? Dimensions { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented)??
                throw new InvalidOperationException("Cannot serialize this object.");
        }
    }
}
