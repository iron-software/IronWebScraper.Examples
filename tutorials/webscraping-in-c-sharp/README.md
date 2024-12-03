# How to Extract Data from Websites in C#

***Based on <https://ironsoftware.com/tutorials/webscraping-in-c-sharp/>***


IronWebScraper is a robust .NET library designed for web scraping, data extraction, and content parsing. This user-friendly library integrates seamlessly with Microsoft Visual Studio, supporting both development and production environments.

IronWebScraper offers a rich set of capabilities including the ability to specify allowed and prohibited pages, objects, and media types. Additionally, it supports multiple identities and web caching among other advanced features, all of which we will explore in this tutorial.

## Intended Readership

This guide is designed for software developers, whether novices or experts, who are interested in developing and deploying advanced web scraping tools. These tools are intended to facilitate the scraping of website data, the extraction of content, and the parsing of web pages for various applications.

<div class="article-img tutorial-img">
	<img src="/img/tutorials/webscraping-in-c-sharp/banner.jpg" alt="Webscraping has never been a simple task, with no dominant frameworks for use in C# or .NET programming environments. Iron Web Scraper was created to change this" class="img-responsive">
</div>

### Prerequisites

1. Fundamental programming knowledge and proficiency in a Microsoft programming language like C# or VB.NET.
  
2. An introductory understanding of web technologies, including HTML, JavaScript, JQuery, and CSS, along with their functionalities.
  
3. Elementary comprehension of DOM, XPath, and how to utilize HTML and CSS selectors.

### Essential Development Tools

1. Microsoft Visual Studio, Version 2010 or newer.
2. Browser development tools/extensions like Chrome's Web Inspector or Firefox's Firebug.

## Reasons to Consider Web Scraping

Web scraping is essential for those looking to develop products or solutions capable of:

1. Retrieving data from websites.
2. Analyzing and comparing information such as content, prices, and features across various websites.
3. Recording and caching web content for efficient data retrieval and usage.

For such requirements, IronWebscraper serves as an ideal toolkit tailored to streamline your web data extraction needs.

## Installing IronWebScraper

Once you've set up a new project (refer to Appendix A for details), you can integrate the IronWebScraper library into your project. This can be accomplished either by utilizing NuGet for an automated installation or by manually adding the DLL file.

### NuGet Installation Method

Incorporating the IronWebScraper library into your project is straightforward with NuGet, which offers both a graphical user interface and a command-line option. 

#### Using the NuGet Package Manager GUI

1. Right-click on your project name in the solution explorer and select 'Manage NuGet Packages.'
   ![Manage NuGet Packages](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI.jpg)
2. Navigate to the 'Browse' tab, search for `IronWebScraper`, and click 'Install.'
   ![Install IronWebScraper](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI2.jpg)
3. Confirm any prompts to proceed with the installation.
   ![Confirm Installation](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI3.jpg)
4. Once completed, you will see the installation success notification.
   ![Installation Complete](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI4.jpg)

#### Using the Package Manager Console

1. Open the Package Manager Console by navigating through 'Tools' -> 'NuGet Package Manager' -> 'Package Manager Console.'
   ![Open Package Manager Console](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole.jpg)
2. Set your target project as the Default Project in the console.
3. Execute the command: `Install-Package IronWebScraper`.
   ![Install Command](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole1.jpg)

With these methods, you can effectively integrate the IronWebScraper library into your .NET project using NuGet.

#### Installing IronWebScraper with NuGet Package Manager

To integrate IronWebScraper into your project via NuGet using the graphical interface, follow these simple steps:

1. Right-click on your project in the Solution Explorer and select "Manage NuGet Packages".
<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI.jpg" class="img-responsive add-shadow img-margin"></a></p>

2. Navigate to the "Browse" tab, search for "IronWebScraper", and hit "Install" to add the library to your project.
<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI2.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI2.jpg" class="img-responsive add-shadow img-margin"></a></p>

3. Confirm any prompts by clicking "OK".
<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI3.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI3.jpg" class="img-responsive add-shadow img-margin"></a></p>

4. Once the package is successfully installed, your setup is complete.
<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI4.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI4.jpg" class="img-responsive add-shadow img-margin"></a></p>

By following these steps, IronWebScraper will be added to your project, allowing you to commence web scraping tasks effortlessly.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI.jpg" class="img-responsive add-shadow img-margin"></a></p>

2. Navigate to the browse tab, type in `IronWebScraper` in the search field, and select the Install option.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI2.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI2.jpg" class="img-responsive add-shadow img-margin"></a></p>

3. Confirm your selection by clicking on the "Ok" button.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI3.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI3.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's the paraphrased section from the article:

4. That's all there is to it!

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI4.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI4.jpg" class="img-responsive add-shadow img-margin"></a></p>

#### Utilizing the NuGet Package Console

1. Navigate through `Tools` -> `NuGet Package Manager` -> `Package Manager Console`.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole.jpg" class="img-responsive add-shadow img-margin"></a></p>

```
2. Set the Default Project to a Class Library Project.

3. Execute the command: `Install-Package IronWebScraper`
```

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole1.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole1.jpg" class="img-responsive add-shadow img-margin"></a></p>

### Manual Installation Guide

