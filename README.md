<h1 align="center">
  <img src="https://github.com/johnpierson/OkayNotionClient/blob/main/!documentation/socialLogo.png" alt="Relay" width="800">
</h1>
<h4 align="center">Okay Notion Client aims to provide easy and okay access to the <a href="https://www.notion.so/">Notion.so</a> API for .NET users..
    <br>
<sub><sup>Notion logo credit: <a href="https://www.notion.so/Media-Kit-205535b1d9c4440497a3d7a2ac096286">Notion Media Kit</a></sub></sup>
</h4>



---
<h1 align="center">
<img src="https://github.com/johnpierson/OkayNotionClient/blob/main/!documentation/its-better-than-bad-its-good.svg" alt="Relay" width="400">
</h1>

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

## Built With
The `OkayNotionClient` project relies on a few community-published NuGet packages as listed below :
* [Newtonsoft](https://www.nuget.org/packages/newtonsoft.json/) - handles serializing and deserializing to JSON
* [RestSharp](https://www.nuget.org/packages/RestSharp/) - enables easier interaction with REST API endpoints

## Special Thanks
Special thanks to Radu for sharing [DynaWeb](https://github.com/radumg/DynaWeb). This package really helped me understand REST calls.
