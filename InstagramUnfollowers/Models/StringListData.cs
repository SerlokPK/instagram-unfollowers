using Newtonsoft.Json;

namespace InstagramUnfollowers.Models
{
    public class StringListData
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
