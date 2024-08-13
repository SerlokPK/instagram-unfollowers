using Newtonsoft.Json;

namespace InstagramUnfollowers.Models
{
    public class RelationshipFollowing
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("media_list_data")]
        public List<object> MediaListData { get; set; }

        [JsonProperty("string_list_data")]
        public List<StringListData> StringListData { get; set; }
    }
}
