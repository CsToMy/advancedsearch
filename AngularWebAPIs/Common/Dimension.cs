using Newtonsoft.Json;
namespace Common
{
    public class Dimension
    {
        [JsonProperty("Weight")]
        public double? Weight { get; set; }
        [JsonProperty("Height")]
        public double? Height { get; set; }
        [JsonProperty("Length")]
        public double? Length { get; set; }
        [JsonProperty("Width")]
        public double? Width { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
