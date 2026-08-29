> Full guide: [C sharp web scraper](https://ironsoftware.com/csharp/webscraper/examples/c-sharp-web-scraper/?utm_source=github)

IronWebScraper offers a set of tools to scrape and download data or files from websites by utilizing C#.

1. Add IronWebScraper to your project via [NuGet](https://www.nuget.org/packages/IronWebScraper/).
2. Define a class that inherits from `WebScraper`.
3. Implement an `Init` method that calls the `Request` method to start processing a URL.
4. Develop a `Parse` method to handle the request responses and potentially initiate further requests. Employ `response.Css` to manipulate HTML elements efficiently, similar to jQuery's CSS selectors.
5. Instantiate your web scraping class in your application and invoke the `Start();` method.
6. Explore our [C# web scraping guides](https://ironsoftware.com/csharp/webscraper/tutorials/webscraping-in-c-sharp/?utm_source=github) for advanced techniques on developing web crawlers with IronWebScraper.

[Learn to Scrape Online Movie Websites Using C#](https://ironsoftware.com/csharp/webscraper/how-to/scraping-from-an-online-movie-website/?utm_source=github) through our detailed guide.