1. Visit [Iron Software's main website](https://ironsoftware.com).

2. Navigate to the IronWebScraper product page directly at [https://ironsoftware.com/csharp/webscraper](https://ironsoftware.com/csharp/webscraper).

3. Select the 'Download DLL' option.

4. Upon downloading, unzip the compressed file.

5. In Visual Studio, right-click on your project in the solution explorer, choose 'Add', then 'Reference', and then use 'Browse' to locate the extracted DLL files.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll.jpg" class="img-responsive add-shadow img-margin"></a></p>

6. Navigate to the `netstandard2.0` folder within the extracted directory and select all `.dll` files.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll2.png" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll2.png" class="img-responsive add-shadow img-margin"></a></p>

7. Installation Complete!

## HelloScraper - Introducing Our First IronWebScraper Example

We will begin by creating our initial application using IronWebScraper to demonstrate its basic usage.

* A new console application has been set up with the title "IronWebScraperSample."

### Steps to Configure IronWebScraper Sample

1. Generate a folder titled "HelloScraperSample."
   
2. Next, create a class named "HelloScraper."

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/HelloScraperAddClass.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/HelloScraperAddClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's the paraphrased content with resolved relative URL paths for links and images, as requested:


-----
3. Insert the Following Code into HelloScraper

```cs
public class HelloScraper : WebScraper
{
    /// <summary>
    /// Initialize settings and configurations for the web scraper.
    /// Be sure to set up at least one starting URL and manage domain or URL patterns for allowed or restricted access.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey"; // Use your actual license key here
        this.LoggingLevel = WebScraper.LogLevel.All; // Enables logging of all events
        this.Request("https://blog.scrapinghub.com", Parse); // Initiating the first page request
    }

    /// <summary>
    /// Define the default method to handle web responses. Modify this method to suit the handling of different types of pages.
    /// </summary>
    /// <param name="response">Received http response object for parsing</param>
    public override void Parse(Response response)
    {
        // Setting the directory where the scraped data will be stored
        this.WorkingDirectory = AppSetting.GetAppRoot()+ @"\HelloScraperSample\Output\";

        // Iterating over each link found in the specified CSS selector
        foreach (var title_link in response.Css("h2.entry-title a"))
        {
            // Extract the text content from the link
            string strTitle = title_link.TextContentClean;

            // Save the extracted title to a JSON file
            Scrape(new ScrapedData() { { "Title", strTitle } }, "HelloScraper.json");
        }

        // Check for the existence of pagination links
        if (response.CssExists("div.prev-post > a[href]"))
        {
            // Retrieve the URL of the next page
            var next_page = response.Css("div.prev-post > a[href]")[0].Attributes["href"];

            // Make a request to the next page
            this.Request(next_page, Parse);
        }
    }
}
```
```

```cs
public class HelloScraper : WebScraper
{
        /// <summary>
        /// Initialize the webscraper by overriding this method.
        /// Essential tasks include requesting a start URL and defining acceptable or restricted URL patterns.
        /// </summary>
        public override void Init()
        {
            License.LicenseKey = "YourLicenseKeyHere"; // Set your license key
            this.LoggingLevel = WebScraper.LogLevel.All; // Enable logging for all events
            this.Request("https://blog.scrapinghub.com", Parse); // Initial URL to scrape
        }

        /// <summary>
        /// This method is the default handler for processing web responses.
        /// Override this to handle different types of web pages or add more specific methods for variant pages.
        /// </summary>
        /// <param name="response">The HTTP response to be processed</param>
        public override void Parse(Response response)
        {
            // Set the directory where the scraping results are stored
            this.WorkingDirectory = AppSetting.GetAppRoot() + @"\HelloScraperSample\Output\";
            // Process each link found
            foreach (var titleLink in response.Css("h2.entry-title a"))
            {
                // Extract the clean text from the link
                string titleText = titleLink.TextContentClean;
                // Store the scraped data into a JSON file
                Scrape(new ScrapedData() { { "Title", titleText } }, "HelloScraper.json");
            }
            // Check if there are more pages to scrape
            if (response.CssExists("div.prev-post > a [href]"))
            {
                // Extract the URL for the next page
                var nextPageLink = response.Css("div.prev-post > a [href]")[0].Attributes["href"];
                // Continue scraping the next page
                this.Request(nextPageLink, Parse);
            }
        }
}
```

This section of code presents a basic structure for initializing and handling parsing operations in a web scraping scenario using the `HelloScraper` class. It sets up the initial conditions for the web scraper, including license key, logging level, and starting URL. The `Parse` method is structured to recursively handle paging, allowing the scraper to process subsequent pages through URL links identified in the scraped content.

```cs
static void Main(string[] args)
{
    // Instantiate the HelloScraper from the HelloScraperSample namespace
    HelloScraperSample.HelloScraper scraperInstance = new HelloScraperSample.HelloScraper();
    // Initiate the scraping process
    scraperInstance.Start();
}
```

Here's your paraphrased section with URLs resolved:

```cs
static void Main(string[] args)
{
    // Instantiate the Hello Scraper class
    HelloScraperSample.HelloScraper scraper = new HelloScraperSample.HelloScraper();
    // Begin the web scraping process
    scraper.Start();
}
```

5. The outcome is stored in a file following the format `WebScraper.WorkingDirectory/classname.json`.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/HelloScraperFrmFileResult.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/HelloScraperFrmFileResult.jpg" class="img-responsive add-shadow img-margin"></a></p>

### Overview of Code Implementation

Here's how the `Scrape.Start()` method initiates the scraping process:

1. It first executes the `Init()` method, which sets up variables, defines scraper properties, and establishes behavior attributes, preparing everything before any actual scraping begins.

2. The initial webpage to visit is set up through a call to `Request("https://blog.scrapinghub.com", Parse)`. Here, `Parse` is a delegate that processes the HTTP response received from the request.

3. The scraper operates with threads and HTTP protocols concurrently. This approach ensures all parts of your code remain both debuggable and execute in sync.

4. Following the setup in the `Init()` function, the `Parse` method is triggered to analyze and extract data from the fetched webpage.

<ol type="a">
    <li><p>You can find elements using (Css selectors, Js DOM, XPath)</p></li>
    <li><p>Selected elements are casted to the type ScrapedData Class, you can cast them to any custom Class Like (Product, Employee, News, etc.)</p></li>
    <li><p>The objects saved in a file with Json Format in the (“bin/Scrape/”) Directory. Or you can set the path of the file as a parameter as we will see later in other examples.</p></li>
</ol>

## Functions and Options of the IronWebScraper Library

For the most recent documentation, you have two options. For those installing manually, you can refer to the "IronWebScraper Documentation.chm" file located inside the downloaded zip file. Alternatively, the most up-to-date online documentation can be accessed at [https://ironsoftware.com/csharp/webscraper/object-reference/](https://ironsoftware.com/csharp/webscraper/object-reference/).

To effectively use the IronWebScraper in your projects, it's essential that your class inherits from the `IronWebScraper.WebScraper` class. This approach not only extends your class library but also integrates comprehensive scraping functionality.

Furthermore, it's imperative to implement the methods `Init()` and `Parse(Response response)`, which are crucial for setting up and dictating the behavior of your scraper.

```cs
namespace IronWebScraperEngine
{
    public class NewsScraper : IronWebScraper.WebScraper
    {
        public override void Init()
        {
            throw new NotImplementedException("Initialization method not implemented.");
        }

        public override void Parse(Response response)
        {
            throw new NotImplementedException("Parse method not implemented.");
        }
    }
}
```

<div class="content-table webscraping-in-c-sharp">
<table>
    <tbody>
        <tr class="tr-head">
            <th class="tcol1">Properties \ functions</th>
            <th class="tcol2">Type</th>
            <th class="tcol3">Description</th>
        </tr>
        <tr>
            <td>Init ()</td>
            <td>Method</td>
            <td>used to setup the scraper</td>
        </tr>
        <tr>
            <td>Parse (Response response)</td>
            <td>Method</td>
            <td>Used to implement the logic that the scraper will use and how it will process it.<br>Coming table contain list of methods and properties that IronWebScraper Library are providing<br>NOTE : Can implement multiple method for different pages behaviors or structures </td>
        </tr>
        <tr>
            <td>
                <ul>
                    <li>BannedUrls</li>
                    <li>AllowedUrls</li>
                    <li>BannedDomains</li>
                </ul>
            </td>
            <td>Collections</td>

<td>Enables restrictions or permissions on specific URLs and Domains. For instance, BannedUrls.Add("*.zip", "*.exe", "*.gz", "*.pdf");<br>Note:

<ul>
                    <li>You can use ( * and/or ? ) wildcards</li>
                    <li>You can use strings and regular expressions</li>
                    <li>BannedUrls, AllowedUrls, BannedDomains, AllowedDomains</li>
                    <li>BannedUrls.Add ("*.zip", "*.exe", "*.gz", "*.pdf");</li>
                    <li>*? glob sale wildcards</li>
                    <li>strings and regular expressions</li>
                    <li>you can override this behavior by overriding the method:  public virtual bool AcceptUrl (string url)</li>
                </ul>
            </td>
        </tr>
        <tr>
            <td>ObeyRobotsDotTxt</td>
            <td>Boolean</td>
            <td>Used to enable or disable read and follow robots.txt its directive or not</td>
        </tr>
        <tr>
            <td>public override bool ObeyRobotsDotTxtForHost (string Host)</td>
            <td>Method</td>
            <td>Used to enable or disable read and follow robots.txt its directive or not for certain domain</td>
        </tr>
        <tr>
            <td>Scrape</td>
            <td>Method</td>
            <td></td>
        </tr>
        <tr>
            <td>ScrapeUnique</td>
            <td>Method</td>
            <td></td>
        </tr>
        <tr>
            <td>ThrottleMode</td>
            <td>Enumeration</td>
            <td></td>
        </tr>
        <tr>
            <td>EnableWebCache ()</td>
            <td>Method</td>
            <td></td>
        </tr>
        <tr>
            <td>EnableWebCache (TimeSpan cacheDuration)</td>
            <td>Method</td>
            <td></td>
        </tr>
        <tr>
            <td>MaxHttpConnectionLimit</td>
            <td>Int</td>
            <td></td>
        </tr>
        <tr>
            <td>RateLimitPerHost</td>
            <td>TimeSpan</td>
            <td></td>
        </tr>
        <tr>
            <td>OpenConnectionLimitPerHost</td>
            <td>Int</td>
            <td></td>
        </tr>
        <tr>
            <td>ObeyRobotsDotTxt</td>
            <td>Boolean</td>
            <td></td>
        </tr>
        <tr>
            <td>ThrottleMode</td>
            <td>Enum</td>

<td>Enumeration Choices:
- ByIpAddress
- ByDomainHostName</td>

<ul>
                    <li>ByIpAddress</li>
                    <li>ByDomainHostName</li>
                </ul>
            </td>
        </tr>
        <tr>
            <td>SetSiteSpecificCrawlRateLimit (string hostName, TimeSpan crawlRate)</td>
            <td>Method</td>
            <td></td>
        </tr>
        <tr>
            <td>Identities</td>
            <td>Collections</td>
            <td>A list of HttpIdentity () to be used to fetch web resources.<br><br>Each Identity may have a different proxy IP addresses, user Agent, http headers, Persistent cookies, username and password.<br>Best practice is to create Identities in your WebScraper.Init Method and Add Them to this WebScraper.Identities List.</td>
        </tr>
        <tr>
            <td>WorkingDirectory</td>
            <td>string</td>
            <td>Setting working directory that will be used for all scrape related data will be stored to disk.</td>
        </tr>
    </tbody>
</table>
</div>

</br>

## Practical Examples and Applications

This section will delve into practical scenarios where IronWebScraper can be employed to extract data from real websites effectively. Through these examples, we aim to demonstrate the versatility and robustness of the IronWebScraper library.

### Scraping a Movie Database Website

For our first example, we will extract data from a movie database website.

Here's how to set up the project:

- Begin by adding a new class named `MovieScraper`.
- Examine the main website that we will be scraping:
  
![123movies Homepage](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/123movies.jpg)

Consider the initial HTML segment from the website's homepage:
```html
<div id="movie-featured" class="movies-list movies-list-full tab-pane in fade active">
    ...
</div>
```
Here, you can notice each movie has a unique ID, title, and details page link.

**Now, let's initiate scraping:**
```csharp
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "YourLicenseKeyHere";
        this.LoggingLevel = LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("http://www.example.com", Parse);
    }

    public override void Parse(Response response)
    {
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.Attributes["class"] != "clearfix")
            {
                var movie = new Movie
                {
                    Id = Convert.ToInt32(div.GetAttribute("data-movie-id")),
                    Title = div.Css("a")[0].TextContentClean,
                    URL = div.Css("a")[0].Attributes["href"]
                };
                this.Request(movie.URL, ParseDetails, new MetaData { { "movie", movie } });
            }
        }
    }

    public void ParseDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("movie");
        var div = response.Css("div.mvic-desc")[0];
        movie.Description = div.Css("div.desc")[0].TextContentClean;
        movie.Genre = div.Css("div > p > a").Select(a => a.TextContentClean).ToList();
        movie.Actor = div.Css("div > p:nth-child(2) > a").Select(a => a.TextContentClean).ToList();
        Scrape(movie, "Movie.Jsonl");
    }
}
```

*Improvements and Enhancements:*
1. Extended parsing to detail pages for comprehensive data capture.
2. Utilized IronWebScraper's `MetaData` to pass complex objects during recursive requests.
3. Stored results in JSONL format for easier processing and analysis.

The resulting data capture and structure from a movie's detailed page is displayed here:

![Movie Details Scraping Result](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass1.jpg)

### Extracting Data from an E-commerce Shopping Website

Next, we explore scraping a shopping website, focusing on gleaning product details across different categories.

- First, ascertain the HTML structure for links to product categories. Consider how the site's left sidebar organizes categories and subcategories.

Here's how we could approach this:

1. Establish a new `ShoppingSiteSample` project inside Visual Studio.
2. Create a new `ShoppingScraper` class.

**Building the scraper logic:**
```csharp
public class ShoppingScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "YourLicenseKeyHere";
        this.LoggingLevel = LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
        this.Request("http://www.example.com", Parse);
    }

    public override void Parse(Response response)
    {
        ...
        // Detailed scraping logic here
        ...
    }
}
```

- Extract category and subcategory links.
- Dive into each product page to fetch details, such as price, descriptions, and images.

Each of these real-world examples demonstrates the scalable capabilities of IronWebScraper to navigate and extract coherent datasets from complex web pages, serving various data mining and information retrieval needs effectively.

### Extracting Data from an Online Movie Portal

In this example, we are going to tackle scraping a real-world website specifically focusing on a movie-themed site.

First, we’ll begin by creating a new class. Let's call it `MovieScraper`: 

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

Examine the website we plan to scrape:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/123movies.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/123movies.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here’s a snippet from its homepage HTML:
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
        <a href="https://website.com/film/snatched-20724/" >
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
As observed, each movie entry contains a movie ID, Title, and a link to its detailed page.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/123movies.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/123movies.jpg" class="img-responsive add-shadow img-margin"></a></p>

Below is the section of the homepage HTML for the website described:

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
        <a href="https://website.com/film/snatched-20724/" >
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

In this webpage section, a list of movies is presented. Each movie entry includes a unique movie ID, a thumbnail image representing the movie, and the movie's title. When a user clicks on an entry, they are directed to a URL providing more details about the movie. The images are loaded lazily to improve page load performance, contributing to a better user experience.

Here's the paraphrased section with resolved URL paths:

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
        <a href="https://website.com/film/snatched-20724/" >
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

This section has been carefully rephrased while preserving the content's integrity and formatting. All URLs remain directed to their respective website, ensuring accurate referential integrity. If needed, modify any URLs to point to specific domains if provided or allowed.

Here's the paraphrased content for the specified section:

-----
As observed, the displayed HTML structure provides attributes such as a movie ID, a title, and a URL leading to a detailed movie page.

We shall now proceed with extracting these details:

```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "YourLicenseKeyHere"; // Place your license key
        this.LoggingLevel = WebScraper.LogLevel.All; // Set log level to capture all events
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\"; // Define the output directory for data
        this.Request("www.website.com", Parse); // Initial request to target website
    }
    public override void Parse(Response response)
    {
        // Iterate over each division that features a movie on the page
        foreach (var div in response.Css("#movie-featured > div"))
        {
            // Ensure we skip the clearfix class elements
            if (div.Attributes["class"] != "clearfix")
            {
                var movieId = div.GetAttribute("data-movie-id");
                var linkElement = div.Css("a")[0];
                var movieTitle = linkElement.TextContentClean;
                // Store the movie ID and title in our output file
                Scrape(new ScrapedData() { { "MovieId", movieId }, { "MovieTitle", movieTitle } }, "Movie.Jsonl");
            }
        }
    }
}
```

*Adjustments and Enhancements in the Code:*

In the updated code, the property `WorkingDirectory` is employed to specify the principal directory wherein all data related to scraping operations will be stored.

*Expanding the Capabilities:*

How about constructing robust typed objects that can effectively encapsulate our scraped data?

We'll introduce a dedicated movie class designed to manage and format the scraped movie data effectively. Here’s how it's structured:

Here's the paraphrased section of the article, with the relative URL paths resolved to `ironsoftware.com`:

```cs
public class Film
{
    public int Identifier { get; set; }
    public string Name { get; set; }
    public string Link { get; set; }
}
```

Let's refine our existing code with these updates:

```cs
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
        foreach (var Divs in response.Css("#movie-featured > div"))
        {
            if (Divs.Attributes ["class"] != "clearfix")
            {
                var movie = new Movie();
                movie.Id = Convert.ToInt32( Divs.GetAttribute("data-movie-id"));
                var link = Divs.Css("a")[0];
                movie.Title = link.TextContentClean;
                movie.URL = link.Attributes ["href"];
                this.Request(movie.URL, ParseDetails, new MetaData() { { "movie", movie } }); // Requesting the detailed page while passing current movie object
            }
        }           
    }
    public void ParseDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("movie");
        var Div = response.Css("div.mvic-desc")[0];
        movie.Description = Div.Css("div.desc")[0].TextContentClean;
        // Collecting genres
        movie.Genre = Div.Css("div.mvic-info div.mvici-left p:nth-child(1) a").Select(a => a.TextContentClean).ToList();
        // Collecting actors
        movie.Actor = Div.Css("div.mvic-info div.mvici-left p:nth-child(2) a").Select(a => a.TextContentClean).ToList();
        Scrape(movie, "Movie.Jsonl"); // Saving the detailed movie data
    }
}
```

**Key Enhancements Made:**
1. **Systematic Data Scraping for Details:** We added generous selectors that simplify managing HTML structures and collect genres and actors more efficiently.
2. **Streamlined Data Assignment:** Enhanced C# LINQ operations provide a more streamlined approach to assign genre and actor lists.
3. **Direct Metadata Utilization:** The code now directly accesses movies stored in metadata for detail page evaluations, ensuring that captured data remains robust and firmly structured.

```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "LicenseKey"; // specify the license key
        this.LoggingLevel = WebScraper.LogLevel.All; // set log level to capture all events
        // Define the directory where the scraped data will be stored
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        // Request the main page to start scraping
        this.Request("https://website.com/", Parse);
    }
    public override void Parse(Response response)
    {
        // Iterating over div elements within the container with movies
        foreach (var div in response.Css("#movie-featured > div"))
        {
            // Filtering out unwanted divs
            if (div.Attributes ["class"] != "clearfix")
            {
                var movie = new Movie(); // Creating a new movie object
                // Parsing and storing the movie ID
                movie.Id = Convert.ToInt32( div.GetAttribute("data-movie-id"));
               // Get the first anchor element within the div
                var link = div.Css("a")[0];
                movie.Title = link.TextContentClean; // store the clean text content as the movie title
                movie.URL = link.Attributes ["href"]; // fetch and store the URL from href attribute
                // Save the scraped movie data to a JSON line file
                Scrape(movie, "Movie.Jsonl");
            }
        }
    }
}
```

**Updates Introduced:**

1. A new `Movie` class has been implemented to encapsulate the scraped data effectively.

2. Movie instances are now passed to the `Scrape` method, which recognizes the structure and correctly saves the data as depicted here:
![Scraped Data Format](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass.jpg)

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's the paraphrased section, with resolved relative URL links directed to `ironsoftware.com`:

-----

## Detailed Page Scraping Example

Next, we venture into scraping content from a more intricate web page.

### Look at a Movie Detail Web Page 

Below is the layout of a typical movie detail page that we will be working with:

![Movie Details Webpage](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/movieDetailsSample.jpg)

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/movieDetailsSample.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/movieDetailsSample.jpg" class="img-responsive add-shadow img-margin"></a></p>

```html
<div class="movie-details">
    <div class="movie-thumbnail" style="background-image: url(https://img.gocdn.online/2017/04/28/poster/5a08e94ba02118f22dc30f298c603210-guardians-of-the-galaxy-vol-2.jpg);"></div>
    <div class="movie-description">
        <h3>Guardians of the Galaxy Vol. 2</h3>
        <div class="summary">
            Against the sonic backdrop of Awesome Mixtape #2, Marvel's Guardians of the Galaxy Vol. 2 unfolds the team's escapades across the universe as they aid Peter Quill in uncovering his lineage.
        </div>
        <div class="movie-meta">
            <div class="meta-left">
                <p>
                    <strong>Genre: </strong>
                    <a href="https://Domain/genre/action/" title="Action">Action</a>,
                    <a href="https://Domain/genre/adventure/" title="Adventure">Adventure</a>,
                    <a href="https://Domain/genre/sci-fi/" title="Sci-Fi">Sci-Fi</a>
                </p>
                <p>
                    <strong>Cast: </strong>
                    <a target="_blank" href="https://Domain/actor/chris-pratt" title="Chris Pratt">Chris Pratt</a>,
                    <a target="_blank" href="https://Domain/actor/-zoe-saldana" title="Zoe Saldana">Zoe Saldana</a>,
                    <a target="_blank" href="https://Domain/actor/-dave-bautista-" title="Dave Bautista">Dave Bautista</a>
                </p>
                <p>
                    <strong>Directed by: </strong>
                    <a href="#" title="James Gunn">James Gunn</a>
                </p>
                <p>
                    <strong>Produced in: </strong>
                    <a href="https://Domain/country/us" title="United States">United States</a>
                </p>
            </div>
            <div class="meta-right">
                <p><strong>Runtime:</strong> 136 min</p>
                <p><strong>Resolution:</strong> <span class="quality">CAM</span></p>
                <p><strong>Year:</strong> 2017</p>
                <p><strong>IMDb Rating:</strong> 8.3</p>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="clearfix"></div>
    </div>
    <div class="clearfix"></div>
