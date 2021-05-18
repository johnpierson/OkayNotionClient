using Newtonsoft.Json;

namespace OkayNotionClient
{
    public class NotionUser
    {
        [JsonProperty("id")]
        public string Id { get; internal set; }

        [JsonProperty("type")]
        public string Type { get;}

        [JsonProperty("name")]
        public object Name { get;}

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get;}

        [JsonProperty("email")]
        public string Email { get;}
    }
}
