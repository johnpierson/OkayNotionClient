<h1 align="center">
    just an Okay Notion Client
    <br>
  <img src="https://github.com/johnpierson/OkayNotionClient/blob/main/!documentation/notion-logo-white.png" alt="Relay" width="200">
</h1>
<h4 align="center">Okay Notion Client aims to provide easy and okay access to Notion.so's API for .NET users..</h4>

---

### Before use, read up on Notion's API at [Notion Developer Portal](https://developers.notion.com/)

## Actions Supported

### Authentication
- Provides basic authentication with RestSharp and your notion access token.

### Read
- List Databases for given access token
- List pages for selected database
- Read database properties

### Write
- NOT SUPPORTED **(YET)**

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

<img src="https://github.com/johnpierson/OkayNotionClient/blob/main/!documentation/01_Usage.gif" alt="OkayNotionUsage" width="800">