</div>
```

We have the option to enhance our `Movie` class by adding additional properties such as `Description`, `Genre`, `Actor`, `Director`, `Country`, `Duration`, and `IMDB Score`. However, for this demonstration, we'll only utilize the `Description`, `Genre`, and `Actor` properties.

Here's the paraphrased section of your article, including resolved relative URL paths:

```cs
public class Film
{
    public int MovieId { get; set; }
    public string MovieTitle { get; set; }
    public string MovieURL { get; set; }
    public string Summary { get; set; }
    public List<string> Categories { get; set; }
    public List<string> Cast { get; set; }
}
```

Now let's move on to scraping the detailed pages.

With IronWebScraper, you have the flexibility to extend the scraping functions to handle a variety of page layouts and formats.

Here’s an example:

```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "YourLicenseKeyHere";
        this.LoggingLevel = WebScraper.LogLevel.All; // Log every event
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\"; // Set the output directory
        this.Request("https://example.com", Parse); // Initial page to start scraping
    }

    public override void Parse(Response response)
    {
        foreach (var container in response.Css("#movie-featured > div"))
        {
            if (container.Attributes["class"] != "clearfix")
            {
                var movie = new Movie();
                movie.Id = Convert.ToInt32(container.GetAttribute("data-movie-id")); // Extract movie ID
                var anchor = container.Css("a")[0];
                movie.Title = anchor.TextContentClean; // Clean up and set the title
                movie.URL = anchor.Attributes["href"]; // Set URL for details page
                this.Request(movie.URL, ParseDetails, new MetaData() { { "movie", movie } }); // Pass movie object to detail parsing
            }
        }
    }

    public void ParseDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("movie"); // Retrieve the movie object
        var descContainer = response.Css("div.mvic-desc")[0];
        movie.Description = descContainer.Css("div.desc")[0].TextContentClean; // Parse and set the movie description
        
        movie.Genre = new List<string>(); // Initialize the list of genres
        foreach (var genreElement in descContainer.Css("div > p > a"))
        {
            movie.Genre.Add(genreElement.TextContentClean); // Add each genre to the list
        }

        movie.Actor = new List<string>(); // Initialize the list of actors
        foreach (var actorElement in descContainer.Css("div > p:nth-child(2) > a"))
        {
            movie.Actor.Add(actorElement.TextContentClean); // Add each actor to the list
        }

        Scrape(movie, "Movie.Jsonl"); // Finally, save the scraped data to a JSONL file
    }
}
```

### Key Enhancements in Scraping Workflow

1. Introduction of specialized scraping functions (`ParseDetails`) for efficiently processing detailed web pages.
   
2. Transition of the `Scrape` function: this core function has been reallocated to operate within the newly introduced `ParseDetails` function for optimized data handling.

3. Integration of IronWebScraper's `MetaData` utility, enabling the seamless transfer of movie data objects between different scraping functions.

4. Implementation of a complete scraping process where the extracted movie data is stored directly into a dedicated file, ensuring data persistence and accessibility.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass1.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass1.jpg" class="img-responsive add-shadow img-margin"></a></p>

### Extracting Data from a Retail Website

We've chosen a retail website as our target for data extraction.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg" class="img-responsive add-shadow img-margin"></a></p>

As demonstrated in the image, there is a sidebar listing the product categories of the website.

The initial step involves examining the website's HTML structure to strategize our web scraping approach.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg" class="img-responsive add-shadow img-margin"></a></p>

The fashion website organizes its products into main categories which include subcategories such as Men, Women, and Kids.

```html
<li class="menu-item">
    <a href="https://ironsoftware.com/fashion-by/" class="main-category">
        <i class="cat-icon osh-font-fashion"></i> <span class="nav-subTxt">FASHION </span> <i class="osh-font-light-arrow-left"></i><i class="osh-font-light-arrow-right"></i>
    </a>
    <div class="navLayerWrapper" style="width: 633px; display: none;">
        <div class="submenu">
            <div class="column">
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/fashion-by/?sort=newest&amp;dir=desc&amp;viewType=gridView3">New Arrivals</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/men-fashion/">Men</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-shoes/">Shoes</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-clothing/">Clothing</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-accessories/">Accessories</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/women-fashion/">Women</a>
                    <a class="subcategory" href="https://ironsoftware.com/womens-shoes/">Shoes</a>
                    <a class="subcategory" href="https://ironsoftware.com/womens-clothing/">Clothing</a>
                    <a class="subcategory" href="https://ironsoftware.com/womens-accessories/">Accessories</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/girls-boys-fashion/">Kids</a>
                    <a class="subcategory" href="https://ironsoftware.com/boys-fashion/">Boys</a>
                    <a class="subcategory" href="https://ironsoftware.com/girls/">Girls</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/maternity-clothes/">Maternity Clothes</a>
                </div>
            </div>
            <div class="column">
                <div class="categories">
                    <span class="category defaultCursor">Men Best Sellers</span>
                    <a class="subcategory" href="https://ironsoftware.com/mens-casual-shoes/">Casual Shoes</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-sneakers/">Sneakers</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-t-shirts/">T-shirts</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-polos/">Polos</a>
                </div>
                <div class="categories">
                    <span class="category defaultCursor">Women Best Sellers</span>
                    <a class="subcategory" href="https://ironsoftware.com/womens-sandals/">Sandals</a>
                    <a class="subcategory" href="https://ironsoftware.com/womens-sneakers/">Sneakers</a>
                    <a class="subcategory" href="https://ironsoftware.com/women-dresses/">Dresses</a>
                    <a class="subcategory" href="https://ironsoftware.com/women-tops/">Tops</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/womens-curvy-clothing/">Women's Curvy Clothing</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/fashion-bundles/v/">Fashion Bundles</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/hijab-fashion/">Hijab Fashion</a>
                </div>
            </div>
            <div class="column">
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/brands/fashion-by/">SEE ALL BRANDS</a>
                    <a class="subcategory" href="https://ironsoftware.com/adidas/">Adidas</a>
                    <a class="subcategory" href="https://ironsoftware.com/converse/">Converse</a>
                    <a class="subcategory" href="https://ironsoftware.com/ravin/">Ravin</a>
                    <a class="subcategory" href="https://ironsoftware.com/dejavu/">Dejavu</a>
                    <a class="subcategory" href="https://ironsoftware.com/agu/">Agu</a>
                    <a class="subcategory" href="https://ironsoftware.com/activ/">Activ</a>
                    <a class="subcategory" href="https://ironsoftware.com/oxford--bellini--tie-house--milano/">Tie House</a>
                    <a class="subcategory" href="https://ironsoftware.com/shoe-room/">Shoe Room</a>
                    <a class="subcategory" href="https://ironsoftware.com/town-team/">Town Team</a>
                </div>
            </div>
        </div>
    </div>
