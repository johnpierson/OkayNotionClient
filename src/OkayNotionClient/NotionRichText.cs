using Newtonsoft.Json;

namespace OkayNotionClient
{
    public class NotionRichText
    {
        private NotionRichText()
        {
        }

        [JsonProperty("plain_text")]
        public string PlainText { get; internal set; }

        [JsonProperty("href")]
        public string Href { get; internal set; }

        [JsonProperty("annotations")]
        public object Annotations { get; internal set; }

        [JsonProperty("type")]
        public string Type { get; internal set; }
    }
   
}
