using System.Text.Json;
using System.Text.Json.Serialization;

namespace thirst_burst.Model
{

    public class Drink
    {
        [JsonPropertyName("id")]
        // for example if we want to use drink_id instead of id so JaonPropertyName is used
        public int drink_id
        {
            get; set;
        }
        [JsonPropertyName("name")]
        public string name
        {
            get; set;
        }
        [JsonPropertyName("image")]
        public string image
        {
            get; set;
        }


        public override string ToString()
        {
            return JsonSerializer.Serialize<Drink>(this);

        }
    }
}