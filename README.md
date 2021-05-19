# OkayNotionClient
This is an okay notion client for C# use.

Definitely not perfect. but here it is.

It exposes notion databases, pages and properties as objects.


here is what it looks like in dynamo:

<img src="https://github.com/johnpierson/OkayNotionClient/blob/main/!documentation/00_Nodes.png" alt="NotionNodes" width="500">

the long term goal of this would be to enable a full object-oriented notion C# library.

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
