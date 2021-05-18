using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace OkayNotionClient
{
    public class NotionClient
    {
        public string NotionApiUrl = @"https://api.notion.com/v1";
        private readonly RestClient _restClient;

        public NotionClient(string accessToken)
        {
            _restClient = new RestClient(NotionApiUrl) {Authenticator = new JwtAuthenticator(accessToken)};
        }

        public NotionDatabase[] ListDatabases()
        {
            List<NotionDatabase> databases = new List<NotionDatabase>();
            bool hasMore = true;
            string startCursor = "";
            while (hasMore)
            {
                var request = new RestRequest("databases", DataFormat.Json);

                if (!string.IsNullOrWhiteSpace(startCursor))
                {
                    BodyParams bodyParams = new BodyParams { start_cursor = startCursor };
                    request.AddJsonBody(bodyParams);
                }

                var response = this._restClient.Get(request);
                var databaseList = JsonConvert.DeserializeObject<NotionDatabaseList>(response.Content);

                if (databaseList.HasMore)
                {
                    startCursor = databaseList.NextCursor;
                }

                hasMore = databaseList.HasMore;

                databases.AddRange(databaseList.Databases);
            }

            return databases.ToArray();
        }

        public NotionPage[] ListPagesForDatabase(NotionDatabase notionDatabase)
        {
            List<NotionPage> pages = new List<NotionPage>();
            bool hasMore = true;
            string startCursor = "";

            while (hasMore)
            {
                var request = new RestRequest("databases/{dbId}/query", DataFormat.Json).AddUrlSegment("dbId", notionDatabase.Id);

                if (!string.IsNullOrWhiteSpace(startCursor))
                {
                    BodyParams bodyParams = new BodyParams {start_cursor = startCursor};
                    request.AddJsonBody(bodyParams);
                }

                var response = this._restClient.Post(request);
                var pageList = JsonConvert.DeserializeObject<NotionPageList>(response.Content);

                if (pageList.HasMore)
                {
                    startCursor = pageList.NextCursor;
                }
                hasMore = pageList.HasMore;

                pages.AddRange(pageList.Pages);
            }
            
            return pages.ToArray();
        }
    }
}
