using Newtonsoft.Json;

namespace OkayNotionClient
{
    public class NotionPageProperty
    {
        [JsonProperty("id")]
		public string Id{ get; internal set; }

        [JsonProperty("type")]
        public string Type { get; internal set; }

        [JsonProperty("title")]
        public NotionRichText[] Title { get; set; }

        [JsonProperty("rich_text")]
        public NotionRichText RichText { get; set; }

        [JsonProperty("number")]
        public double Number { get; set; }

        [JsonProperty("select")]
        public NotionSelectProperty Select { get; set; }

        [JsonProperty("multi_select")]
        public NotionSelectProperty[] MultiSelect { get; set; }

        [JsonProperty("date")]
        public NotionDateProperty Date { get; set; }

        [JsonProperty("checkbox")]
        public bool Checkbox { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("last_edited_time")]
        public string LastEditedTime { get; set; }

        [JsonProperty("last_edited_by")]
        public NotionUser LastEditedBy { get; set; }
    }

    public class NotionSelectProperty : NotionPageProperty
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class NotionDateProperty
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }
}
