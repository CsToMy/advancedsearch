using Newtonsoft.Json;
using System;

namespace Common
{
    public class Dimension
    {
        [JsonProperty(PropertyName = "Weight", DefaultValueHandling = DefaultValueHandling.Include, Required = Required.AllowNull)]
        public double? Weight { get; set; }

        [JsonProperty(PropertyName = "Height", DefaultValueHandling = DefaultValueHandling.Include, Required = Required.AllowNull)]
        public double? Height { get; set; }

        [JsonProperty(PropertyName = "Length", DefaultValueHandling = DefaultValueHandling.Include, Required = Required.AllowNull)]
        public double? Length { get; set; }

        [JsonProperty(PropertyName = "Width", DefaultValueHandling = DefaultValueHandling.Include, Required = Required.AllowNull)]
        public double? Width { get; set; }


        [JsonProperty(PropertyName = "SizeUnit", DefaultValueHandling = DefaultValueHandling.Include, Required = Required.Always)]
        public string SizeUnit { get; set; } = "m";

        [JsonProperty(PropertyName = "WeightUnit", DefaultValueHandling = DefaultValueHandling.Include, Required = Required.Always)]
        public string WeightUnit { get; set; } = "kg";
        
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented)??
                throw new InvalidOperationException("Cannot serialize this object.");
        }

    }
}