</li>
```

```
# Setting Up Your Project

***Based on <https://ironsoftware.com/tutorials/webscraping-in-c-sharp/>***


To embark on a new scraping project, proceed with the following steps:

1. Begin by creating a new Console Application or simply add a new folder to your existing solution. Name this folder "ShoppingSiteSample" to differentiate it from other areas of your project.

2. Within this new folder or application, introduce a new class called `ShoppingScraper`. This class will handle the primary tasks of your webscraper application.

3. Start off by configuring your scraper to fetch categories and subcategories from the target website.

Now, let's define a model to hold these categories:

## Defining a Model for Categories

To effectively manage the data you scrape, define a category model as follows:

```cs
public class Category
{
    /// <summary>
    /// Represents the category name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Holds the URL to the category.
    /// </summary>
    public string URL { get; set; }

    /// <summary>
    /// Contains a list of subcategories within this category.
    /// </summary>
    public List<Category> SubCategories { get; set; }
}
```

This model offers a structured way to capture and utilize category data within your webscraping application.
```

```cs
public class Category
{
    /// <summary>
    /// Maintains or adjusts the category name.
    /// </summary>
    /// <value>
    /// Represents the category name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Maintains or adjusts the web address.
    /// </summary>
    /// <value>
    /// The web address associated with the category.
    /// </value>
    public string URL { get; set; }

