# IronWebScraper.Examples

Runnable C# examples for [IronWebScraper](https://ironsoftware.com/csharp/webscraper/?utm_source=github), a .NET web scraping library that crawls sites with CSS selectors, request throttling, and multi-threaded workers.

## Install

```bash
dotnet add package IronWebScraper
```

## Quickstart

```csharp
using IronWebScraper;

public class BlogScraper : WebScraper
{
    public override void Init()
    {
        LoggingLevel = LogLevel.All;
        Request("https://www.example.com/blog/", Parse);
    }

    public override void Parse(Response response)
    {
        foreach (HtmlNode title in response.Css(".post-title"))
        {
            Scrape(new ScrapedData() { { "Title", title.TextContentClean } });
        }

        if (response.CssExists("a.next-page[href]"))
        {
            Request(response.Css("a.next-page[href]")[0].Attributes["href"], Parse);
        }
    }
}

new BlogScraper().Start();
```

A scraper subclasses `WebScraper`, queues URLs from `Init()`, and handles each response in a parse method. `response.Css(selector)` selects nodes, `Scrape(...)` writes a row to the output, and calling `Request(url, Parse)` again from inside a parse method is how pagination and detail-page crawling work.

For production use, set a license key via `License.LicenseKey = "YOUR-KEY"`.

## What's in this repo

Each folder contains a self-contained .NET project you can open and run:

- `examples/` — a focused single-file scraper
- `get-started/` — license-key setup
- `how-to/` — task-oriented guides scraping a shopping site and a movie database
- `quickstart/` — a project scaffold to start from
- `tutorials/` — longer walkthroughs, from a first blog scraper to advanced multi-page crawls

## Common tasks covered

- Subclassing `WebScraper` and queueing URLs from `Init()`
- Selecting content with CSS selectors and reading node text and attributes
- Following pagination and crawling from listing pages into detail pages
- Writing structured rows with `ScrapedData`
- Multiple parse methods for different page shapes on one site
- Logging levels and diagnosing a crawl
- Throttling and politeness: `MaxHttpConnectionLimit`, `RateLimitPerHost`, `ThrottleMode`, `ObeyRobotsDotTxt`
- Identity rotation with `HttpIdentity`, and response caching with `EnableWebCache`

## Platform support

.NET Standard 2.0 and 2.1 — so .NET 8, 7, 6, 5, .NET Core 2.0+, and .NET Framework 4.6.1+. Windows, macOS, Linux, Docker, Azure, and AWS. See the [documentation](https://ironsoftware.com/csharp/webscraper/docs/?utm_source=github) for environment-specific notes.

## Documentation and support

- Full documentation: [ironsoftware.com/csharp/webscraper/docs](https://ironsoftware.com/csharp/webscraper/docs/?utm_source=github)
- API reference: [ironsoftware.com/csharp/webscraper/object-reference/api](https://ironsoftware.com/csharp/webscraper/object-reference/api/?utm_source=github)
- Issues with these examples: file directly on this repository
- Product support: [support@ironsoftware.com](mailto:support@ironsoftware.com)

## About

This repository is maintained by [Iron Software](https://ironsoftware.com/?utm_source=github). IronWebScraper is a commercial library — see [licensing](https://ironsoftware.com/csharp/webscraper/licensing/?utm_source=github) for terms and trial details.

Scrape responsibly: check a site's terms of service and `robots.txt` before crawling it.
