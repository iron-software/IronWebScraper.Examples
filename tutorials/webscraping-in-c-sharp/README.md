# Extracting Web Data Using C#

***Based on <https://ironsoftware.com/tutorials/webscraping-in-c-sharp/>***


IronWebscraper stands out as a powerful .NET library designed for web scraping, data extraction, and content parsing. This straightforward library integrates seamlessly into Microsoft Visual Studio, making it an ideal tool for both development and production environments.

Featuring a versatile set of characteristics, IronWebscraper enables precise control over permissible and forbidden content, including pages, objects, and media types. Additionally, it supports handling multiple identities and web caching, among other functionalities, all of which we will explore in detail throughout this guide.

<h3>Get started with IronWebscraper</h3>

!!!--LIBRARY_START_TRIAL_BLOCK--!!!
```

---------

## Intended Audience

This guide is designed for software developers of all skill levels, interested in developing and deploying applications that include sophisticated features for web scraping, data collection and extraction from websites, parsing web content, and harvesting information from the internet.

![Webscraping Image](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/banner.jpg)

### Prerequisite Knowledge

1. Fundamental programming skills in Microsoft programming languages such as C# or VB.NET.
   
2. An introductory understanding of web technologies including HTML, JavaScript, jQuery, and CSS.
   
3. Familiarity with key web concepts such as DOM, XPath, and CSS selectors.

### Required Tools

To work with the following software:

1. Microsoft Visual Studio, version 2010 or later.
2. Browser extensions for web development, including Chrome's Web Inspector or Firefox's Firebug.

## The Benefits of Web Scraping: Motivations and Principles

Web scraping serves as a powerful tool for anyone looking to develop a product or solution that requires:

1. Retrieval of data from websites.
2. Comparison of details such as content, prices, or features across various websites.
3. Efficient scanning and caching of web content.

For these purposes, IronWebscraper presents an ideal solution tailored to enhance your capabilities in data extraction and web content management.

## Installing IronWebScraper

Once you've initiated a new project (refer to Appendix A for details), you can incorporate the IronWebScraper library into your project either by using the NuGet Package Manager for automatic integration, or by manual DLL installation.

### NuGet Installation Method

You can integrate the IronWebScraper library into your project through NuGet either by utilizing the NuGet Package Manager's graphical interface or by executing commands in the Package Manager Console.

#### Utilizing the NuGet Package Manager

1. Navigate your cursor over your project in the Solution Explorer, right-click and select "Manage NuGet Packages".

   ![Incorporating IronWebscraper via GUI](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI.jpg)

2. In the NuGet Package Manager, go to the 'Browse' tab, enter "IronWebScraper" into the search field, and then click 'Install'.

   ![Installing IronWebscraper from GUI 2](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI2.jpg)

3. Confirm the installation by clicking 'Ok'.

   ![Confirming Installation](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI3.jpg)

4. Once it's complete, your setup is finished.

   ![Installation Complete](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI4.jpg)

#### Installing IronWebScraper via the NuGet Package Console

1. Navigate through the menus: Select `Tools` -> `NuGet Package Manager` -> `Package Manager Console`.
   
   ![Adding IronWebscraper via Console](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole.jpg)

2. Set the project type to `Class Library Project` by making it the default project in the console.

3. Execute the installation command: Enter `Install-Package IronWebScraper` in the console.

   ![Executing IronWebScraper Installation Command](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole1.jpg)

### Manual Installation Steps

1. Visit the [IronSoftware website](https://ironsoftware.com).

2. Navigate to the IronWebScraper page, either through the menu or directly via [this link](https://ironsoftware.com/csharp/webscraper/).

3. Select the 'Download DLL' option to begin downloading the necessary files.

4. Once the download is complete, unzip the compressed file to access its contents.

5. Within Visual Studio, right-click on your project in the Solution Explorer, go to 'Add' and then 'Reference...', and finally click 'Browse...'.

   ![Add IronWebscraper DLL to project](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll.jpg)

6. Navigate to the folder where you extracted the DLL files, specifically the `netstandard2.0` directory, and select all `.dll` files within.

   ![Select all necessary DLL files](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll2.png)

7. Confirm your selections and close the dialogs. The DLLs are now added to your project, completing the manual installation process!

## Introducing HelloScraper - Your First Exploration with IronWebScraper

We'll begin our journey into web scraping by introducing you to your first project using IronWebScraper: the Hello Scraper application.

* First, we established a new Console Application titled "IronWebScraperSample".

### How to Set Up Your First IronWebScraper Project

Follow these steps to get your IronWebScraper project up and running:

1. Create a directory and label it `HelloScraperSample`.

2. Proceed to create a new class within this folder, titled `HelloScraper`.

   ![Adding the HelloScraper Class](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/HelloScraperAddClass.jpg)

3. Incorporate the following code into the `HelloScraper` class:
   
   ```csharp
   public class HelloScraper : WebScraper
   {
       /// <summary>
       /// Initialize your web scraper here. Define at least one starting URL and specify any URL patterns to allow or block.
       /// </summary>
       public override void Init()
       {
           License.LicenseKey = "Your-License-Key-Here"; // Set your license key
           this.LoggingLevel = WebScraper.LogLevel.All; // Log every event
           this.Request("https://example.com/start-url", Parse); // Set up the initial web request
       }

       /// <summary>
       /// This method sets up the default response handler for your web scraper. Add more methods like this for different types of pages.
       /// </summary>
       /// <param name="response">The HTTP Response to be processed</param>
       public override void Parse(Response response)
       {
           // Define the directory to save the output
           this.WorkingDirectory = AppSetting.GetAppRoot() + @"\HelloScraperSample\Output\";
           // Loop through all links found
           foreach (var titleLink in response.Css("h2.entry-title a"))
           {
               // Extract the link text
               string title = titleLink.TextContentClean;
               // Store the result in a file
               Scrape(new ScrapedData() { { "Title", title } }, "HelloScraper.json");
           }

           // Handle pagination by looking for a "next page" link
           if (response.CssExists("div.prev-post > a[href]"))
           {
               // Fetch the URL for the next page
               var nextPage = response.Css("div.prev-post > a[href]")[0].Attributes["href"];
               // Continue scraping with the next page
               this.Request(nextPage, Parse);
           }
       }
   }
   ```
This template sets up a basic scraper with logging, initial request setup, URL navigation, and data extraction. Adjust the URL and elements based on the specifics of the site you are scraping.

```csharp
public class HelloScraper : WebScraper
{
    /// <summary>
    /// Override this method to configure the initial settings of your web scraper.
    /// It's essential to set a starting URL and establish rules for allowed and disallowed URLs or domains.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey"; // Set the license key for the scraper
        this.LoggingLevel = WebScraper.LogLevel.All; // Set the log level to capture all events
        this.Request("https://blog.scrapinghub.com", Parse); // Initiate a web request to the specified URL
    }

    /// <summary>
    /// Override this method to handle the response from the web request.
    /// You can create additional methods like this one if your scraper needs to handle different types of pages.
    /// </summary>
    /// <param name="response">The HTTP response to process</param>
    public override void Parse(Response response)
    {
        // Define the directory where the project files will be stored
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\HelloScraperSample\Output\";

        // Iterate over each link found in the specified CSS path
        foreach (var titleLink in response.Css("h2.entry-title a"))
        {
            // Extract the clean text from the link
            string title = titleLink.TextContentClean;
            // Store the extracted title in a JSON file
            Scrape(new ScrapedData() { { "Title", title } }, "HelloScraper.json");
        }

        // Check for pagination and process additional pages if they exist
        if (response.CssExists("div.prev-post > a[href]"))
        {
            // Retrieve the URL for the next page
            var nextPage = response.Css("div.prev-post > a[href]")[0].Attributes["href"];
            // Request the next page for scraping
            this.Request(nextPage, Parse);
        }
    }
}
```

Here's the paraphrased section:


4. To initiate the scraping process, include the following code in the Main function:
    
    ```csharp
    static void Main(string[] args)
    {
        // Instantiate the HelloScraper class
        HelloScraperSample.HelloScraper scrapeInstance = new HelloScraperSample.HelloScraper();
        // Trigger the scraping activity
        scrapeInstance.Start();
    }
    ```
```