    /// <summary>
    /// Maintains or adjusts the list of subcategories within this category.
    /// </summary>
    /// <value>
    /// A list containing subcategories of this category.
    /// </value>
    public List<Category> SubCategories { get; set; }
}
```

Here's the rewritten section with relative URL paths resolved to `ironsoftware.com`:

-----

4. Building Our Scrape Logic

Next, we develop the scraping strategy. Given below are the structured steps for setting this up:

```cs
public class ShoppingScraper : WebScraper
{
    /// <summary>
    /// Starts the web scraper by setting initialization parameters.
    /// This function is crucial for defining the initial URL and domain rules.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
        this.Request("www.webSite.com", Parse);
    }

    /// <summary>
    /// Default handler for parsing HTTP responses.
    /// You can implement additional handlers for different page types if needed.
    /// </summary>
    /// <param name="response">HTTP response to be parsed.</param>
    public override void Parse(Response response)
    {
        var categoryList = new List<Category>();
        
        foreach (var Links in response.Css("#menuFixed > ul > li > a "))
        {
            var cat = new Category();
            cat.URL = Links.Attributes ["href"];
            cat.Name = Links.InnerText;
            categoryList.Add(cat);
        }
        Scrape(categoryList, "Shopping.Jsonl");
    }
}
```

By leveraging these code examples, developers can effectively extract data from the chosen categories within a shopping site, organizing the information collected into a structured format (JSON Lines) and saving them into designated output directories for further analysis or use.

```cs
public class ShoppingScraper : WebScraper
{
    /// <summary>
    /// This method sets up the initial configuration for your web scraper.
    /// Essentials include specifying a starting URL and defining rules for allowed or banned domains and URL patterns.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
        this.Request("www.webSite.com", Parse);
    }

    /// <summary>
    /// This method is responsible for handling the HTTP responses for your web scraper.
    /// It serves as the primary method for processing web content, and you can define additional methods for different types of web pages.
    /// </summary>
    /// <param name="response">The HTTP response object that will be processed</param>
    public override void Parse(Response response)
    {
        var categories = new List<Category>();

        foreach (var link in response.Css("#menuFixed > ul > li > a "))
        {
            var category = new Category
            {
                URL = link.Attributes["href"],
                Name = link.InnerText
            };
            categories.Add(category);
        }
        Scrape(categories, "Shopping.Jsonl");
    }
}
```

In this section, we'll extract links from the site's navigation menu. The process involves identifying the HTML structure of the menu and programmatically pulling out links that correspond to different categories or pages.

Here’s the revised scraping process focused on pulling menu links:

```cs
public override void Parse(Response response)
{
    // Initialize a list to store categories with their respective links
    var categoryList = new List<Category>();
    
    // Loop over each menu item in the navigation bar
    foreach (var li in response.Css("#menuFixed > ul > li"))
    {
        // Extract the main links for each menu item
        foreach (var Links in li.Css("a"))
        {
            var cat = new Category();
            cat.URL = Links.Attributes ["href"];
            cat.Name = Links.InnerText;
            cat.SubCategories = new List<Category>();

            // Extract subcategories for each main category
            foreach (var subCategory in li.Css("a[class=subcategory]"))
            {
                var subcat = new Category();
                subcat.URL = Links.Attributes ["href"];
                subcat.Name = Links.InnerText;

                // Prevent duplicate entries
                if (cat.SubCategories.Find(c => c.Name == subcat.Name && c.URL == subcat.URL) == null)
                {
                    cat.SubCategories.Add(subcat);
                }
            }
            // Add the main category to the list
            categoryList.Add(cat);
        }
    }
    Scrape(categoryList, "Shopping.Jsonl");
}
```

This part of the tutorial aims to demonstrate methodical navigation through nested elements in a webpage's structure to effectively extract data. This approach not only simplifies categorization but ensures that each category and its subcategories are accurately represented.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's the paraphrased section of the article:

---
To enhance our scraping process, we need to adjust our code to gather not only the primary categories but also their subcategories from the website. Let's look at how we can refine our code to efficiently capture both the main category links and their respective sub-links:

```csharp
public override void Parse(Response response)
{
    // Compilation of the primary category links
    var categoryList = new List<Category>();
    
    // Iterate through each main category listing
    foreach (var li in response.Css("#menuFixed > ul > li"))
    {
        // Processing main links
        foreach (var Links in li.Css("a"))
        {
            var cat = new Category();
            cat.URL = Links.Attributes ["href"];
            cat.Name = Links.InnerText;
            cat.SubCategories = new List<Category>();
            
            // Compilation of subcategory links
            foreach (var subCategory in li.Css("a [class=subcategory]"))
            {
                var subcat = new Category();
                subcat.URL = Links.Attributes ["href"];
                subcat.Name = Links.InnerText;
                
                // Ensure unique subcategory links are added
                if (!cat.SubCategories.Any(c=>c.Name== subcat.Name && c.URL == subcat.URL))
                {
                    cat.SubCategories.Add(subcat);
                }
            }
            
            // Adding to the primary category list
            categoryList.Add(cat);
        }
    }
    Scrape(categoryList, "Shopping.Jsonl");
}
```

This updated approach ensures that each main category and its corresponding subcategories are thoroughly scraped and cataloged, providing a structured and detailed overview of the site navigational schema.

Here is the paraphrased section of the article with resolved URLs:

```cs
public override void Parse(Response response)
{
    // Initializing main category list
    var mainCategories = new List<Category>();

    // Iterate through each list item found under the specified id
    foreach (var listItem in response.Css("#menuFixed > ul > li"))
    {
        // Traverse through each anchor link within the list item
        foreach (var anchorLink in listItem.Css("a"))
        {
            var category = new Category
            {
                URL = anchorLink.Attributes["href"], // Fetching URL from anchor tag
                Name = anchorLink.InnerText, // Fetching the category name
                SubCategories = new List<Category>() // Initializing the subcategories list
            };

            // Extract subcategories from the specified class within the anchor tag
            foreach (var subCat in listItem.Css("a[class=subcategory]"))
            {
                var subCategory = new Category
                {
                    URL = anchorLink.Attributes["href"], // Fetching URL from subcategory anchor tag
                    Name = anchorLink.InnerText // Fetching the subcategory name
                };

                // Ensuring unique subcategory entries only
                if (!category.SubCategories.Any(c => c.Name == subCategory.Name && c.URL == subCategory.URL))
                {
                    category.SubCategories.Add(subCategory); // Adding to subcategories list
                }
            }

            mainCategories.Add(category); // Add the filled category to the main categories list
        }
    }

    Scrape(mainCategories, "Shopping.Jsonl"); // Storing the result as a JSON lines file
}
```

With all site category links at our disposal, let's proceed with extracting the product details from each category.

Next, we will explore a specific category to analyze its contents.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" class="img-responsive add-shadow img-margin"></a></p>

Certainly! Here's the paraphrased content for the provided section, with image and link paths resolved:

---

## Examining the Source Code

Here's a glimpse into the HTML structure of the content:

```html
<section class="products">
    <div class="sku -gallery -validate-size" data-sku="AG249FA0T2PSGNAFAMZ" ft-product-sizes="41,42,43,44,45" ft-product-color="Multicolour">
        <a class="link" href="https://ironsoftware.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Bundle Of 2 Sneakers - Black & Navy Blue" data-image-vertical="1" width="210" height="262" src="https://ironsoftware.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-sku="AG249FA0T2PSGNAFAMZ" data-src="https://ironsoftware.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg">
                <noscript>
                    <img src="https://ironsoftware.com/p/agu-6208-488356-1-catalog_grid_3.jpg" width="210" height="262" class="image" />
                </noscript>
            </div> 
            <h2 class="title">
                <span class="brand ">Agu&nbsp;</span>
                <span class="name" dir="ltr">Bundle Of 2 Sneakers - Black & Navy Blue</span>
            </h2>
            <div class="price-container clearfix">
                <span class="price-box">
                    <span class="price">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="299">299</span>
                    </span>   
                    <span class="price -old  -no-special"></span>
                </span>
            </div>
            <div class="rating-stars">
                <div class="stars-container">
                    <div class="stars" style="width: 62%"></div>
                </div> 
                <div class="total-ratings">(30)</div> 
            </div>    
            <span class="shop-first-logo-container">
                <img src="https://ironsoftware.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" data-src="https://ironsoftware.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" class="lazy shop-first-logo-img -mbxs -loaded"> 
            </span>
            <span class="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>
            <div class="list -sizes" data-selected-sku="">
                <span class="js-link sku-size" data-href="https://ironsoftware.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=41">41</span>     
                <span class="js-link sku-size" data-href="https://ironsoftware.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=42">42</span>
                <span class="js-link sku-size" data-href="https://ironsoftware.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=43">43</span>     
                <span class="js-link sku-size" data-href="https://ironsoftware.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=44">44</span>
                <span 

    the="js-link" sku-size="" data-href="https://ironsoftware.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=45">45</span>
            </div>
        </a>
    </div>
