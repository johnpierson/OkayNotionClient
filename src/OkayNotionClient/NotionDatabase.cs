using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OkayNotionClient
{
    public class NotionDatabaseList
    {
        private NotionDatabaseList() { }
        [JsonProperty("results")]
        public NotionDatabase[] Databases { get; internal set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; internal set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; internal set; }
    }
    public class NotionDatabase
    {
        private NotionDatabase() { }
        [JsonProperty("id")]
        public string Id { get; internal set; }

        [JsonProperty("created_time")]
        public DateTime CreatedTime { get; internal set; }

        [JsonProperty("last_edited_time")]
        public DateTime LastEditedTime { get; internal set; }

        [JsonProperty("title")]
        public NotionRichText[] Title { get; internal set; }

        [JsonProperty("properties")]
        public Dictionary<string, object> Properties { get; internal set; } = new Dictionary<string, object>();

    }
}