In this paraphrase, I have used a slightly different wording and altered the comment within the code block to better explain the actions being performed.

Here is the paraphrased content from the given section:
-----

```csharp
    static void Main(string[] args)
    {
        // Instantiate the HelloScraper class from the HelloScraperSample namespace
        var scraper = new HelloScraperSample.HelloScraper();
        // Initiate the scraping process
        scraper.Start();
    }
```

5. The output will be stored in a file named according to the format `WebScraper.WorkingDirectory/classname.Json`.

    ![HelloScraper Result](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/HelloScraperFrmFileResult.jpg)

### Overview of the Code Behavior

When the `Scrape.Start()` is executed, it initiates the scraping process as described below:

1. It first invokes the `Init()` method, which sets up the initial state of the scraper by establishing variables, properties related to scraping, and any specific behaviors needed.

2. Within the `Init()` method, it also specifies which webpage to start scraping by calling `Request("https://blog.scrapinghub.com", Parse)`.

3. The scraper efficiently handles numerous HTTP requests and multiple threads simultaneously, maintaining synchronicity across operations for easier management and debugging.

4. Once initialized, the `Parse()` method is activated to process the incoming HTTP response. This method leverages CSS selectors to extract data, which is subsequently formatted and stored in JSON format.

## IronWebScraper Library Capabilities and Settings