</section>
```
This code snippet showcases the HTML used for embedding product information on a webpage, including details such as product images, names, prices, and sizes.

```html
<section class="products">
    <div class="sku -gallery -validate-size" data-sku="AG249FA0T2PSGNAFAMZ" ft-product-sizes="41,42,43,44,45" ft-product-color="Multicolour">
        <a class="link" href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Bundle Of 2 Sneakers - Black & Navy Blue" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-sku="AG249FA0T2PSGNAFAMZ" data-src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg"><noscript><img src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
            </div>
            <h2 class="title">
                <span class="brand">Agu</span>
                <span class="name" dir="ltr">Bundle Of 2 Sneakers - Black & Navy Blue</span>
            </h2>
            <div class="price-container clearfix">
                <span class="price-box">
                    <span class="price">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="299">299</span>
                    </span>
                    <span class="price -old  -no-special"></span>
                </span>
            </div>
            <div class="rating-stars">
                <div class="stars-container">
                    <div class="stars" style="width: 62%"></div>
                </div>
                <div class="total-ratings">(30)</div>
            </div>
            <span class="shop-first-logo-container">
                <img src="http://www.WebSite.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" data-src="http://www.WebSite.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" class="lazy shop-first-logo-img -mbxs -loaded">
            </span>
            <span class="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>
            <div class="list -sizes" data-selected-sku="">
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=41">41</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=42">42</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=43">43</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=44">44</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=45">45</span>
            </div>
        </a>
    </div>
    <div class="sku -gallery -validate-size" data-sku="LE047FA01SRK4NAFAMZ" ft-product-sizes="110,115,120,125,130,135" ft-product-color="Black">
        <a class="link" href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Genuine Leather Belt - Black" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-sku="LE047FA01SRK4NAFAMZ" data-src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg"><noscript><img src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
            </div>
            <h2 class="title">
                <span class="brand">Leather Shop</span>
                <span class="name" dir="ltr">Genuine Leather Belt - Black</span>
            </h2>
            <div class="price-container clearfix">
                <span class="sale-flag-percent">-29%</span>
                <span class="price-box">
                    <span class="price">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="96">96</span>
                    </span>
                    <span class="price -old ">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="135">135</span>
                    </span>
                </span>
            </div>
            <div class="rating-stars">
                <div class="stars-container">
                    <div class="stars" style="width: 100%"></div>
                </div>
                <div class="total-ratings">(1)</div>
            </div>
            <span class="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>
            <div class="list -sizes" data-selected-sku="">
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=110">110</span>
                <span the "js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=115">115</span>
                <span the "js-link sku-size" data-href="http://www.Webist.com/leather-shop-genuine-leather-belt-black-712030.html?size=120">120</span>
                <span the "js-link sku-size" data-href="http://www.Webist.com/leather-shop-genuine-leather-belt-black-712030.html?size=125">125</span>
                <span the "js-link sku-size" data-href="http://www.Webiste.com/leather-shop-genuine-leather-belt-black-712030.html?size=130">130</span>
                <span the "js-link sku-size" data-href="http://www.Webiste.com/leather-shop-genuine-leather-belt-black-712030.html?size=135">135</span>
            </div>
        </a>
    </div>
