![Nuget Version](https://img.shields.io/nuget/v/IronWebScraper?color=informational&label=latest) ![Nuget Installs](https://img.shields.io/nuget/dt/IronWebScraper?color=informational&label=installs&logo=nuget) ![Build Status](https://img.shields.io/badge/build-%20%E2%9C%93%20925%20tests%20passed%20(0%20failed)%20-107C10?logo=visualstudio) [![Windows Compatibility](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=windows)](https://ironsoftware.com/csharp/webscraper/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield) [![Live Chat Status](https://img.shields.io/badge/Live%20Chat-Active-purple?logo=googlechat&logoColor=white)](https://ironsoftware.com/csharp/webscraper/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield#helpscout-support)

## Iron WebScraper - The C# Library for Web Scraping

[![IronWebscraper NuGet Trial Banner Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronWebscraper-readme/nuget-trial-banner.png)](https://ironsoftware.com/csharp/webscraper/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topbanner#trial-license)

[Get Started](https://ironsoftware.com/csharp/webscraper/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Code Examples](https://ironsoftware.com/csharp/webscraper/examples/c-sharp-web-scraper/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Licensing](https://ironsoftware.com/csharp/webscraper/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation) | [Free Trial](https://ironsoftware.com/csharp/webscraper/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=navigation#trial-license)

Iron WebScraper is a robust C# library for web scraping. It simulates human browsing patterns to extract content, files, and images from web applications and provides them as native .Net objects. This library ensures polite and efficient multithreading while simplifying maintenance and understanding of your application.

It is ideal for content migration, building search indexes, and tracking changes in website structure or content.

#### Features of Iron WebScraper:

  * Utilizes html DOM, Javascript, Xpath, and jQuery Style CSS Selectors to extract structured content.
  * Employs fast multithreading for handling numerous simultaneous requests.
  * Elegantly manages demand on servers with IP/domain level throttling and support for robots.txt.
  * Handles multiple identities, DNS, proxies, user agents, custom headers, methods, cookies, and logins.
  * Converts data scraped from websites into manageable C# objects for immediate use or storage.
  * Incorporates exception handling outside the developer's code, with automatic retries on errors or captchas.
  * Features to save, pause, resume, and autosave scraping tasks.
  * Includes a built-in web cache for replaying actions, crash recovery, and data query without network traffic.

#### Supported Platforms for Iron WebScraper include:

  * **.NET 6** and versions down to .NET Framework
  * Platforms like Windows, macOS, Linux, and containers such as Docker, Azure, and AWS

[![IronWebScraper Platform Compatibility Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronWebscraper-readme/cross-platform-compatibility.png)](https://ironsoftware.com/csharp/webscraper/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=crossplatformbanner)

For comprehensive API references and full licensing details, please visit our website.

#### Getting Started with Iron WebScraper

To integrate IronWebScraper into your project, simply install the package via NuGet:

```powershell
PM> Install-Package IronWebScraper
```

Begin by importing Iron Web Scraper into your C# application like so:

```csharp
using IronWebScraper;

namespace YourApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var ScrapeJob = new BlogScraper();
            ScrapeJob.Start();
        }
    }

    public class BlogScraper : WebScraper
    {
        public override void Init()
        {
            LoggingLevel = LogLevel.All;
            Request("https://www.zyte.com/blog/", Parse);
        }

        public override void Parse(Response response)
        {
            foreach (HtmlNode title_link in response.Css(".oxy-post-title"))
            {
                string strTitle = title_link.TextContentClean;
                Scrape(new ScrapedData() { { "Title", strTitle } });
            }

            if (response.CssExists("div.oxy-easy-posts-pages > a[href]"))
            {
                string next_page = response.Css("div.oxy-easy-posts-pages > a[href]")[0].Attributes["href"];
                Request(next_page, Parse);
            }
        }
    }
}
```

### Support & Licensing

Explore code samples, tutorials, and detailed documentation at [Iron Web Scraper Learning Resources](https://ironsoftware.com/csharp/webscraper/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs).

For direct support, contact us at developers@ironsoftware.com. We provide extensive support and licensing options for commercial projects.