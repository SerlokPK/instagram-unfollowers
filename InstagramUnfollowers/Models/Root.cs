using Newtonsoft.Json;

namespace InstagramUnfollowers.Models
{
    public class Root
    {
        [JsonProperty("relationships_following")]
        public List<RelationshipFollowing> RelationshipsFollowing { get; set; }
    }
}