</section>
```

Let's design a model to encapsulate the data for these products.

```cs
public class Product
{
    /// <summary>
    /// Retrieves or assigns the product name.
    /// </summary>
    /// <value>
    /// Name of the product.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Retrieves or assigns the product price.
    /// </summary>
    /// <value>
    /// Price of the product.
    /// </value>
    public string Price { get; set; }

    /// <summary>
    /// Retrieves or assigns the image URL of the product.
    /// </summary>
    /// <value>
    /// URL pointing to the product's image.
    /// </value>
    public string Image { get; set; }
}
```

To extract information from category pages, we implement an additional scraping method as follows:

```cs
public void ScrapeCategory(Response response)
{
    // Creating a container for the product information
    var products = new List<Product>();

    // Iterating through each product link found in the specified DOM path
    foreach (var link in response.Css("body > main > section.osh-content > section.products > div > a"))
    {
        var product = new Product
        {
            Name = link.TextContentClean, // Extracting the product name
            Image = link.Css("div.image-wrapper.default-state > img")[0].Attributes["src"] // Extracting the image source
        };
        
        // Adding the product details to our list
        products.Add(product);
    }

    // Saving the product list to a JSONL file
    Scrape(products, "Products.Jsonl");
}
```

### Enhanced Webscraping Capabilities

#### Using HttpIdentity for Custom Sessions:

Certain websites grant access to content only after user authentication. Utilizing the `HttpIdentity` component of IronWebScraper can help in such cases:

```cs
HttpIdentity identity = new HttpIdentity();
identity.NetworkUsername = "yourUsername";
identity.NetworkPassword = "yourPassword";
Identities.Add(identity);
```

IronWebScraper offers robust functionality by allowing thousands of distinct identities to simulate or scrape data across multiple user sessions and browser identities.

```cs
public override void Init()
{
    License.LicenseKey = "YourLicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    var proxies = "IP-Proxy1:8080,IP-Proxy2:8081".Split(',');
    foreach (var userAgent in IronWebScraper.CommonUserAgents.ChromeDesktopUserAgents)
    {
        foreach (var proxy in proxies)
        {
            Identities.Add(new HttpIdentity()
            {
                UserAgent = userAgent,
                UseCookies = true,
                Proxy = proxy
            });
        }
    }
    this.Request("http://www.example.com", Parse);
}
```

Manage your scraping session with diverse identity properties such as `NetworkUsername`, `NetworkPassword`, `Proxy`, `UserAgent`, `HttpRequestHeaders`, and cookie settings to navigate complex web security measures.

#### Caching with Enable Web Cache:

For workflow optimization, particularly during development and testing, you can cache scraped pages. This feature minimizes redundant server requests, allowing you to iterate rapidly without additional load times.

To enable caching:

```cs
public override void Init()
{
    License.LicenseKey = "YourLicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    EnableWebCache(new TimeSpan(1, 30, 30));
    this.Request("http://www.example.com", Parse);
}
```

IronWebScraper can persist your scraped data state. This is valuable during development or if you need to pause and resume scraping processes.

#### Throttle Settings:

You can fine-tune your scraping operations with throttle settings to manage connection limits and request intervals, ensuring compliance with website request policies and avoiding IP bans.

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    this.MaxHttpConnectionLimit = 80;
    this.RateLimitPerHost = TimeSpan.FromMilliseconds(50);
    this.OpenConnectionLimitPerHost = 25;
    this.ObeyRobotsDotTxt = false;
    this.ThrottleMode = Throttle.ByDomainHostName;
    this.Request("https://www.example.com", Parse);
}
```
Key throttle properties include `MaxHttpConnectionLimit`, `RateLimitPerHost`, and `OpenConnectionLimitPerHost`, each governing specific aspects of your connection strategy to optimally manage server load from your scraping activities.

#### Feature: HttpIdentity

Certain online platforms mandate user authentication to access their content. For such scenarios, the `HttpIdentity` feature of IronWebScraper is particularly useful. This feature allows the web scraper to simulate a logged-in user state, enabling access to restricted areas of websites that require authentication. Here's how you can utilize it:

```cs
HttpIdentity httpIdentity = new HttpIdentity();
httpIdentity.NetworkUsername = "your_username";
httpIdentity.NetworkPassword = "your_password";
Identities.Add(httpIdentity);
```

IronWebScraper's capability to manage multiple identities is among its most robust features. This allows the emulation of several user interactions or browser environments concurrently, facilitating comprehensive web scraping sessions that adhere to site-specific login requirements.

Below is the paraphrased version of the provided C# code section concerning `HttpIdentity`:

```cs
HttpIdentity identityConfig = new HttpIdentity();
identityConfig.NetworkUsername = "username";
identityConfig.NetworkPassword = "password";
Identities.Add(identityConfig);
```

One of the standout capabilities of IronWebScraper is its robust feature that supports the use of numerous unique identities, encompassing users' credentials or browser engines, to effectively cloak or retrieve data from websites through multiple login sessions. This scalability and versatility enhance the tool's efficacy in dealing with a variety of scraping scenarios.

Here's your paraphrased section with resolved relative URLs:

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey"; // Replace 'LicenseKey' with your actual license key
    this.LoggingLevel = WebScraper.LogLevel.All; // Set the logging level to record all events
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\"; // Define the working directory for output files

    // Split the proxy addresses and assign them to an array
    var proxyAddresses = "IP-Proxy1:8080,IP-Proxy2:8081".Split(',');

    // Loop through each user agent in the list of common Chrome desktop user agents
    foreach (var userAgent in IronWebScraper.CommonUserAgents.ChromeDesktopUserAgents)
    {
        // Assign each proxy to the current user agent
        foreach (var proxy in proxyAddresses)
        {
            Identities.Add(new HttpIdentity()
            {
                UserAgent = userAgent,        // Use the current Chrome user agent
                UseCookies = true,            // Enable cookie usage
                Proxy = proxy                 // Set the proxy
            });
        }
    }

    // Initiate the scraping process with the target URL
    this.Request("http://www.Website.com", Parse); // Change 'Website.com' to your actual target website
}
```

In this version:
- Improved the commenting for clarity.
- Explicitly set the `UseCookies` property to demonstrate boolean settings.
- Adjusted the proxy list for better readability and usability.
- Included direct instructions to replace placeholders with actual values.

IronWebScraper offers a variety of properties to configure different behavioral aspects of your web scraping tasks, which can help prevent your activities from being blocked by websites.

Here are some of these configurable properties:

- **NetworkDomain**: This is utilized for user authentication across diverse network types including Windows, NTLM, Kerberos, Linux, BSD, and Mac OS X. It should be used in conjunction with `NetworkUsername` and `NetworkPassword`.
- **NetworkUsername**: This is the username required for network or HTTP authentication, supporting various protocols and network types like HTTP, Windows networks, NTLM, Kerberos, Linux, BSD, and Mac OS.
- **NetworkPassword**: This corresponds to the password for network or HTTP authentication, and it is compatible with HTTP, Windows networks, NTLM, Kerberos, Linux, BSD, and Mac OS.
- **Proxy**: This property allows you to specify proxy settings to be used during scraping.
- **UserAgent**: This property lets you set the browser engine type - for example, Chrome (desktop, mobile, tablet), Internet Explorer, and Firefox.
- **HttpRequestHeaders**: This allows for the specification of custom header values using a dictionary object (`Dictionary<string, string>`).
- **UseCookies**: This can be toggled on or off to enable or disable the use of cookies during the scraping process.

IronWebScraper typically operates using a selection of random identities to manage diverse scraping tasks. If needed, you can specify the use of a particular identity to parse a specific page, enhancing the flexibility and control over your web scraping operations.

Here's a paraphrased version of the given C# code section:

```cs
public override void Init()
{
    // Setting the license key for the scraper
    License.LicenseKey = "YourLicenseKeyHere";
    // Configuring logging to capture all events
    this.LoggingLevel = WebScraper.LogLevel.All;
    // Defining the working directory for output files
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    // Creating a new HTTP identity for authenticated requests
    HttpIdentity myIdentity = new HttpIdentity();
    myIdentity.NetworkUsername = "yourUsername";
    myIdentity.NetworkPassword = "yourPassword";
    // Adding the identity to the scraper
    Identities.Add(myIdentity);
    // Initiating a web request with authentication
    this.Request("http://www.Website.com", Parse, myIdentity);
}
```

This version modifies variable names for clarity, rephrases comments for better understanding, and ensures that the identity instance is correctly referenced when being added to the `Identities` collection.

#### Web Cache Feature Utilization:

The Web Cache feature plays a crucial role by storing requested pages, primarily during the development and testing stages. This capability allows developers to cache essential pages for subsequent use once updates to the code have been made. As a result, developers can rerun their code on cached pages without having to make repeated requests to the actual live website, effectively enabling an action-replay function.

*To activate this feature in the Init() method, use:*

```cs
EnableWebCache();
```

*Alternatively, if you want the cache to expire after a specific duration, you can specify the expiration time:*

```cs
EnableWebCache(TimeSpan expiry);
```

This command directs IronWebScraper to store the cached data in the WebCache folder located within the designated working directory.

```cs
public override void Init()
{
    // Set the license key for usage
    License.LicenseKey = "LicenseKey";
    // Configure logging to capture all events
    this.LoggingLevel = WebScraper.LogLevel.All;
    // Define the directory to store output files
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    // Enable caching of web pages for 1 hour and 30 minutes
    EnableWebCache(new TimeSpan(1,30,30));
    // Initiate web scraping on the specified URL
    this.Request("http://www.WebSite.com", Parse);
}
```

IronWebScraper includes capabilities that facilitate the resumption of scraping activities even after a code restart by employing a specific method `Start(CrawlID)`. This function allows you to name the scraping process, aiding in the continuation from where it was interrupted.

Here's the paraphrased section of the article:

```cs
static void Main(string[] args)
{
    // Instantiate the scraper class
    EngineScraper scraper = new EngineScraper();
    // Initialize the scraping process
    scraper.Start("enginestate");
}
```

All execution requests and responses will be stored within the `SavedState` folder, located inside the working directory.

#### Throttling Techniques

By managing the connection counts and the speed per domain, we ensure efficient rate limiting. This approach helps in balancing both the minimum and maximum number of connections concurrently active, aiding in the smooth handling of data transmission speeds specific to each domain.

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey"; // Activate the license
    this.LoggingLevel = WebScraper.LogLevel.All; // Log all events
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\"; // Set the working directory
    
    // Configure the maximum number of simultaneous HTTP requests allowed
    this.MaxHttpConnectionLimit = 80;
    
    // Implement a minimal polite delay between requests to the same domain
    this.RateLimitPerHost = TimeSpan.FromMilliseconds(50);
    
    // Limit the concurrent requests per hostname to prevent overwhelming the server
    this.OpenConnectionLimitPerHost = 25;
    
    // Do not adhere to the directives specified in the robots.txt file
    this.ObeyRobotsDotTxt = false;
    
    // Intelligent throttling by domain or IP to avoid excessive load on servers hosting multiple domains
    this.ThrottleMode = Throttle.ByDomainHostName;

    // Initiate the scraping process by making a request to the specified URL
    this.Request("https://www.Website.com", Parse);
}
```