For the latest updates and complete guidance, please refer to the documentation included in the zip file obtained through the manual download (`IronWebScraper Documentation.chm File`). Additionally, the most recent online instructions and references can be visited at [IronWebScraper Object Reference](https://ironsoftware.com/csharp/webscraper/object-reference/).

To incorporate the IronWebScraper into your .NET projects, you need to derive from the `IronWebScraper.WebScraper` class. This enhances your class library with powerful web scraping functionalities. You are also required to implement two essential methods: `Init()` and `Parse(Response response)`, which set up the environment for your scraping operations and handle the parsing of web responses, respectively.

Here is the paraphrased section of the article with the image path resolved against ironsoftware.com:


```csharp
namespace ScraperEngine
{
    public class CurrentNewsScraper : WebScraper
    {
        public override void Init()
        {
            // Initialization logic needed
            throw new NotImplementedException("Initializer not implemented.");
        }

        public override void Parse(Response response)
        {
            // Logic to handle the response goes here
            throw new NotImplementedException("Response parsing not implemented.");
        }
    }
}
```
```

### IronWebScraper Library Properties and Methods

#### Fundamental Methods and Properties

- `Init()`
  - **Type:** Method
  - **Description:** Initializes the web scraper, typically configuring start URLs, and setting domain or URL patterns that are allowed or banned.

- `Parse(Response response)`
  - **Type:** Method
  - **Description:** Defines how responses are handled and processed within the scraper. It allows the implementation of various scraping strategies based on different page types and structures.

#### Filtering Options

- `BannedUrls`, `AllowedUrls`, `BannedDomains`
  - **Type:** Collections
  - **Description:** Manages which URLs or domains the scraper can access or should ignore. Example usage includes `BannedUrls.Add("*.zip", "*.exe", "*.gz", "*.pdf");`, enhancing control with wildcards and regex support.

- `ObeyRobotsDotTxt`
  - **Type:** Boolean
  - **Description:** Configures the scraper to adhere to or ignore the directions provided in the site’s `robots.txt`.

- `ObeyRobotsDotTxtForHost(string Host)`
  - **Type:** Method
  - **Description:** Specifically enables or disables the observance of `robots.txt` rules for specified domains.

#### Scraping Functions

- `Scrape`, `ScrapeUnique`
  - **Type:** Method
  - **Description:** These methods handle the data extraction and saving processes, enabling distinct or repetitive data scraping actions.

#### Throttling and Request Management

- `ThrottleMode`
  - **Type:** Enumeration
  - **Description:** Configures request throttling strategies, such as `ByIpAddress` or `ByDomainHostName`, to manage request rates responsibly based on IP addresses or hostnames.

- `EnableWebCache`, `EnableWebCache(TimeSpan cacheDuration)`
  - **Type:** Method
  - **Description:** Facilitates caching of web requests to reduce load during development or repeated scrapings.

- `MaxHttpConnectionLimit`
  - **Type:** Int
  - **Description:** Dictates the maximum number of simultaneous HTTP connections (or threads) the scraper can maintain.

- `RateLimitPerHost`
  - **Type:** TimeSpan
  - **Description:** Establishes a courteous delay between requests to a specific host, ensuring respectful use of web resources.

- `OpenConnectionLimitPerHost`
  - **Type:** Int
  - **Description:** Defines the maximum number of concurrent requests permitted per host, optimizing resource usage without overwhelming the server.

#### Miscellaneous

- `WorkingDirectory`
  - **Type:** String
  - **Description:** Specifies the local directory where the scraper should store its data outputs, making data handling more organized.
```

## Practical Examples and Implementation

### Scraping a Movie Database Website

Let’s construct a scenario where we collect data from a movie database site. Start by creating a new class named `MovieScraper`:

![Create MovieScraper Class](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg)

### Understanding the HTML Layout

Consider the HTML snippet from the home page of the site:

```html
<div id="movie-featured" class="movies-list movies-list-full tab-pane in fade active">
    <div data-movie-id="20746" class="ml-item">
        <a href="https://website.com/film/king-arthur-legend-of-the-sword-20746/">
            <span class="mli-quality">CAM</span>
            <img data-original="https://img.gocdn.online/2017/05/16/poster/2116d6719c710eabe83b377463230fbe-king-arthur-legend-of-the-sword.jpg"
                 class="lazy thumb mli-thumb" alt="King Arthur: Legend of the Sword"
                 src="https://img.gocdn.online/2017/05/16/poster/2116d6719c710eabe83b377463230fbe-king-arthur-legend-of-the-sword.jpg"
                 style="display: inline-block;">
            <span class="mli-info"><h2>King Arthur: Legend of the Sword</h2></span>
        </a>
    </div>
    <div data-movie-id="20724" class="ml-item">
        <a href="https://website.com/film/snatched-20724/">
            <span class="mli-quality">CAM</span>
            <img data-original="https://img.gocdn.online/2017/05/16/poster/5ef66403dc331009bdb5aa37cfe819ba-snatched.jpg"
                 class="lazy thumb mli-thumb" alt="Snatched"
                 src="https://img.gocdn.online/2017/05/16/poster/5ef66403dc331009bdb5aa37cfe819ba-snatched.jpg"
                 style="display: inline-block;">
            <span class="mli-info"><h2>Snatched</h2></span>
        </a>
    </div>
</div>
```

From this HTML structure, notice each movie has a unique ID, title, and a link to its detailed page. Now, let's extract this data:

```csharp
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("www.website.com", Parse);
    }

    public override void Parse(Response response)
    {
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.GetAttribute("class") != "clearfix")
            {
                var movieId = div.GetAttribute("data-movie-id");
                var link = div.Css("a")[0];
                var movieTitle = link.TextContentClean;
                Scrape(new ScrapedData() { { "MovieId", movieId }, { "MovieTitle", movieTitle } }, "Movie.Jsonl");
            }
        }           
    }
}
```

### Data Model for Movies

Create a structured class `Movie` to manage our scraped data efficiently:

```csharp
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string URL { get; set; }
}
```

Revise our code to use this `Movie` class:

```csharp
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("https://website.com/", Parse);
    }

    public override void Parse(Response response)
    {
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.GetAttribute("class") != "clearfix")
            {
                var movie = new Movie
                {
                    Id = Convert.ToInt32(div.GetAttribute("data-movie-id")),
                    Title = div.Css("a")[0].TextContentClean,
                    URL = div.Css("a")[0].Attributes["href"]
                };
                Scrape(movie, "Movie.Jsonl");
            }
        }
    }
}
```

### Extending to Detailed Page Scraping

Further enhance our `Movie` class to include detailed attributes like descriptions, genres, and actors. Then use IronWebScraper to navigate and scrape detailed information:

```csharp
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string URL { get; set; }
    public string Description { get; set; }
    public List<string> Genre { get; set; }
    public List<string> Actor { get; set; }
}

public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("https://domain/", Parse);
    }

    public override IActionResult(Parse response)
    {
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.GetAttribute("class") != "clearfix")
            {
                var movie = new Movie
                {
                    Id = Convert.ToInt32(div.GetAttribute("data-movie-id")),
                    Title = div.Css("a")[0].TextContentClean,
                    URL = div.Css("a")[0].Attributes["href"]
                };
                this.Request(movie.URL, ParseDetails, new MetaData() { { "movie", movie } });
            }
        }           
    }

    public void ParseDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("movie");
        var div = response.Css("div.mvic-desc")[0];
        movie.Description = div.Css("div.desc")[0].TextContentClean;
        movie.Genre = div.Css("div > p > a").Select(element => element.TextContentClean).ToList();
        movie.Actor = div.Css("div > p:nth-child(2) > a").Select(element => element.TextContentClean).ToList();

        Scrape(movie, "Movie.Jsonl");
    }
}
```

### Extracting Data from a Movie Website

Construct a practical instance by creating a scraper targeted at a movie website.

Begin by defining a new class called `MovieScraper`:

![Setting up MovieScraper Class](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg)

### Examining the Webpage's HTML Layout

Below is a snapshot of the homepage's HTML markup that we find on the specified website:

Here's a paraphrased version of the HTML snippet you provided, with URLs resolved to ironsoftware.com:

```html
<div id="featured-movies" class="movie-list full-list fade-in active">
    <div class="movie-item" data-movie-id="20746">
        <a href="https://website.com/film/king-arthur-legend-of-the-sword-20746/">
            <span class="quality-tag">CAM</span>
            <img class="thumb lazy-load" src="https://img.gocdn.online/2017/05/16/poster/2116d6719c710eabe83b377463230fbe-king-arthur-legend-of-the-sword.jpg" 
                alt="King Arthur: Legend of the Sword"
                data-original="https://img.gocdn.online/2017/05/16/poster/2116d6719c710eabe83b377463230fbe-king-arthur-legend-of-the-sword.jpg" 
                style="display: block;">
            <span class="movie-title"><h2>King Arthur: Legend of the Sword</h2></span>
        </a>
    </div>
    <div class="movie-item" data-movie-id="20724">
        <a href="https://website.com/film/snatched-20724/">
            <span class="quality-tag">CAM</span>
            <img class="thumb lazy-load" src="https://img.gocdn.online/2017/05/16/poster/5ef66403dc331009bdb5aa37cfe819ba-snatched.jpg" 
                alt="Snatched"
                data-original="https://img.gocdn.online/2017/05/16/poster/5ef66403dc331009bdb5aa37cfe819ba-snatched.jpg"
                style="display: block;">
            <span class="movie-title"><h2>Snatched</h2></span>
        </a>
    </div>
</div>
```

This adapted version modifies some of the className attributes and text to slightly alter their presentation while maintaining the overall structure and function of the original HTML snippet.

As shown above, we have extracted key elements such as a movie ID, Title, and a Link that leads to a more detailed page. Now, let's commence with the scraping of this information:

Here is the paraphrased section of the article:

```csharp
public class MovieScraper : WebScraper
{
    /// <summary>
    /// Initializes the MovieScraper with key configurations and the initial web request.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey"; // Set the License Key for the scraper
        this.LoggingLevel = WebScraper.LogLevel.All; // Enable logging for all events
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\"; // Set the working directory for output files
        this.Request("www.website.com", Parse); // Start the scraping process by making the first web request
    }

    /// <summary>
    /// Parses the HTML content retrieved from the web request.
    /// </summary>
    /// <param name="response">The HTTP Response from the web scraper</param>
    public override void Parse(Response response)
    {
        // Loop through each div container element within the #movie-featured ID
        foreach (var div in response.Css("#movie-featured > div"))
        {
            // Check if the div class is not "clearfix", which indicates a valid movie element
            if (div.GetAttribute("class") != "clearfix")
            {
                // Extract movie ID and the movie title from the div element
                var movieId = div.GetAttribute("data-movie-id");
                var link = div.Css("a")[0];
                var movieTitle = link.TextContentClean;
                // Use Scrape method to save the gathered data as JSON
                Scrape(new ScrapedData() { { "MovieId", movieId }, { "MovieTitle", movieTitle } }, "Movie.Jsonl");
            }
        }
    }
}
```

### Defining a Movie Data Class

To organize our scraped movie data effectively, we'll design a dedicated class named `Movie`:

Below is the paraphrased section of the article, with relative URL paths resolved as requested:

```csharp
public class Film
{
    public int Identifier { get; set; }
    public string Name { get; set; }
    public string Link { get; set; }
}
```

Here's the revised section of the article that discusses updating code to utilize the Movie class, with links and image paths resolved to `ironsoftware.com` as requested:

---

### Integrating the Movie Class into Our Code

To effectively employ our defined Movie class within our scraping project, follow these refined steps:

```csharp
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("https://website.com/", Parse);
    }

    public override void Parse(Response response)
    {
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.GetAttribute("class") != "clearfix")
            {
                var movie = new Movie
                {
                    Id = Convert.ToInt32(div.GetAttribute("data-movie-id")),
                    Title = div.Css("a")[0].TextContentClean,
                    URL = div.Css("a")[0].Attributes["href"]
                };
                Scrape(movie, "Movie.Jsonl");
            }
        }
    }
}
```

This segment of code effectively integrates the `Movie` class into our scraper. By using the `Movie` class, we are able to store and manage the movie data more efficiently, allowing for structured access and manipulation of movie attributes like `Id`, `Title`, and `URL`.

```csharp
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "EnterYourLicenseKeyHere"; // Set your License Key
        this.LoggingLevel = WebScraper.LogLevel.All; // Enable logging at all levels
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\"; // Specify the output directory
        this.Request("https://example.com/", Parse); // Start the scraper by making an HTTP request to a specified URL.
    }

    public override void Parse(Response response)
    {
        // Iterate through each div within the section identified by 'movie-featured'
        foreach (var div in response.Css("#movie-featured > div"))
        {
            // Filter out div elements that do not contain any layout formatting class
            if (div.GetAttribute("class") != "clearfix")
            {
                var movie = new Movie
                {
                    Id = Convert.ToInt32(div.GetAttribute("data-movie-id")), // Extract movie ID
                    Title = div.Css("a")[0].TextContentClean, // Extract the clean title text
                    URL = div.Css("a")[0].Attributes["href"] // Extract the hyperlink reference
                };
                Scrape(movie, "Movie.Jsonl"); // Save the extracted movie data to a JSONL file
            }
        }
    }
}
```

### Scraping Detailed Page Information

In enhancing the `Movie` class, we will augment it with additional attributes to gather more detailed data:

```csharp
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string URL { get; set; }
    public string Description { get; set; }
    public List<string> Genre { get; set; }
    public List<string> Actor { get; set; }
}
```

Next, we will proceed to extract the detailed data from individual movie pages. We'll leverage IronWebScraper's robust functionality to navigate to and parse these detailed pages: 

```csharp
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("https://domain/", Parse);
    }

    public override void Parse(Response response)
    {
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.GetAttribute("class") != "clearfix")
            {
                var movie = new Movie
                {
                    Id = Convert.ToInt32(div.GetAttribute("data-movie-id")),
                    Title = div.Css("a")[0].TextContentClean,
                    URL = div.Css("a")[0].Attributes["href"]
                };
                this.Request(movie.URL, ParseDetails, new MetaData() { { "movie", movie } });
            }
        }           
    }

    public void ParseDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("movie");
        var div = response.Css("div.mvic-desc")[0];
        movie.Description = div.Css("div.desc")[0].TextContentClean;
        movie.Genre = div.Css("div > p > a").Select(element => element.TextContentClean).ToList();
        movie.Actor = div.Css("div > p:nth-child(2) > a").Select(element => element.TextContentClean).ToList();

        Scrape(movie, "Movie.Jsonl");
    }
}
```

This process will allow the extraction of a rich set of information about each movie, including descriptions, genres, and actors, thus providing a comprehensive dataset for any related application or analysis.

Here's a paraphrased version of the provided C# class definition for handling movie data:

```csharp
public class Film
{
    public int Identifier { get; set; }
    public string Name { get; set; }
    public string WebLink { get; set; }
    public string Summary { get; set; }
    public List<string> Categories { get; set; }
    public List<string> Cast { get; set; }
}
```

Navigate to the specific page that contains detailed information in order to thoroughly scrape it, utilizing the enhanced features of IronWebScraper:

Here is the paraphrased section of the article:

```csharp
public class MovieScraper : WebScraper
{
    /// <summary>
    /// Set up the initial configurations and properties for the scraper.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        // Set the logging level to track all events
        this.LoggingLevel = WebScraper.LogLevel.All;
        // Define the output directory for our data
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        // Start the scraping process by making the first request
        this.Request("https://domain/", Parse);
    }

    /// <summary>
    /// Process and parse the response to extract movie details.
    /// </summary>
    /// <param name="response">The page response to handle.</param>
    public override void Parse(Response response)
    {
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.GetAttribute("class") != "clearfix")
            {
                var movie = new Movie
                {
                    Id = Convert.ToInt32(div.GetAttribute("data-movie-id")),
                    Title = div.Css("a")[0].TextContentClean,
                    URL = div.Css("a")[0].Attributes["href"]
                };
                // Dive deeper into the movie details page
                this.Request(movie.URL, ParseDetails, new MetaData() { { "movie", movie } });
            }
        }
    }

    /// <summary>
    /// Fetch and parse additional details from the movie's main page.
    /// </summary>
    /// <param name="response">The detailed page response.</param>
    public void ParseDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("movie");
        var detailsDiv = response.Css("div.mvic-desc")[0];
        movie.Description = detailsDiv.Css("div.desc")[0].TextContentClean;
        movie.Genre = detailsDiv.Css("div > p > a").Select(a => a.TextContentClean).ToList();
        movie.Actor = detailsDiv.Css("div > p:nth-child(2) > a").Select(a => a.TextContentClean).ToList();

        // Save the scrapped movie information
        Scrape(movie, "Movie.Jsonl");
    }
}
```

In this rewritten block, the comments have been added or extended to give a better context of code functionality, and the code structure was slightly rephrased to ensure the clarity of each step.

## Features of the IronWebScraper Library

### Authentication with HttpIdentity

For accessing content on platforms that necessitate user authentication, you can incorporate `HttpIdentity` into your scraper. It effectively manages credentials:

```csharp
HttpIdentity id = new HttpIdentity
{
    NetworkUsername = "username",
    NetworkPassword = "password"
};
Identities.Add(id);
```

### Enabling Web Cache

Integrate caching to store web pages for repeated use, enhancing efficiency during the development:

```csharp
public override void Init()
{
    License.LicenseKey = "YourLicenseKeyHere";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ECommerceScraper\Output\";
    EnableWebCache(); // Turn on caching
    this.Request("http://example.com", Parse);
}
```

### Throttling Configurations

Manage connections and request rate to adhere to website t&c:

```csharp
public override void Init()
{
    License.LicenseKey = "YourLicenseKeyHere";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingPortalScraper\Output\";
    this.MaxHttpConnectionLimit = 60;  // Max open HTTP connections
    this.RateLimitPerHost = TimeSpan.FromMilliseconds(100);  // Min delay between requests to the same host
    this.OpenConnectionLimitPerHost = 20;  // Max concurrent requests to the same host
    this.ObeyRobotsDotTxt = true;  // Respect robots.txt rules
    this.ThrottleMode = Throttle.ByDomainHostName;  // Throttle by domain name
    this.Request("https://samplewebsite.com", Parse);
}
```

#### Detailed Throttling Options

- `MaxHttpConnectionLimit`: The maximum number of simultaneous HTTP requests.
- `RateLimitPerHost`: The minimum delay between subsequent requests to the same domain or IP.
- `OpenConnectionLimitPerHost`: The maximum number of parallel HTTP requests per host.
- `ThrottleMode`: Configures the scraper to smartly limit requests not just by the host's name but also by IP, promoting polite scraping practices especially if multiple targeted domains reside on the same server.

### HttpIdentity Capability

Certain platforms mandate user authentication to access specific content. Utilize the `HttpIdentity` object for managing credentials:

Here's the paraphrased section of the article:

```csharp
HttpIdentity httpId = new HttpIdentity
{
    NetworkUsername = "username", // Replace with actual username
    NetworkPassword = "password"  // Replace with actual password
};
Identities.Add(httpId);
```

This revised code snippet continues to set up an HTTP identity with credentials, which is then added to the identities collection, using different variable names and comments for clarity.

### Implement Web Caching

Save previously requested pages for efficient reuse throughout the development process:

Here is the paraphrased section of the article with the relative URL paths resolved to "ironsoftware.com":

```csharp
public override void Init()
{
    License.LicenseKey = "Your-License-Key-Here"; // Insert your license key
    this.LoggingLevel = WebScraper.LogLevel.All; // Log all events for debugging
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\"; // Set the directory for saving output
    EnableWebCache(); // Activate caching to save and reuse web pages during development
    this.Request("http://www.ironsoftware.com/WebSite.com", Parse); // Initial request to start scraping
}
``` 

This code snippet initializes the scraping process, setting essential configurations like logging level, working directory, and web cache enabling. It also makes the first web request to start the scraping operation.

### Managing Connection Throttling

Adjust the quantity and pace of your connections:

Here's the paraphrased version of the given section:

```csharp
public override void Init()
{
    // Set your license key here
    License.LicenseKey = "LicenseKey";
    // Configure logging level to capture all events
    this.LoggingLevel = WebScraper.LogLevel.All;
    // Define the directory for storing output files
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    // Set the maximum number of simultaneous HTTP connections
    this.MaxHttpConnectionLimit = 80;
    // Specify the minimum delay between requests to the same host
    this.RateLimitPerHost = TimeSpan.FromMilliseconds(50);
    // Limit the number of concurrent requests per host
    this.OpenConnectionLimitPerHost = 25;
    // Decide whether to adhere to robots.txt rules
    this.ObeyRobotsDotTxt = false;
    // Set the throttle mode to handle requests by the host's domain name
    this.ThrottleMode = Throttle.ByDomainHostName;
    // Begin requesting data from the website
    this.Request("https://www.Website.com", Parse);
}
```

#### Throttling Options

* `MaxHttpConnectionLimit`<br>Total maximum simultaneous HTTP requests allowed (thread count).

* `RateLimitPerHost`<br>Minimum courteous wait time (in milliseconds) between requests to a specific domain or IP address.

* `OpenConnectionLimitPerHost`<br>Maximum permitted simultaneous HTTP requests per domain or IP address.

* `ThrottleMode`<br>Enables the WebScraper to strategically limit requests based on hostname and IP address. This ensures polite behavior when multiple domains being scraped reside on a single server.

## Additional Resources

### Setting up a Windows Forms Application

For developers looking to construct a Windows Forms Application, it's advisable to use Visual Studio 2013 or newer versions.

1. Begin by opening Visual Studio.
   ![Visual Studio Enterprise 2015](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg)

2. Navigate through the menu: File -> New -> Project
   ![Starting a New Project](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg)

3. Select either Visual C# or VB under 'Windows' and choose 'Windows Forms Application'.
   ![Creating a Windows Application](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/CreateWindowsApp.jpg)

   **Project Name**: IronScraperSample
   **Location**: Choose a suitable directory on your computer.

### Establishing an ASP.NET Web Form Application

To create an ASP.NET Web Form Application, follow these steps using Visual Studio:

1. Open Visual Studio.
   ![Visual Studio Enterprise 2015](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg)

2. Go to: File -> New -> Project
   ![File to New Project](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg)

3. Opt for Visual C# or VB, select 'Web' followed by 'ASP.NET Web Application (.NET Framework)'.
   ![ASP.NET Web Application Setup](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETWebApplication.jpg)

   **Project Name**: IronScraperSample
   **Location**: Select a location on your disk where you want the project to reside.

4. Choose an empty template and make sure to check 'Web Forms'.
   ![Selecting ASP.NET Templates](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETTemplates.jpg)

5. You have now successfully set up the basics of your ASP.NET Web Form Project.
   ![ASP.NET Web Form Project Created](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETWebFormProject.jpg)

[Download the complete sample project code here](https://ironsoftware.com/downloads/assets/tutorials/webscraping-in-c-sharp/IronWebScraperSample.zip).

### Creating a Windows Form Application with Visual Studio 2013 or Later

Ensure you're using Visual Studio 2013 or a newer version for this setup.

1. Launch Visual Studio.

   ![Visual Studio Enterprise 2015](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg)

2. Navigate to `File` -> `New` -> `Project`.

   ![New Project Option](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg)

3. From the options, select either Visual C# or Visual Basic, then choose `Windows` followed by `Windows Forms Application`.

   ![Windows Forms Application](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/CreateWindowsApp.jpg)

**Project Details:**

- **Project Name**: IronScraperSample
- **Location**: Choose a storage location on your machine.

### Creating an ASP.NET Web Form Application

1. Launch Visual Studio.

   ![Visual Studio 2015 Enterprise](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg)

2. Navigate through the menu: File -> New -> Project

   ![New Project Menu](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg)

3. Select either Visual C# or Visual Basic, then go to Web -> ASP.NET Web Application (.NET Framework).

   ![ASP.NET Web Application Option](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETWebApplication.jpg)

   **Project Name**: IronScraperSample

   **Location**: Choose a directory on your computer to save the project.

4. Within the ASP.NET project templates, opt for an empty template and make sure to select Web Forms.

   ![ASP.NET Templates](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETTemplates.jpg)

5. Upon completion, you will have set up a basic ASP.NET Web Form Project.

   ![ASP.NET Web Form Project Created](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETWebFormProject.jpg)

[Download the complete tutorial sample project code here](https://ironsoftware.com/downloads/assets/tutorials/webscraping-in-c-sharp/IronWebScraperSample.zip).

