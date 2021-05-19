# This is an Okay Notion Client
_Providing access to Notion.so's API for .NET users._


### Before use, read up on Notion's API at [Notion Developer Portal](https://developers.notion.com/)

## Actions Supported

### Authentication
- Authentication with RestSharp and your notion access token.
- 
### Read
- List Databases for given access token
- List pages for selected database
- Read database properties

### Write
- NOT SUPPORTED (YET)

---

## Usage

The library can be used as follows:
```csharp
using System;
using System.Linq;
using OkayNotionClient;

namespace NotionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            NotionClient client = new NotionClient(yourAccessTokenHere);

            var firstDatabase = client.ListDatabases().First();
            
            Console.WriteLine($"fetching pages for {firstDatabase.Title.First().PlainText}");

            var pages = client.ListPagesForDatabase(firstDatabase);

            foreach (var page in pages)
            {
                Console.WriteLine($"page id: {page.Id} was last edited at {page.LastEditedTime}");
            }
            Console.ReadLine();
        }
    }
}
```

resulting in:
 <img src="https://github.com/johnpierson/OkayNotionClient/blob/main/!documentation/01_Usage.gif" alt="OkayNotionUsage" width="600">