**Properties for Managing Throttling**

* **MaxHttpConnectionLimit**<br>The maximum number of simultaneous HTTP requests (threads) that can be active at any given time.

* **RateLimitPerHost**<br>This represents the smallest amount of time (in milliseconds) that the system should wait before making another request to the same domain or IP address, as a courtesy to avoid overwhelming the server.

* **OpenConnectionLimitPerHost**<br>This specifies the maximum number of concurrent HTTP requests (threads) that are allowed per host, helping manage the load on the servers being accessed.

* **ThrottleMode**<br>This feature configures the WebScraper to smartly regulate the request rate, not just by the domain name, but also considering the IP addresses of the host servers. This is especially useful when multiple target domains are located on the same physical server, thus ensuring polite and non-disruptive scraping activities.

## Additional Resources

Below, you’ll find some useful guidance on setting up new applications specific to your requirements using Visual Studio.

### Creating a Windows Forms Application

Visual Studio 2013 or later versions are recommended. Here's a step-by-step guide on how to get started:

1. **Initiate Visual Studio**.
    ![Open Visual Studio](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg)
   
2. **Create a new project**: Navigate through `File -> New -> Project`.
    ![Creating a new project](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg)

3. **Specify the project type**: Choose your preferred language (either Visual C# or VB), navigate through `Windows`, and select `Windows Forms Application`.
    ![Specifying the project type](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/CreateWindowsApp.jpg)

    **Project Name**: IronScraperSample <br>
    **Location**: Select where you want your project files to be saved.

    ![Windows Forms Main Interface](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/WindowsAppMainScreen.jpg) 

### Creating a Web Form Application

Use Visual Studio 2013 or above for these steps:

1. **Launch Visual Studio**.
    ![Start Visual Studio](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg)
   
2. **Start a new project**: Choose `File -> New -> Project`.
    ![Creating a project](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg)

3. **Set the project properties**: Under the templates, select your language (Visual C# or VB), go to `Web`, and then choose `ASP.NET Web Application (.NET Framework)`.
    ![Setting project properties](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETWebApplication.jpg)

    **Project Name**: IronScraperSample <br>
    **Location**: Decide on a storage location for your project files.

4. **Choose the right template**:
    - Select the `Empty` template.
    - Ensure the `Web Forms` checkbox is marked.

    ![Selecting ASP.NET Templates](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETTemplates.jpg)

5. **Complete and View Your Project**: The basic ASP.NET web form Project is now set up.
    ![Project initialization complete](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETWebFormProject.jpg)

To download all the examples from this guide as a fully packaged code project, [click here](https://ironsoftware.com/downloads/assets/tutorials/webscraping-in-c-sharp/IronWebScraperSample.zip).

### Creating a Windows Forms Application

For this task, it is recommended to use Visual Studio 2013 or a later version.

Here's a step-by-step guide on how to start a new Windows Forms Project:

1. Launch Visual Studio.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg" class="img-responsive add-shadow img-margin"></a></p>

2. Navigate to `File`, then select `New`, followed by `Project`.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg" class="img-responsive add-shadow img-margin"></a></p>

3. Select your preferred programming language (either Visual C# or VB) from the Template options, follow through by choosing 'Windows', and then opt for the 'Windows Forms Application'.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/CreateWindowsApp.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/CreateWindowsApp.jpg" class="img-responsive add-shadow img-margin"></a></p>

**Project Name**: IronScraperSample<br>
**Storage Location**: Select a directory on your hard drive where the project will be saved.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/WindowsAppMainScreen.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/WindowsAppMainScreen.jpg" class="img-responsive add-shadow img-margin"></a></p>

### Creating a Web Form Application with ASP.NET

For this task, it's necessary to use Visual Studio 2013 or a newer version.

Here's how you can start a new ASP.NET Web Forms Project:

1. Launch Visual Studio

Navigate through the process to set up a new ASP.NET Web Forms Project by following these detailed steps.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg" class="img-responsive add-shadow img-margin"></a></p>

2. Navigate to File -> Select New -> Click on Project
```

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg" class="img-responsive add-shadow img-margin"></a></p>

3. Within the Template section, select your preferred programming language (either Visual C# or VB), then choose Web, followed by selecting ASP.NET Web Application (.NET Framework).

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ASPNETWebApplication.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ASPNETWebApplication.jpg" class="img-responsive add-shadow img-margin"></a></p>

**Project Name**: IronScraperSample<br>
**Storage Location**: Select a directory on your computer

4. Selecting Your ASP.NET Templates

<ol type="a">
    <li>Select Empty Template</li>
    <li>Check Web Forms</li>
    <p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ASPNETTemplates.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ASPNETTemplates.jpg" class="img-responsive add-shadow img-margin"></a></p>
</ol>

5. At this point, your fundamental ASP.NET Web Form Project is successfully established.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ASPNETWebFormProject.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ASPNETWebFormProject.jpg" class="img-responsive add-shadow img-margin"></a></p>

[Download the complete tutorial sample project code here](https://ironsoftware.com/downloads/assets/tutorials/webscraping-in-c-sharp/IronWebScraperSample.zip).

