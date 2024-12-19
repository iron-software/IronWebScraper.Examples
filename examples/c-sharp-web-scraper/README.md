***Based on <https://ironsoftware.com/examples/c-sharp-web-scraper/>***

IronWebScraper offers a robust framework enabling the extraction of data and files from websites by writing C# codes.

1. Add IronWebScraper to your project with the help of [NuGet](https://www.nuget.org/packages/IronWebScraper/).
2. Extend the `WebScraper` class by creating a new Class.
3. Implement an `Init` method that leverages the `Request` method to at least initiate parsing of one URL.
4. Design a `Parse` method that handles the processing of the requests and allows for further page requests. Employ `response.Css` to manipulate HTML elements using jQuery-style selectors.
5. Initialize an instance of your web scraping class in your application and invoke the `Start();` method.
6. Enhance your skills by reading through our [C# web scraping tutorials](https://ironsoftware.com/csharp/webscraper/tutorials/webscraping-in-c-sharp/) where you can learn to develop sophisticated web crawlers using IronWebScraper.