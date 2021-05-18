using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OkayNotionClient
{
    public class NotionPageList
    {
        private NotionPageList() { }

        [JsonProperty("results")]
        public NotionPage[] Pages { get; internal set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; internal set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; internal set; }
    }


    public class NotionPage
    {
        private NotionPage() { }

        [JsonProperty("id")]
        public string Id { get; internal set; }

        [JsonProperty("created_time")]
        public DateTime CreatedTime { get; internal set; }

        [JsonProperty("last_edited_time")]
        public DateTime LastEditedTime { get; internal set; }

        [JsonProperty("archived")]
        public bool Archived { get; internal set; }

        [JsonProperty("properties")]
        public Dictionary<string, NotionPageProperty> Properties { get; internal set; } = new Dictionary<string, NotionPageProperty>();
    }

    public class BodyParams
    {
        public string start_cursor { get;  set; }
    }
    
}
