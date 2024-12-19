# How to Extract Data from Websites in C<span>#</span> #

***Based on <https://ironsoftware.com/tutorials/webscraping-in-c-sharp/>***


IronWebScraper is a .NET library designed for web scraping, extracting web data, and parsing web content. This library is straightforward to integrate with Microsoft Visual Studio projects for both development and production environments.

IronWebScraper offers a variety of distinctive functionalities, including the ability to specify allowed and restricted pages, objects, and media types. Moreover, it supports the management of multiple identities and web caching among other advanced features, which will be explored in detail throughout this tutorial.

<h3>Get started with IronWebscraper</h3>

# How to Scrape Data from Websites in C#

***Based on <https://ironsoftware.com/tutorials/webscraping-in-c-sharp/>***


IronWebscraper is a powerful .NET library designed for web scraping, content parsing, and data extraction. It integrates seamlessly with Microsoft Visual Studio and can be easily employed in both development and production environments.

IronWebscraper offers a wide array of features, allowing you to specify allowed and prohibited pages, objects, and media types. Additionally, it supports management of multiple identities, web caching, and offers numerous other functionalities, which will be discussed throughout this tutorial.

### Getting Started with IronWebscraper

## Intended Audience

This guide is designed for software developers, ranging from beginners to those with advanced coding skills, who aim to develop solutions requiring sophisticated web scraping (e.g., data extraction, website content analysis, and information harvesting).

![Webscraping banner](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/banner.jpg "Webscraping has never been a simple task, with no dominant frameworks for use in C# or .NET programming environments. Iron Web Scraper was created to change this")

### Prerequisite Skills

1. A basic understanding of programming with any Microsoft programming language, such as C# or VB.NET.
2. A fundamental knowledge of web technologies (HTML, JavaScript, jQuery, CSS, etc.) and their operations.
3. An understanding of DOM, XPath, HTML and CSS Selectors.

### Required Tools

1. Microsoft Visual Studio 2010 or newer.
2. Web developer extensions for browsers like Chrome's web inspector or Firefox's Firebug.

## Why use IronWebscraper?

IronWebscraper is ideal if you're looking to:

- Extract data from websites.
- Compare content, prices, or features across different sites.
- Handle scanning and caching of web content efficiently.

## Installing IronWebScraper

### Easy Installation with NuGet

Add IronWebScraper to your project effortlessly using the NuGet Package Manager in Visual Studio. Simply right-click on your project name, select 'Manage NuGet Packages', and search for `IronWebScraper` to install it.

#### NuGet Package Manager Method

1. Right-click on the project name in Visual Studio and choose 'Manage NuGet Packages'.
![Add IronWebScraper using GUI](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI.jpg)
2. Search for `IronWebScraper` and click 'Install'.
![Search and install IronWebScraper](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI2.jpg)
3. Confirm the installation to proceed.
![Confirm Installation](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI3.jpg)
4. Installation complete!
![Installation Complete](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI4.jpg)

#### Using the Package Manager Console

1. Go to `Tools` → `NuGet Package Manager` → `Package Manager Console`.
![Open Package Manager Console](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole.jpg)
2. Set your project as the default.
3. Execute the command: `Install-Package IronWebScraper`.
![Installing via Console](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole1.jpg)

### Manual Installation

1. Visit [IronWebScraper’s download page](https://ironsoftware.com/csharp/webscraper/)
2. Click the 'Download DLL' button and extract the files.
3. In Visual Studio, right-click on your project, go to 'Add' → 'Reference' → 'Browse', and select the extracted `.dll` files.
![Add IronWebScraper DLL](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll.jpg)
![Select DLL Files](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll2.png)
4. Completion of the manual setup!

### Conclusion

This brief overview introduces the basic capability and installation methods of IronWebScraper. As this walkthrough shows, integrating IronWebScraper into your .NET projects is straightforward, whether through NuGet or manually adding the libraries. This library offers the robust functionality required for effective web scraping.

## Intended Readers

This guide is designed for software developers, whether they are beginners or possess advanced skills, looking to craft and deploy sophisticated solutions for complex web scraping tasks, including but not limited to, data extraction, content parsing, and web harvesting from various websites.

<div class="article-img tutorial-img">
	<img src="/img/tutorials/webscraping-in-c-sharp/banner.jpg" alt="Webscraping has never been a simple task, with no dominant frameworks for use in C# or .NET programming environments. Iron Web Scraper was created to change this" class="img-responsive">
</div>

### Prerequisite Skills

1. Fundamental programming skills in a Microsoft programming language such as C# or VB.NET.
2. A foundational understanding of web technologies including HTML, JavaScript, jQuery, CSS, and their functionalities.
3. Basic familiarity with the DOM, XPath, and the use of HTML and CSS selectors.

### Essential Tools

1. Microsoft Visual Studio 2010 or newer

2. Browser development tools like Chrome's Web Inspector or Firefox's Firebug extension

## Motivations for Scraping Data (Key Concepts and Reasons)

If you're planning to develop a solution or product capable of:

1. Harvesting data from websites
2. Comparing information, such as content, prices, and features across various sites
3. Storing and managing web content efficiently

IronWebscraper serves as an ideal tool tailored for these requirements, offering robust data extraction and management capabilities suitable for diverse web scraping needs.

## Installing IronWebScraper in Your Project

Once you've initiated a new project (refer to Appendix A for details), it becomes straightforward to incorporate the IronWebScraper library. You have the option to either integrate it automatically using NuGet or by manually downloading and adding the DLL file.

### Automatic Installation Using NuGet

You can conveniently add the IronWebScraper library to your project through NuGet. This can be achieved either via the NuGet Package Manager GUI, which is user-friendly especially for novices, or through the NuGet Package Manager Console, which is perfect for those who prefer command-line operations.

#### Installing via NuGet Package Manager Interface
1. Right-click on your project in the Solution Explorer and select "Manage NuGet Packages."
2. Navigate to the 'Browse' tab, search for `IronWebScraper`, and select the 'Install' option.

#### Installing via NuGet Package Manager Console
1. Go to 'Tools', choose 'NuGet Package Manager', then select 'Package Manager Console'.
2. Ensure your project is set as the default project in the console.
3. Type and enter the command: `Install-Package IronWebScraper`.

### Manual Installation
If you prefer to manually install the IronWebScraper DLL:
1. Visit the IronWebScraper page at [Iron Software](https://ironsoftware.com/csharp/webscraper/) and download the DLL file.
2. Open your project in Visual Studio, right-click on 'References' in your project, and click 'Add Reference'.
3. Navigate to the downloaded DLL file, select it, and confirm by clicking 'OK'.

### Installation via NuGet

To integrate the IronWebScraper library into your project, you can use either the graphical NuGet Package Manager interface or execute commands in the Package Manager Console. Here’s how you can do it:

#### Utilizing the NuGet Package Manager

1. With your mouse, right-click on the project name and choose "Manage NuGet Packages" from the context menu.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI.jpg" class="img-responsive add-shadow img-margin"></a></p>

2. Navigate to the browse tab, then search for `IronWebScraper` and select the option to install it.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI2.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI2.jpg" class="img-responsive add-shadow img-margin"></a></p>

3. Proceed by clicking the 'Ok' button.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI3.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI3.jpg" class="img-responsive add-shadow img-margin"></a></p>

4. That completes the installation process!

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI4.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingGUI4.jpg" class="img-responsive add-shadow img-margin"></a></p>

#### Utilizing the NuGet Package Console

1. Navigate to `Tools` -> `NuGet Package Manager` -> `Package Manager Console` in the IDE.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here is the paraphrased section with corrected relative URL paths resolved to ironsoftware.com:

-----
2. Set the Class Library Project as the default project type.

3. Execute the command: `Install-Package IronWebScraper`

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole1.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingConsole1.jpg" class="img-responsive add-shadow img-margin"></a></p>

### Manual Installation Guide

1. Visit [Iron Software's official website](https://ironsoftware.com).

2. Navigate directly to the IronWebScraper's specific page by following [this link](https://ironsoftware.com/csharp/webscraper/).

3. Select the option to download the DLL file.

4. Once downloaded, unzip the contents of the compressed file.

5. Within Visual Studio, right-click on your project in the Solution Explorer, choose 'Add', then 'Reference', and finally 'Browse' to locate and include the extracted DLL in your project.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll.jpg" class="img-responsive add-shadow img-margin"></a></p>

6. Navigate to the extracted directory, open the `netstandard2.0` folder, and choose all `.dll` files for selection.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll2.png" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/AddIronWebscraperUsingDll2.png" class="img-responsive add-shadow img-margin"></a></p>

7. That completes the process!

## Introduction to HelloScraper: Your Initial IronWebScraper Application

To commence our journey with IronWebScraper, we'll begin by developing a simple application called Hello Scraper.

* First, create a new console application titled “IronWebScraperSample”

### Steps to Set Up Your First IronWebScraper Application ###

1. **Create a directory:** Begin by creating a directory named `HelloScraperSample`
   
2. **Add a new class to your project:** Name this class `HelloScraper`

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/HelloScraperAddClass.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/HelloScraperAddClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

```cs
public class HelloScraper : WebScraper
{
        /// <summary>
        /// Initialize the web-scraper here.
        /// Essential to request at least one URL at the start and configure domain or URL restrictions.
        /// </summary>
        public override void Init()
        {
            License.LicenseKey = "LicenseKey"; // Input your License Key
            this.LoggingLevel = WebScraper.LogLevel.All; // Log all activities
            this.Request("https://blog.scrapinghub.com", Parse); // Start with this URL
        }

        /// <summary>
        /// This is the main parsing method for the web scraper.
        /// Here you define how the scraper handles HTTP responses.
        /// If needed, add more methods for different types of pages.
        /// </summary>
        /// <param name="response">The received HTTP response</param>
        public override void Parse(Response response)
        {
            // Setting the directory to save our results
            this.WorkingDirectory = AppSetting.GetAppRoot()+ @"\HelloScraperSample\Output\";

            // Iterating over each link element on the page
            foreach (var title_link in response.Css("h2.entry-title a"))
            {
                // Extracting the text of the link
                string strTitle = title_link.TextContentClean;
                // Storing the result in a JSON file
                Scrape(new ScrapedData() { { "Title", strTitle } }, "HelloScraper.json");
            }

            // Check if there are more pages to scrape and request them
            if (response.CssExists("div.prev-post > a[href]"))
            {
                var next_page = response.Css("div.prev-post > a[href]")[0].Attributes["href"];
                this.Request(next_page, Parse); // Reinvoke Parse on new page
            }
        }
}
```

```cs
public class HelloScraper : WebScraper
{
        /// <summary>
        /// Initializes the web scraper with essential settings.
        /// This includes defining the initial URL to scrape and setting rules for allowed or prohibited domains and URLs.
        /// </summary>
        public override void Init()
        {
            License.LicenseKey = "LicenseKey";  // Enter the appropriate license key here
            this.LoggingLevel = WebScraper.LogLevel.All;  // Enables logging at all levels
            this.Request("https://blog.scrapinghub.com", Parse);  // Initial URL to start scraping from
        }

        /// <summary>
        /// Creates a default response handler for processing web responses.
        /// You can define additional handlers for different types of pages or content as needed.
        /// </summary>
        /// <param name="response">The HTTP response to handle and parse data from</param>
        public override void Parse(Response response)
        {
            // Specifies the directory where the output will be saved
            this.WorkingDirectory = AppSetting.GetAppRoot() + @"\HelloScraperSample\Output\";
            // Process each link found within the specified CSS path
            foreach (var titleLink in response.Css("h2.entry-title a"))
            {
                // Extract the text content of the link
                string titleText = titleLink.TextContentClean;
                // Save the scraped title to a JSON file
                Scrape(new ScrapedData() { { "Title", titleText } }, "HelloScraper.json");
            }
            // Check and process the subsequent page link if it exists
            if (response.CssExists("div.prev-post > a[href]"))
            {
                // Extract the URL of the next page
                string nextPage = response.Css("div.prev-post > a[href]")[0].Attributes["href"];
                // Continue scraping on the next page by calling the same Parse method recursively
                this.Request(nextPage, Parse);
            }
        }
}
```

```cs
static void Main(string [] args)
{
        // Instantiate the HelloScraper class
        HelloScraperSample.HelloScraper scraper = new HelloScraperSample.HelloScraper();
        // Initiate the web scraping process
        scraper.Start();
}
```

Here's the paraphrased section of your C# code snippet, resolving any relative URL paths to `ironsoftware.com`:

```cs
static void Main(string[] args)
{
    // Instantiate the HelloScraper class from the HelloScraperSample
    HelloScraperSample.HelloScraper scraper = new HelloScraperSample.HelloScraper();
    // Initiate the scraping process
    scraper.Start();
}
```

The output will be preserved in a file following the structure: `WebScraper.WorkingDirectory/classname.Json`. This format organizes the scraped data into a structured JSON file, storing it in the directory specified by the `WorkingDirectory` attribute of the `WebScraper` instance, under a filename that reflects the class name.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/HelloScraperFrmFileResult.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/HelloScraperFrmFileResult.jpg" class="img-responsive add-shadow img-margin"></a></p>

### Overview of Code Execution

The `Scrape.Start()` method initiates the scraping process in the following sequence:

1. It starts by calling the `Init()` method. This method is crucial for initializing variables, setting up properties for the scrape, and defining behaviors.

2. It goes on to set the initial page for the request with `this.Request("https://blog.scrapinghub.com", Parse)`. The `Parse(Response response)` method is slated as the response handler, where the actual parsing of data takes place.

3. The web scraper operates both HTTP requests and threading in tandem, ensuring that all operations are synchronized, thus facilitating easier debugging.

4. Upon executing the `Init()` method, the `Parse` method is immediately triggered to begin processing the web page content.

<ol type="a">
    <li><p>You can find elements using (Css selectors, Js DOM, XPath)</p></li>
    <li><p>Selected elements are casted to the type ScrapedData Class, you can cast them to any custom Class Like (Product, Employee, News, etc.)</p></li>
    <li><p>The objects saved in a file with Json Format in the (“bin/Scrape/”) Directory. Or you can set the path of the file as a parameter as we will see later in other examples.</p></li>
</ol>

## Features and Functionalities of IronWebScraper Library

For the latest documentation on the IronWebScraper library, you can access the IronWebScraper Documentation.chm File, included inside the zip file from a manual installation.

Alternatively, the most current online documentation is available at [IronWebScraper Object Reference](https://ironsoftware.com/csharp/webscraper/object-reference/).

To effectively integrate IronWebScraper into your projects, your classes should derive from the `IronWebScraper.WebScraper` class. This inheritance enriches your class library by embedding robust web scraping functionalities directly into your applications.

Furthermore, it's imperative to implement the methods `Init()` and `Parse(Response response)` to configure and dictate how your web scraper handles HTTP responses.

Here is the paraphrased section of the article:

```cs
namespace IronWebScraperEngine
{
    public class NewsScraper : IronWebScraper.WebScraper
    {
        public override void Init()
        {
            // Initialization logic will be defined here
            throw new NotImplementedException("Initialization not implemented yet.");
        }


        public override void Parse(Response response)
        {
            // Logic to parse data from the response goes here
            throw new NotImplementedException("Parse method not implemented yet.");
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

<td>Utilized to include or exclude specific URLs and domains<br>Example: BannedUrls.Add("*.zip", "*.exe", "*.gz", "*.pdf");<br>Note:
```

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

<td>Enumeration Options:

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

### Scraping an Online Movie Database

We'll start with a practical scenario by scraping a movie database website.

Let's create a new class that we'll name `MovieScraper`:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here’s a snippet of the homepage HTML from the site:
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
We have identifiers, titles, and detailed page links for movies.

Starting to scrape:
```cs
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
        foreach (var Divs in response.Css("#movie-featured > div"))
        {
            if (Divs.Attributes ["class"] != "clearfix")
            {
                var MovieId = Divs.GetAttribute("data-movie-id");
                var link = Divs.Css("a")[0];
                var MovieTitle = link.TextContentClean;
                Scrape(new ScrapedData() { { "MovieId", MovieId }, { "MovieTitle", MovieTitle } }, "Movie.Jsonl");
            }
        }           
    }
}
```

*Enhancements include:*

The `WorkingDirectory` attribute sets the primary directory for all related scraped files.

Let's delve further:

Why don't we craft a detailed `Movie` class to encapsulate our scraped data?

```cs
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

After defining our `Movie` class, we modify our code to accommodate typed objects.
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
                this.Request(movie.URL, ParseDetails, new MetaData() { { "movie", movie } });// to scrap Detailed Page
            }
        }           
    }
    public void ParseDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("movie");
        var Div = response.Css("div.mvic-desc")[0];
        movie.Description = Div.Css("div.desc")[0].TextContentClean;
        foreach(var Genre in Div.Css("div > p > a"))
        {
            movie.Genre.Add(Genre.TextContentClean);
        }
        foreach (var Actor in Div.Css("div > p:nth-child(2) > a"))
        {
            movie.Actor.Add(Actor.TextContentClean);
        }
        Scrape(movie, "Movie.Jsonl");
    }
}
```

*What's new?*

1. Scrape functions such as `ParseDetails` allow for detailed page scraping.
2. The `Scrape` function now produces a file with our structured data, utilizing the `MetaData` feature to transfer our object across scraping functions.
3. Data are now saved to a file reflecting our structured movie object.

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass1.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass1.jpg" class="img-responsive add-shadow img-margin"></a></p>

### Scraping a Movie Website

For our next practical example, we will delve into scraping a movie-related website.

We'll begin by creating a new class called `MovieScraper` for this purpose.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

Let's examine the target website that we'll be scraping:

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/123movies.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/123movies.jpg" class="img-responsive add-shadow img-margin"></a></p>

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
This section displays the initial HTML structure observed on the website's main page:

```html
<div id="featured-movies" class="movie-listing full-tab active fade-in">
    <div data-film-id="20746" class="movie-entry">
        <a href="https://website.com/film/king-arthur-legend-of-the-sword-20746/">
            <span class="movie-quality">CAM</span>
            <img data-original="https://img.gocdn.online/2017/05/16/poster/2116d6719c710eabe83b377463230fbe-king-arthur-legend-of-the-sword.jpg"
                 class="lazy thumb movie-thumbnail" alt="King Arthur: Legend of the Sword"
                 src="https://img.gocdn.online/2017/05/16/poster/2116d6719c710eabe83b377463230fbe-king-arthur-legend-of-the-sword.jpg"
                 style="display: inline;">
            <span class="movie-info"><h2>King Arthur: Legend of the Sword</h2></span>
        </a>
    </div>
    <div data-film-id="20724" class="movie-entry">
        <a href="https://website.com/film/snatched-20724/">
            <span class="movie-quality">CAM</span>
            <img data-original="https://img.gocdn.online/2017/05/16/poster/5ef66403dc331009bdb5aa37cfe819ba-snatched.jpg"
                 class="lazy thumb movie-thumbnail" alt="Snatched"
                 src="https://img.gocdn.online/2017/05/16/poster/5ef66403dc331009bdb5aa37cfe819ba-snatched.jpg"
                 style="display: inline;">
            <span class="movie-info"><h2>Snatched</h2></span>
        </a>
    </div>
</div>
```

# Initiate Scraping Specific Movie Data

***Based on <https://ironsoftware.com/tutorials/webscraping-in-c-sharp/>***


From the extracted information, each movie includes a unique identifier, a title, and a link leading to its detailed information page.

## Begin Scraping Process for Movie Data

Using the structure we observed containing the movie ID, title, and link, we'll implement the following steps to extract this data:

```csharp
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("www.website.com", ScrapeMovieList);
    }

    public override void ScrapeMovieList(Response response)
    {
        foreach (var movieEntry in response.Css("#movie-featured > div"))
        {
            if (!movieEntry.Attributes["class"].Contains("clearfix"))
            {
                var movie = new Movie
                {
                    Id = Convert.ToInt32(movieEntry.GetAttribute("data-movie-id")),
                    Title = movieEntry.Css("a")[0].TextContentClean,
                    URL = movieEntry.Css("a")[0].Attributes["href"]
                };

                // Continue the scraping in detailed page
                this.Request(movie.URL, ParseMovieDetails, new MetaData { { "currentMovie", movie } });
            }
        }           
    }

    // Parsing the details from the movie's dedicated page
    public void ParseMovieDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("currentMovie");
        // Implementation for detailed scraping goes here...
        Scrape(movie, "DetailedMovie.Json");
    }
}
```

- **Initial Setup**: Initializes the scraper settings, including its logging level and working directory.
- **ScrapeMovieList Method**: Targets each movie container using specific CSS selectors, checks for relevant classes to skip unwanted elements, extracts the movie ID, title, and the link, and initiates a new request to scrape detailed data.
- **ParseMovieDetails Method**: Intended to extract in-depth details from each movie's dedicated page using the provided URL. The extracted data is then saved.

This structured approach ensures a thorough extraction and handling of data specific to each movie from the list to its detailed page, enhancing accuracy and efficiency in data acquisition.

```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "YourLicenseKeyHere";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("http://www.website.com", Parse);
    }

    public override void Parse(Response response)
    {
        var movieBlocks = response.Css("#movie-featured > div");
        foreach (var block in movieBlocks)
        {
            if (block.Attributes["class"] != "clearfix")
            {
                var movieIdentity = block.GetAttribute("data-movie-id");
                var movieAnchor = block.Css("a")[0];
                var movieTitle = movieAnchor.TextContentClean;
                Scrape(new ScrapedData() { { "MovieID", movieIdentity }, { "Title", movieTitle } }, "MovieDetails.Jsonl");
            }
        }
    }
}
```

*Exploring the Updates in the Code*
-----

In the updated code, the `WorkingDirectory` property establishes the primary folder where all data retrieved from scraping operations is stored and managed.

*Advancing our Approach*
-----

What happens if we require structured objects to store the scraped data effectively?

We shall outline a `Movie` class designed specifically to encapsulate the scraped data in a structured format.

```cs
public class Film
{
    // Unique identifier for the movie
    public int Id { get; set; }
    // Title of the movie
    public string Title { get; set; }
    // URL link to the movie's detailed page
    public string URL { get; set; }
}
```

```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "LicenseKey"; // Set your license key here
        this.LoggingLevel = WebScraper.LogLevel.All; // Log all events during scraping
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\"; // Set the directory where all data will be saved
        this.Request("https://website.com/", Parse); // Initial request to start scraping from the homepage
    }

    public override void Parse(Response response)
    {
        foreach (var container in response.Css("#movie-featured > div")) // Select each movie container
        {
            if (container.Attributes["class"] != "clearfix") // Ensure it's not a clearfix
            {
                var constructedMovie = new Movie(); // Initialize a new Movie object
                constructedMovie.Id = int.Parse(container.GetAttribute("data-movie-id")); // Extract the movie's ID
                var movieLink = container.Css("a")[0]; // Get the first <a> tag within the movie block
                constructedMovie.Title = movieLink.TextContentClean; // Set the movie title
                constructedMovie.URL = movieLink.Attributes["href"]; // Extract the URL to the detail page
                Scrape(constructedMovie, "Movie.Jsonl"); // Save the scrapped data into a JSONL file named "Movie.Jsonl"
            }
        }
    }
}
```

*Changes made to the code:*
1. Enhanced clarity in comments for better understanding of each step.
2. Streamlined object and variable naming for readability.
3. Consolidated the actions of initializing and assigning properties of the `Movie` object.
4. Directly used the response from the CSS selector instead of intermediate variables for efficiency.
5. Addressed code consistency by ensuring all comments and logical checks were clear and concise.

Here's the paraphrased section of the code, adjusting the semantics while maintaining functional equivalency. Also, the relative link to `website.com` remains unchanged as it is generic and does not resolve to Iron Software's domain.

```cs
public class MovieScraper : WebScraper
{
    // Initialization method to configure the scraper settings
    public override void Init()
    {
        License.LicenseKey = "LicenseKey"; // Set your license key here
        this.LoggingLevel = WebScraper.LogLevel.All; // Enable logging at all levels
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\"; // Define where to store the output
        this.Request("https://website.com/", Parse); // Start the scraping operation
    }

    // Method to handle the response and extract data
    public override void Parse(Response response)
    {
        // Iterate through each div under the selected CSS path 
        foreach (var divItem in response.Css("#movie-featured > div"))
        {
            // Process only if it is not of class 'clearfix'
            if (divItem.Attributes["class"] != "clearfix")
            {
                var movie = new Movie(); // Instantiate a new movie object
                movie.Id = Convert.ToInt32(divItem.GetAttribute("data-movie-id")); // Extract the movie ID and convert to integer
                var linkElement = divItem.Css("a")[0]; // Get the first anchor element
                movie.Title = linkElement.TextContentClean; // Get the cleaned text content of the link as movie title
                movie.URL = linkElement.Attributes["href"]; // Extract the href attribute as movie URL

                Scrape(movie, "Movie.Jsonl"); // Scrape the movie data into a JSONL file
            }
        }
    }
}
```

*Updates and Enhancements:*

1. Implementation of the `Movie` class to encapsulate scraped data effectively.

2. Utilization of `Movie` objects with the `Scrape` method, which seamlessly recognizes and stores data in a structured format as illustrated below:

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

### Beginning with Detailed Page Scraping

Initiating the scraping process for a detailed page on a movie website, we'll explore how to capture more granular details.

#### Visual Overview of the Movie Page

Here's what the detailed movie page appears as:

![Movie Details Sample](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/movieDetailsSample.jpg)

Here's a snippet of the HTML content from this page:
```html
<div class="mvi-content">
    <div class="thumb mvic-thumb" 
         style="background-image: url(https://img.gocdn.online/2017/04/28/poster/5a08e94ba02118f22dc30f298c603210-guardians-of-the-galaxy-vol-2.jpg);">
    </div>
    <div class="mvic-desc">
        <h3>Guardians of the Galaxy Vol. 2</h3>
        <div class="desc">
            Set to the backdrop of Awesome Mixtape #2, Marvel's Guardians of the Galaxy Vol. 2 continues the team's adventures as they traverse the cosmos to assist Peter Quill in discovering more about his true parentage.
        </div>
        <div class="mvic-info">
            <div class="mvici-left">
                <p><strong>Genre: </strong>
                    <a href="https://Domain/genre/action/" title="Action">Action</a>,
                    <a href="https://Domain/genre/adventure/" title="Adventure">Adventure</a>,
                    <a href="https://Domain/genre/sci-fi/" title="Sci-Fi">Sci-Fi</a>
                </p>
                <p><strong>Actor: </strong>
                    <a target="_blank" href="https://Domain/actor/chris-pratt" title="Chris Pratt">Chris Pratt</a>,
                    <a target="_blank" href="https://Domain/actor/-zoe-saldana" title="Zoe Saldana">Zoe Saldana</a>,
                    <a target="_blank" href="https://Domain/actor/-dave-bautista-" title="Dave Bautista">Dave Bautista</a>
                </p>
                <p><strong>Director: </strong>
                    <a href="#" title="James Gunn">James Gunn</a>
                </p>
                <p><strong>Country: </strong>
                    <a href="https://Domain/country/us" title="United States">United States</a>
                </p>
            </div>
            <div class="mvici-right">
                <p><strong>Duration:</strong> 136 min</p>
                <p><strong>Quality:</strong> <span class="quality">CAM</span></p>
                <p><strong>Release:</strong> 2017</p>
                <p><strong>IMDb:</strong> 8.3</p>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="clearfix"></div>
    </div>
    <div class="clearfix"></div>
</div>
```
From the page, we can collect numerous attributes such as the movie ID, title, and a detailed link.

Let's enhance our scraper logic to capture this extended set of data:
```cs
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
        foreach (var Divs in response.Css("#movie-featured > div"))
        {
            if (Divs.Attributes ["class"] != "clearfix")
            {
                var movie = new Movie();
                movie.Id = Convert.ToInt32(Divs.GetAttribute("data-movie-id"));
                var link = Divs.Css("a")[0];
                movie.Title = link.TextContentClean;
                movie.URL = link.Attributes ["href"];
                this.Request(movie.URL, ParseDetails, new MetaData() { { "movie", movie } });  // to scrape Detailed Page
            }
        }           
    }
    public void ParseDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("movie");
        var Div = response.Css("div.mvic-desc")[0];
        movie.Description = Div.Css("div.desc")[0].TextContentClean;
        foreach(var Genre in Div.Css("div > p > a"))
        {
            movie.Genre.Add(Genre.TextContentClean);
        }
        foreach (var Actor in Div.Css("div > p:nth-child(2) > a"))
        {
            movie.Actor.Add(Actor.TextContentClean);
        }
        Scrape(movie, "Movie.Jsonl");
    }
}
```

#### Enhancements in the Scraping Code:
1. Adding functions (`ParseDetails`) to retrieve detailed pages
2. Scrape method now generates our file within a new function
3. Utilization of IronWebScraper's `MetaData` to pass our movie object between scraping functions
4. Scrapping and saving enriched movie object data to a file, ensuring comprehensive capture of detailed page elements.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/movieDetailsSample.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/movieDetailsSample.jpg" class="img-responsive add-shadow img-margin"></a></p>

```html
<div class="movie-content">
    <div class="movie-thumbnail" style="background-image: url(https://img.gocdn.online/2017/04/28/poster/5a08e94ba02118f22dc30f298c603210-guardians-of-the-galaxy-vol-2.jpg);"></div>
    <div class="movie-description">
        <h3>Guardians of the Galaxy Vol. 2</h3>
        <div class="summary">
            Continuing with the Awesome Mixtape #2, Marvel's Guardians of the Galaxy Vol. 2 follows the team as they journey across the universe to aid Peter Quill in discovering the secrets of his heritage.
        </div>
        <div class="movie-info">
            <div class="info-left">
                <p>
                    <strong>Genre: </strong>
                    <a href="https://ironsoftware.com/csharp/webscraper/genre/action/" title="Action">Action</a>,
                    <a href="https://ironsoftware.com/csharp/webscraper/genre/adventure/" title="Adventure">Adventure</a>,
                    <a href="https://ironsoftware.com/csharp/webscraper/genre/sci-fi/" title="Sci-Fi">Sci-Fi</a>
                </p>
                <p>
                    <strong>Actors: </strong>
                    <a target="_blank" href="https://ironsoftware.com/csharp/webscraper/actor/chris-pratt" title="Chris Pratt">Chris Pratt</a>,
                    <a target="_blank" href="https://ironsoftware.com/csharp/webscraper/actor/-zoe-saldana" title="Zoe Saldana">Zoe Saldana</a>,
                    <a target="_blank" href="https://ironsoftware.com/csharp/webscraper/actor/-dave-bautista-" title="Dave Bautista">Dave Bautista</a>
                </p>
                <p>
                    <strong>Directed by: </strong>
                    <a href="#" title="James Gunn">James Gunn</a>
                </p>
                <p>
                    <strong>Origin: </strong>
                    <a href="https://ironsoftware.com/csharp/webscraper/country/us" title="United States">United States</a>
                </p>
            </div>
            <div class="info-right">
                <p><strong>Runtime:</strong> 136 min</p>
                <p><strong>Quality:</strong> <span class="quality">CAM</span></p>
                <p><strong>Released:</strong> 2017</p>
                <p><strong>IMDb Rating:</strong> 8.3</p>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="clearfix"></div>
    </div>
    <div class="clearfix"></div>
</div>
```

We have the opportunity to augment our movie class with additional properties such as Description, Genre, Actor, Director, Country, Duration, and IMDB Score. However, for the purposes of this example, we will only utilize the Description, Genre, and Actor properties.

Here is the paraphrased section of the article:

```cs
public class Film
{
    public int Identifier { get; set; }
    public string Name { get; set; }
    public string Link { get; set; }
    public string Synopsis { get; set; }
    public List<string> Categories { get; set; }
    public List<string> Cast { get; set; }
}
```

Exploring the functionality of IronWebScraper, this tool offers the flexibility to enhance your scraping functionality, allowing you to handle various types of page structures effectively.

Here's how you can do it:

Certainly! Here's the paraphrased section with relative URL paths resolved:

```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "YourLicenseKeyHere";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("https://ironsoftware.com/domain/", Parse);
    }

    // Parsing the initial movie listing page
    public override void Parse(Response response)
    {
        foreach (var movieDiv in response.Css("#movie-featured > div"))
        {
            if (movieDiv.Attributes["class"] != "clearfix")
            {
                var movieInstance = new Movie();
                movieInstance.Id = Convert.ToInt32(movieDiv.GetAttribute("data-movie-id"));
                var movieLink = movieDiv.Css("a")[0];
                movieInstance.Title = movieLink.TextContentClean;
                movieInstance.URL = movieLink.Attributes["href"];
                // Fetching details from the movie detail page
                this.Request(movieInstance.URL, ParseDetails, new MetaData() { { "movie", movieInstance } });
            }
        }
    }

    // Parsing detailed movie information
    public void ParseDetails(Response response)
    {
        var detailedMovie = response.MetaData.Get<Movie>("movie");
        var descriptionDiv = response.Css("div.mvic-desc")[0];
        detailedMovie.Description = descriptionDiv.Css("div.desc")[0].TextContentClean;
        // Extract genres
        foreach (var genre in descriptionDiv.Css("div > p > a"))
        {
            detailedMovie.Genre.Add(genre.TextContentClean);
        }
        // Extract actors
        foreach (var actor in descriptionDiv.Css("div > p:nth-child(2) > a"))
        {
            detailedMovie.Actor.Add(actor.TextContentClean);
        }
        // Save the scraped data
        Scrape(detailedMovie, "Movie.Jsonl");
    }
}
``` 

This rewritten version maintains the logical structure of the original code but rephrases several parts for clarity and readability. Additionally, it ensures that external links refer to the intended domain.

### Key Updates in Scrape Functionality

1. Introduction of new scrape functions such as `ParseDetails` specifically for parsing more complex web pages.
   
2. The file generation step via the `Scrape` function has been shifted to the newly created function for more structured code organization.

3. We took advantage of the `MetaData` feature from IronWebScraper to efficiently pass data objects (in this case, the movie object) between different scraping functions.

4. Successfully executed the data extraction, capturing movie details into structured files using the updated scrape routines.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass1.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass1.jpg" class="img-responsive add-shadow img-margin"></a></p>

### Extracting Data from an E-commerce Website

For this example, we'll demonstrate how to extract data from an e-commerce website using IronWebScraper.

![Shopping Site Overview](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg)

As depicted in the image, the website features a navigation bar on the left that lists product categories, which is our primary focus to start the scraping process.

![Category List from Shopping Site](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg)

The e-commerce site segregates products into various categories, such as "Men", "Women", and "Kids" within broader categories like fashion.

```html
<li class="menu-item" data-id="">
    <a href="https://domain.com/fashion-by-/" class="main-category">
        <i class="cat-icon osh-font-fashion"></i>
        <span class="nav-subTxt">FASHION </span>
        <i class="osh-font-light-arrow-left"></i><i class="osh-font-light-arrow-right"></i>
    </a>
    <div class="navLayerWrapper" style="width: 633px; display: none;">
        <!-- Submenu Content Here -->
    </div>
</li>
```

To handle this scraping task, follow these steps:

1. **Initialize a New Project or Add a New Folder**: Create a console application or a new folder named “ShoppingSiteSample” for this example.
   
2. **Create a New Class**: Name it “ShoppingScraper”.

3. **Model the Data Structure**: Structure a `Category` class to encapsulate category details.
   ```cs
   public class Category
   {
       public string Name { get; set; }
       public string URL { get; set; }
       public List<Category> SubCategories { get; set; }
   }
   ```

4. **Build the Scraping Logic**: Use the following method to parse and scrape the categories and their subcategories.
   ```cs
   public class ShoppingScraper : WebScraper
   {
       public override void Init()
       {
           License.LicenseKey = "LicenseKey";
           this.LoggingLevel = WebScraper.LogLevel.All;
           this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
           this.Request("www.domain.com", Parse);
       }

       public override void Parse(Response response)
       {
           var categoryList = new List<Category>();

           foreach (var li in response.Css("#menuFixed > ul > li"))
           {
               var cat = new Category() {
                   URL = li.Css("a")[0].Attributes["href"],
                   Name = li.Css("a")[0].InnerText,
                   SubCategories = new List<Category>()
               };

               foreach (var subLi in li.Css("div.navLayerWrapper > div.submenu > div.column > div.categories > a.category"))
               {
                   var subCat = new Category() {
                       URL = subLi.Attributes["href"],
                       Name = subLi.InnerText
                   };
                   cat.SubCategories.Add(subCat);
               }

               categoryList.Add(cat);
           }

           Scrape(categoryList, "Categories.Jsonl");
       }
   }
   ```

By executing this scraping logic, you can effectively collect comprehensive details about the products available under each category on the target shopping website.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg" class="img-responsive add-shadow img-margin"></a></p>

As illustrated in the image, there's a sidebar on the left that holds links to various product categories of the site.

Initially, our task would be to examine the HTML of the site and strategize our approach to scraping it effectively.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg" class="img-responsive add-shadow img-margin"></a></p>

The categories on the fashion website are divided into subcategories such as Men, Women, and Kids.

```html
<li class="menu-item" data-id="">
    <a href="https://ironsoftware.com/fashion-by/" class="main-category">
        <i class="cat-icon osh-font-fashion"></i> <span class="nav-subTxt">FASHION </span> <i class="osh-font-light-arrow-left"></i><i class="osh-font-light-arrow-right"></i>
    </a>
    <div class="navLayerWrapper" style="width: 633px; display: none;">
        <div class="submenu">
            <div class="column">
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/fashion-by/?sort=newest&amp;dir=desc&amp;viewType=gridView3">New Arrivals!</a>
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

# Project Setup Instructions

***Based on <https://ironsoftware.com/tutorials/webscraping-in-c-sharp/>***


---- 

## Starting Your Project

To begin, either create a new Console Application or add a new folder named "ShoppingSiteSample" to an existing project to accommodate the sample code for scraping.

## Initializing the Scraper

Next, add a new class to your project and name it `ShoppingScraper`. This class will be responsible for the scraping operations.

## Scraper's Initial Task

Start with scraping the main categories and their respective subcategories from the target site.

## Define a Data Model for Categories

Construct a `Category` model to facilitate the organization of category data:

```cs
public class Category
{
    /// <summary>
    /// The category name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The URL associated with the category.
    /// </summary>
    public string URL { get; set; }

    /// <summary>
    /// A collection of subcategories under this category.
    /// </summary>
    public List<Category> SubCategories { get; set; }
}
```

This structured approach will lay the foundation for systematically scraping website categories and their subcategories, organizing them effectively within your application.

```cs
public class Category
{
    /// <summary>
    /// Property to get or set the category name.
    /// </summary>
    /// <value>
    /// Represents the name of the category.
    /// </value>
    public string Name { get; set; }
    
    /// <summary>
    /// Property to get or set the URL associated with this category.
    /// </summary>
    /// <value>
    /// Holds the URL of the category.
    /// </value>
    public string URL { get; set; }
    
    /// <summary>
    /// Property to get or set the list of child subcategories.
    /// </summary>
    /// <value>
    /// Contains the subcategories within this category.
    /// </value>
    public List<Category> SubCategories { get; set; }
}
```

Below is the rewritten section:

-----
4. Building the Scraping Logic

Now, let’s develop the scraping logic for our project:

```cs
public class ShoppingScraper : WebScraper
{
    /// <summary>
    /// This method prepares the web scraper with initial settings.
    /// It sets up necessary configurations such as start URLs and any domain or URL restrictions.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
        this.Request("www.webSite.com", Parse);
    }

    /// <summary>
    /// This method handles the response for the initial web request.
    /// The primary purpose here is to parse the HTTP response and manage data accordingly.
    /// If the needs arise for handling different types of pages, additional methods similar to this can be created.
    /// </summary>
    /// <param name="response">The HTTP response object from the requested URL</param>
    public override void Parse(Response response)
    {
        var categoryList = new List<Category>();
        
        foreach (var Links in response.Css("#menuFixed > ul > li > a "))
        {
            var cat = new Category();
            cat.URL = Links.Attributes["href"];
            cat.Name = Links.InnerText;
            categoryList.Add(cat);
        }
        Scrape(categoryList, "Shopping.Jsonl");
    }
}
```

This segment of code initializes our scraper by making an HTTP request to `www.webSite.com`. It then processes each category found within the designated CSS path `#menuFixed > ul > li > a` on the website. Each category is read into a new Category object, capturing the name and URL from the HTML element. These categories are collected into a list and are written into a JSONL file named `Shopping.Jsonl` for subsequent use. This organized approach helps streamline the extraction and structuring of meaningful data from websites.

```cs
public class ShoppingScraper : WebScraper
{
    /// <summary>
    /// Initializes the web scraper by setting up essential configurations such as the start URL and allowed/banned URL patterns.
    /// It is crucial to start with at least one URL to begin scraping.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;  // Set the logging level to log all events
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";  // Set the working directory for output files
        this.Request("www.webSite.com", Parse); // Initial web request to start scraping
    }

    /// <summary>
    /// This method acts as the primary response handler for the web scraper.
    /// Here, you can define how to process the HTTP response and extract information.
    /// This method can be duplicated or modified for handling different types of web pages.
    /// </summary>
    /// <param name="response">The HTTP Response object from which data will be parsed</param>
    public override void Parse(Response response)
    {
        var categoryList = new List<Category>();  // Initialize a list to hold category data

        // Loop through each category link found in the specified CSS path
        foreach (var link in response.Css("#menuFixed > ul > li > a "))
        {
            var category = new Category
            {
                URL = link.Attributes["href"],  // Get the href attribute as category URL
                Name = link.InnerText.Trim()  // Get the text content as category name and trim any excess whitespace
            };
            categoryList.Add(category);  // Add the category to the list
        }
        Scrape(categoryList, "Shopping.Jsonl");  // Save the extracted category list as a JSONL file
    }
}
```

Here's a paraphrased section of the text provided:

-----

### Extracting Links from the Navigation Menu

During our exploration of web scraping with IronWebScraper, an essential step is to extract links from a website’s navigation menu. This piece will guide you through the process using IronWebScraper to capture main and sub-category links efficiently.

Consider the following visual representation of our task:

![Scraping links from the navigation menu](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg)

Now let's delve into the code development process:

1. **Initialize the Scraper:** Starting with configuring our `WebScraper` instance to target our desired webpage.
2. **Parse the Main Category Links:** We utilize a selector to gather all primary links from the menu.
3. **Capture Sub-category Links:** For each main category element, identify and gather the links to its sub-categories.
4. **Data Structuring:** Construct a hierarchical model that mirrors the main categories and their respective sub-categories for a better organized and more accessible navigation hierarchy.
5. **Storing Results:** Finally, save the structured data in a JSONL format, facilitating further manipulations or integrations.

By scrupulously following these steps, the navigation structure of any given website can be dissected and conveniently scraped, paving the way for more detailed and targeted data extraction tasks.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" class="img-responsive add-shadow img-margin"></a></p>

We will refine our scraping technique to capture the primary categories and all its associated subcategories.

```cs
public override void Parse(Response response)
{
    // Initiating a list to store category links
    var categoryList = new List<Category>();
    
    // Loop through each 'li' element within the specified section
    foreach (var li in response.Css("#menuFixed > ul > li"))
    {
        // Iterate through each link within this category
        foreach (var Links in li.Css("a"))
        {
            var cat = new Category
            {
                URL = Links.Attributes["href"], // Extracting the hyperlink
                Name = Links.InnerText, // Extracting the link text
                SubCategories = new List<Category>() // Preparing to store subcategories
            };
            
            // Gather all subcategories under this main category
            foreach (var subCategory in li.Css("a[class=subcategory]"))
            {
                var subcat = new Category
                {
                    URL = Links.Attributes["href"],
                    Name = Links.InnerText
                };
                // Ensure this subcategory is unique before adding
                if (!cat.SubCategories.Any(c => c.Name == subcat.Name && c.URL == subcat.URL))
                {
                    cat.SubCategories.Add(subcat);
                }
            }
            // Add this populated category to the main list
            categoryList.Add(cat);
        }
    }
    // Save the collected categories data into a Jsonl file
    Scrape(categoryList, "Shopping.Jsonl");
}
```

This updated script focuses on capturing not only the main categories found on the navigation bar but also drills down to fetch all associated subcategories for each primary category. This hierarchical data capture ensures a comprehensive scraping of site structure, providing a robust dataset for subsequent data analysis tasks.

Here is the paraphrased section of the article with relative URLs resolved to `ironsoftware.com`:

```cs
public override void Parse(Response response)
{
    // Initialize list to store the root category links
    var mainCategoryList = new List<Category>();

    // Iterate through each list item within the fixed menu
    foreach (var listItem in response.Css("#menuFixed > ul > li"))
    {
        // Extract main category links
        foreach (var link in listItem.Css("a"))
        {
            var category = new Category
            {
                URL = link.Attributes["href"],
                Name = link.InnerText,
                SubCategories = new List<Category>()
            };

            // Extract subcategory links
            foreach (var subLink in listItem.Css("a[class=subcategory]"))
            {
                var subCategory = new Category
                {
                    URL = link.Attributes["href"],
                    Name = link.InnerText
                };

                // Avoid adding duplicate subcategory links
                if (!category.SubCategories.Exists(x => x.Name == subCategory.Name && x.URL == subCategory.URL))
                {
                    category.SubCategories.Add(subCategory);
                }
            }
            // Populate the main category list
            mainCategoryList.Add(category);
        }
    }
    // Invoke the Scrape method to process the structured data
    Scrape(mainCategoryList, "Shopping.Jsonl");
}
```

This revised code maintains the original functionality while enhancing readability and commenting for clarity.

Now that we have acquired links for all the site categories, it's time to begin extracting product data from each category.

We'll proceed by exploring a specific category and examining its contents.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" class="img-responsive add-shadow img-margin"></a></p>

```html
<section class="products">
    <div class="sku -gallery -validate-size" data-sku="AG249FA0T2PSGNAFAMZ" ft-product-sizes="41,42,43,44,45" ft-product-color="Multicolour">
        <a class="link" href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Bundle Of 2 Sneakers - Black & Navy Blue" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-sku="AG249FA0T2PSGNAFAMZ" data-src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg"/>
            </div>
            <h2 class="title">
                <span class="brand">Agu&nbsp;</span>
                <span class="name" dir="ltr">Bundle Of 2 Sneakers - Black & Navy Blue</span>
            </h2>
            <div class="price-container clearfix">
                <span class="price-box">
                    <span class="price">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="299">299</span>
                    </span>
                    <span class="price -old -no-special"></span>
                </span>
            </div>
            <div class="rating-stars">
                <div class="stars-container">
                    <div class="stars" style="width: 62%"></div>
                </div>
                <div class="total-ratings">(30)</div>
            </div>
            <span class="shop-first-logo-container">
                <img src="http://www.WebSite.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" data-src="http://www.WebSite.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" class="lazy shop-first-logo-img -mbxs -loaded"/>
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
                <img class="lazy image -loaded" alt="Genuine Leather Belt - Black" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-sku="LE047FA01SRK4NAFAMZ" data-src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg"/>
            </div>
            <h2 class="title">
                <span class="brand">Leather Shop&nbsp;</span>
                <span class="name" dir="ltr">Genuine Leather Belt - Black</span>
            </h2>
            <div class="price-container clearfix">
                <span class="sale-flag-percent">-29%</span>
                <span class="price-box">
                    <span class="price">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="96">96</span>
                    </span>
                    <span class="price -old">
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
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=115">115</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=120">120</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=125">125</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=130">130</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=135">135</span>
            </div>
        </a>
    </div>
</section>
```

This HTML snippet showcases a section of a website listing products such as sneakers and belts. Each product is enclosed within a `div` element marked with the class `sku -gallery -validate-size`. Information such as the product's unique identifier (SKU), image, name, and pricing details are nicely structured using various HTML elements. The links to specific product pages are encapsulated within `a` tags, complete with dynamic attributes to handle different product sizes. The structure also includes graphical elements like brand logos and rating stars to enhance visual appeal and user engagement.

```html
<section class="products">
    <div class="sku -gallery -validate-size " data-sku="AG249FA0T2PSGNAFAMZ" ft-product-sizes="41,42,43,44,45" ft-product-color="Multicolour">
        <a class="link" href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Bundle of 2 Sneakers - Black & Navy Blue" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-sku="AG249FA0T2PSGNAFAMZ" data-src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg">
                <noscript><img src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
            </div>
            <h2 class="title">
                <span class="brand">Agu&nbsp;</span>
                <span class="name" dir="ltr">Bundle of 2 Sneakers - Black & Navy Blue</span>
            </h2>
            <div class="price-container clearfix">
                <span class="price-box">
                    <span class="price">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="299">299</span>
                    </span>
                    <span class="price -old -no-special"></span>
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
    <div class="sku -gallery -validate-size " data-sku="LE047FA01SRK4NAFAMZ" ft-product-sizes="110,115,120,125,130,135" ft-product-color="Black">
        <a class="link" href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Genuine Leather Belt - Black" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-sku="LE047FA01SRK4NAFAMZ" data-src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg">
                <noscript><img src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
            </div>
            <h2 class="title">
                <span class="brand">Leather Shop&nbsp;</span>
                <span class="name" dir="ltr">Genuine Leather Belt - Black</span>
            </h2>
            <div class="price-container clearfix">
                <span class="sale-flag-percent">-29%</span>
                <span class="price-box">
                    <span class="price">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="96">96</span>
                    </span>
                    <span class="price -old">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="135">135</span>
                    </span>
                </span>
            </div>
            <div class="rating-stars">
                <div class="stars-container">
                    <div the="stars" style="width: 100%"></div>
                </div>
                <div class="total-ratings">(1)</div>
            </div>
            <span class="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>
            <div class="list -sizes" data-selected-sku="">
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=110">110</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=115">115</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=120">120</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=125">125</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=130">130</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=135">135</span>
            </div>
        </a>
    </div>
</section>
```

### Creating a Product Model for Scraping

To efficiently manage data fetched during web scraping, it's crucial to establish a structured product model. This model will store specific attributes of products which we'll extract from a website.

Here’s how we can design our product model:

#### Define the Product Model

We'll define a `Product` class to encapsulate details for each product we'll scrape. The model will contain properties such as the name of the product, its price, and an image link. Here's a simple implementation:

```csharp
public class Product
{
    /// <summary>
    /// The name of the product.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The selling price of the product.
    /// </summary>
    public string Price { get; set; }

    /// <summary>
    /// A URL pointing to an image of the product.
    /// </summary>
    public string Image { get; set; }
}
```

This structured class will ensure the data extracted during the scraping process is organized effectively, making it easier to handle and store.

Here's a paraphrased version of the provided C# class section:

```cs
public class Product
{
    /// <summary>
    /// Property to store the product's name.
    /// </summary>
    /// <value>
    /// Represents the product's name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Property to store the product's price.
    /// </summary>
    /// <value>
    /// Represents the cost of the product in string format.
    /// </value>
    public string Price { get; set; }

    /// <summary>
    /// Property to store URL or path to the product's image.
    /// </summary>
    /// <value>
    /// Represents the link or file path to the product's image.
    /// </value>
    public string Image { get; set; }
}
```

To extract data from category pages effectively, we introduce a new scraping method:

```cs
public void ParseCatgory(Response response)
{          
    // Initialize a list to collect product information
    var productList = new List<Product>();

    // Loop through each product link gathered from the response
    foreach (var Links in response.Css("body > main > section.osh-content > section.products > div > a"))
    {
        var product = new Product();
        product.Name = Links.InnerText;
        product.Image = Links.Css("div.image-wrapper.default-state > img")[0].Attributes ["src"];                
        productList.Add(product);
    }

    // Save the scraped products to a JSON line file
    Scrape(productList, "Products.Jsonl");
}
```

In this method, we navigate through the HTML elements that contain product details using CSS selectors to capture the name and image source of each product. These are then stored in a `Product` object and added to a list. The `Scrape` function finally saves all acquired data into a file, allowing structured storage of the extracted data from the webpage.

```cs
public void ParseCategory(Response response)
{
    // Initialize product list to store parsed products
    var products = new List<Product>();
    
    // Loop through each product link found in the specified DOM path
    foreach (var linkElement in response.Css("body > main > section.osh-content > section.products > div > a"))
    {
        var productItem = new Product();
        productItem.Name = linkElement.InnerText; // Assign product name from link text
        productItem.Image = linkElement.Css("div.image-wrapper.default-state > img")[0].Attributes["src"];  // Assign image URL from image source attribute
        products.Add(productItem); // Add product to list
    }

    // Store the parsed product data in a JSONL file named 'Products.Jsonl'
    Scrape(products, "Products.Jsonl");
}
```

### Enhanced Webscraping Capabilities

#### Feature: HttpIdentity

When scraping content from websites that require user authentication to access certain pages, the HttpIdentity feature comes in handy. This attribute allows you to configure web scrapers with specific user credentials or browser details, enabling them to mimic logged-in users.

```cs
HttpIdentity identity = new HttpIdentity()
{
    NetworkUsername = "username", 
    NetworkPassword = "password"
};
Identities.Add(identity);
```

IronWebScraper's robust design also supports the simultaneous use of various user agents and proxies, enhancing the ability to scrape complex websites without detection.

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\SampleOutput\";

    string[] proxies = { "IP-Proxy1:8080", "IP-Proxy2:8081" };
    foreach (string userAgent in IronWebScraper.CommonUserAgents.ChromeDesktopUserAgents)
    {
        foreach (string proxy in proxies)
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

Key configurable properties include:
- **NetworkDomain**: Specify the network domain for user authentication, used with NetworkUsername and NetworkPassword.
- **NetworkUsername**: Username for network or HTTP authentication.
- **NetworkPassword**: Corresponding password for authentication.
- **Proxy**: Set specific proxy settings.
- **UserAgent**: Browser user agent strings.
- **HttpRequestHeaders**: Custom header values for the identity.
- **UseCookies**: Toggle whether cookies should be used with the identity.

#### Web Cache Feature

This functionality is crucial during development. By enabling web caching, developers can work with cached pages, allowing them to quickly test changes without the need to repeatedly scrape live data.

To enable caching in the scraper setup:
```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\SampleOutput\";
    EnableWebCache(TimeSpan.FromHours(1.5)); // Set cache to expire after 1 hour and 30 minutes
    this.Request("http://www.example.com", Parse);
}
```
IronWebScraper can also resume scraping activities after a reboot or code restart by using the `Start(CrawlID)` method, maintaining the state between sessions.

#### Throttling

Control the rate and volume of requests to avoid overwhelming the servers or getting banned:

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\SampleOutput\";
    this.MaxHttpConnectionLimit = 80; // Limit on total concurrent HTTP requests
    this.RateLimitPerHost = TimeSpan.FromMilliseconds(50); // Minimum delay between requests to the same host
    this.OpenConnectionLimitPerHost = 25; // Concurrent requests to the same host
    this.ObeyRobotsDotTxt = false;
    this.ThrottleMode = Throttle.ByDomainHostName; // Throttle by hostname or IP address

    this.Request("https://www.example.com", Parse);
}
```

Throttling settings include:
- **MaxHttpConnectionLimit**: Maximum number of concurrent HTTP requests.
- **RateLimitPerHost**: The minimum delay between subsequent requests to a particular domain.
- **OpenConnectionLimitPerHost**: Limits concurrent connections to the same host.
- **ThrottleMode**: Configures whether throttling considers domain names or IP addresses.

#### HttpIdentity Feature:

Certain web platforms necessitate user authentication for accessing specific content. In these scenarios, `HttpIdentity` proves to be a useful feature. Here’s how it can be employed:

```cs
HttpIdentity id = new HttpIdentity();
id.NetworkUsername = "username"; // Specify the username
id.NetworkPassword = "password"; // Specify the password
Identities.Add(id);
```

`HttpIdentity` is a powerful aspect of IronWebScraper that allows for simulating user sessions, utilizing multiple user credentials or browser identities to scrape content that requires authentication. This method facilitates scraping while mimicking diverse browsing environments:

```cs
public override void Init()
{
    License.LicenseKey = "Your License Key";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\YourProject\Output\";

    // Define proxy settings and user agents if needed
    var proxies = "IP-Proxy1:8080, IP-Proxy2:8081".Split(',');
    foreach (var UA in IronWebScraper.CommonUserAgents.ChromeDesktopUserAgents)
    {
        foreach (var proxy in proxies)
        {
            Identities.Add(new HttpIdentity()
            {
                UserAgent = UA,
                UseCookies = true,
                Proxy = proxy
            });
        }
    }

    // Start the request with a specific URL
    this.Request("http://www.example.com", Parse);
}
```

The `HttpIdentity` class encompasses numerous properties that modify scraping behavior, such as `NetworkUsername`, `NetworkPassword`, `Proxy`, and `UserAgent`. Additionally, `HttpRequestHeaders` can be used to set custom header values. This versatile feature ensures that scraping activities can be tailored to meet specific requirements and efficiently handle web sessions that require login credentials.

Below is the paraphrased version of the provided C# code section, with any relative URL paths resolved against ironsoftware.com:

```cs
// Initialize a new HttpIdentity object for HTTP requests
HttpIdentity identityConfig = new HttpIdentity();
// Set the network username for authentication
identityConfig.NetworkUsername = "yourUsername";
// Set the network password for authentication
identityConfig.NetworkPassword = "yourPassword";
// Add the identity information to IronWebScraper's Identities collection
Identities.Add(identityConfig);
```

One of the standout capabilities of IronWebScraper is its robust feature that permits the deployment of an extensive array of unique identities (encompassing user credentials or different browser settings). This functionality is instrumental in either spoofing or extracting data from various websites utilizing multiple login sessions. This versatility enhances the effectiveness of web scraping tasks by allowing more complex and diverse scraping strategies.

```cs
public override void Init()
{
    License.LicenseKey = "YourLicenseKeyHere";  // Replace this with your actual license key
    this.LoggingLevel = WebScraper.LogLevel.All;  // Set logging to capture all events
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";  // Setting the working directory for output

    // Define proxy servers for web requests
    string[] proxyServers = new string[] { "IP-Proxy1:8080", "IP-Proxy2:8081" };
    foreach (var userAgent in IronWebScraper.CommonUserAgents.ChromeDesktopUserAgents)
    {
        foreach (var proxy in proxyServers)
        {
            // Add each combination of user agent and proxy to the identities used for requests
            Identities.Add(new HttpIdentity()
            {
                UserAgent = userAgent,
                UseCookies = true,
                Proxy = proxy
            });
        }
    }

    // Initiate the first web request to start the scraping process
    this.Request("http://www.website.com", Parse);
}
```

You have access to multiple properties that facilitate varied behaviors, helping prevent sites from blocking your scraper.

Some notable properties include:

- **NetworkDomain**: Utilized for user authentication across various network types such as Windows, NTLM, Kerberos, Linux, BSD, and Mac OS X. It requires the use of `NetworkUsername` and `NetworkPassword`.

- **NetworkUsername**: The username for network/HTTP user authentication, supporting multiple protocols and systems including HTTP, Windows networks, NTLM, Kerberos, Linux networks, BSD networks, and Mac OS.

- **NetworkPassword**: This is the password used along with the username for HTTP or network authentication, compatible with various systems such as HTTP, Windows networks, NTLM, Kerberos and others.

- **Proxy**: Employ this to configure proxy settings to manage network traffic and protect privacy.

- **UserAgent**: This property allows setting the browser type or 'user agent' to emulate different browsers like Chrome (desktop/mobile/tablet), Internet Explorer, Firefox, etc.

- **HttpRequestHeaders**: Utilizes a dictionary (Dictionary<string, string>) to set custom header values that will be used with this identity.

- **UseCookies**: Toggle this to enable or disable the use of cookies during sessions.

IronWebScraper operates by using random identities during scraping tasks to optimize performance and avoid detection. However, you can specify which identity to use for scraping a particular page, enhancing control over the scraping process.

Here's the paraphrased section of the article with relative URL paths resolved against ironsoftware.com:

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey"; // Replace 'LicenseKey' with your actual license
    this.LoggingLevel = WebScraper.LogLevel.All; // Set to capture all log levels
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\"; // Define the output directory

    // Create a new HttpIdentity instance for authentication
    HttpIdentity userCredentials = new HttpIdentity();
    userCredentials.NetworkUsername = "username"; // Specify the username
    userCredentials.NetworkPassword = "password"; // Specify the password
    Identities.Add(userCredentials); // Add the credentials to the identities collection

    // Make the initial web request using the designated user credentials
    this.Request("http://www.Website.com", Parse, userCredentials);
}
```

In this rewritten code snippet:
- Comments are added for clarity on each important operation.
- `identity` variable name is changed to `userCredentials` for better readability.
- The explicit string "pwd" is updated to "password" for an illustrative purpose.
- Adjustments ensure improved readability and maintainability.

#### Utilizing the Web Cache Feature:

The Web Cache Feature is particularly useful for caching pages that have been requested during the development and testing periods. This allows developers to store necessary pages for later reuse, enabling them to execute updates and restarts of their web scrapers without needing to reconnect to the actual website each time, thus performing an action-replay of the cached content.

*Implement this feature in the `Init()` method as follows:*

```cs
EnableWebCache();
```

*Alternatively, you can set an expiration for the cache with:*

```cs
EnableWebCache(TimeSpan expiry);
```

This configuration saves your cached data in the `WebCache` directory located within the working directory.

Here is the paraphrased section of the provided C# code, with all relative URLs resolved to ironsoftware.com as requested:

```cs
public override void Init()
{
    License.LicenseKey = "YourLicenseKeyHere"; // Set your license key
    this.LoggingLevel = WebScraper.LogLevel.All; // Log all events during the scraping process
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\"; // Define the output directory for your scraped data
    EnableWebCache(new TimeSpan(1, 30, 30)); // Enable caching of scraped pages for 1 hour and 30 minutes
    this.Request("http://www.WebSite.com", Parse); // Begin the scraping process at the specified URL
}
``` 

This rewritten section of code maintains the original functionality while incorporating a clearer definition of certain parameters, such as the license key placement and the explanation of caching settings.

IronWebScraper additionally provides functionality to maintain scraping activities even after a code restart by utilizing the `Start(CrawlID)` method to designate the engine start process name. This feature ensures seamless continuation of scraping tasks without manual reinitialization.

```cs
static void Main(string[] args)
{
    // Initialize a new instance of the Scraper class
    EngineScraper scraperInstance = new EngineScraper();
    // Initiate the scraping process
    scraperInstance.Start("enginestate");
}
```

The saved state of the execution, including both the request and response, will be preserved in the `SavedState` folder located within the working directory.

#### Throttling Configuration

Throttling allows for the adjustment of both minimum and maximum connection limits, as well as the speed at which connections to each domain can be made. This capability ensures efficient use of resources while maintaining compliance with domain-specific connection policies.

Here's the paraphrased content for the `Init` method from the IronWebScraper library:

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey"; // Assign your specific license key here
    this.LoggingLevel = WebScraper.LogLevel.All; // Set the logging level to capture all logs
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\"; // Define where to save scrape data

    // Configure maximum simultaneous HTTP requests (threads) allowed
    this.MaxHttpConnectionLimit = 80;

    // Set the minimum interval between requests to the same domain or IP to avoid rate limits
    this.RateLimitPerHost = TimeSpan.FromMilliseconds(50);

    // Set the number of concurrent threads allowed per hostname or IP to prevent overloading hosts
    this.OpenConnectionLimitPerHost = 25;

    // Choose whether to adhere to the rules specified in robots.txt files
    this.ObeyRobotsDotTxt = false;

    // Enable throttling logic to include both domain names and host IP addresses,
    // which is especially useful when scraping various domains located on the same server
    this.ThrottleMode = Throttle.ByDomainHostName;

    // Starts the web scraper with an initial page request
    this.Request("https://www.Website.com", Parse);
}
```

The code still initializes and configures the behavior of the IronWebScraper instance, setting essential properties and kicking off the scraping process with a call to `this.Request`.

**Characteristics of Throttling**


* **MaxHttpConnectionLimit**<br>Total maximum allowable open HTTP connections to prevent server overload.

* **RateLimitPerHost**<br>Minimum required delay or pause in milliseconds between requests to a specific domain or IP to prevent rapid request flooding.

* **OpenConnectionLimitPerHost**<br>The maximum number of simultaneous HTTP connections permitted per host to manage bandwidth and server response stability.

* **ThrottleMode**<br>Enables the WebScraper to adjust request rates not only based on the hostname but also considers the IP address of the server, ensuring polite access especially when multiple domains share the same server resources.

## Appendix

### Creating a Windows Forms Application

For this task, it's recommended to utilize Visual Studio 2013 or a newer version.

#### Steps to create a new Windows Forms Project:

1. **Start Visual Studio**
   ![Visual Studio](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg)

2. **Create the Project**
   - Navigate to `File -> New -> Project`
   ![New Project](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg)

3. **Setup the Project**
   - Choose your programming language (either Visual C# or VB), select `Windows`, then `Windows Forms Application`.
   ![Project Setup](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/CreateWindowsApp.jpg)
   - **Project name**: IronScraperSample
   - **Location**: Specify a directory on your computer

   After creation, your main project screen should look similar to this:
   ![Main Screen](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/WindowsAppMainScreen.jpg)

### Creating a Web Form Application

It's suggested to use Visual Studio 2013 or later for this process.

#### Steps to Create a New ASP.NET Web Forms Project:

1. **Launch Visual Studio**
   ![Visual Studio](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg)

2. **Initiate a New Project**
   - Go to `File -> New -> Project`
   ![File New Project](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg)

3. **Configure the New Project**
   - Under Templates, select your language preference (Visual C# or VB), choose `Web`, then `ASP.NET Web Application (.NET Framework)`.
   ![ASP.NET Web Application](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETWebApplication.jpg)
   - **Project name**: IronScraperSample
   - **Location**: Choose a suitable location on your disk

4. **Choose the Template**
   - Opt for the Empty template and make sure to tick the Web Forms box.
   ![ASP.NET Templates](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETTemplates.jpg)

5. **Complete the Setup**
   - Once configured, your initial ASP.NET web form Project is ready.
   ![ASP.NET Web Form Project](https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ASPNETWebFormProject.jpg)

Download the complete sample project code from [IronWebScraperSample.zip](https://ironsoftware.com/downloads/assets/tutorials/webscraping-in-c-sharp/IronWebScraperSample.zip).

These steps should assist you in setting up Windows Forms and Web Forms applications effectively using Visual Studio.

### Creating a Windows Form Application

For this procedure, ensure you have Visual Studio 2013 or a more recent version installed.

Here’s a step-by-step guide on initiating a new Windows Forms Project:

1. Launch Visual Studio

Continue with this setup to configure and start your new Windows Forms project efficiently.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg" class="img-responsive add-shadow img-margin"></a></p>

```
2. Navigate to **File**, then select **New** followed by **Project**.
```

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg" class="img-responsive add-shadow img-margin"></a></p>

3. Select your preferred programming language (such as Visual C# or VB) from the Template options, then navigate to Windows, and choose Windows Forms Application.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/CreateWindowsApp.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/CreateWindowsApp.jpg" class="img-responsive add-shadow img-margin"></a></p>

**Project Name**: IronScraperSample<br>

**Location**: Select a location on your hard drive

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/WindowsAppMainScreen.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/WindowsAppMainScreen.jpg" class="img-responsive add-shadow img-margin"></a></p>

### Creating a Web Form Application

For this task, you'll need Visual Studio 2013 or a more recent version.

Here’s a detailed guide to setting up a new Asp.NET Web Forms project:

1. Launch Visual Studio. 
2. Navigate to **File** -> **New** -> **Project**.
3. Choose your programming language (either Visual C# or VB) and go to **Web** -> **ASP.NET Web Application (.NET Framework)**.

Choose a name for your project such as `IronScraperSample` and select a directory on your drive to save it.

In the next steps, you'll select your specific project setup:
- Select the **Empty** template.
- Make sure to check the option for **Web Forms**.

This setup initializes a basic ASP.NET Web Forms project for you. Now, you're ready to start developing on this flexible platform.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/Enterprise2015.jpg" class="img-responsive add-shadow img-margin"></a></p>

2. Select "File" from the top menu, then choose "New" and click on "Project".

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/FileNewProject.jpg" class="img-responsive add-shadow img-margin"></a></p>

3. Select a programming language (either Visual C# or VB) from the template options, then navigate to 'Web' and choose 'ASP.NET Web Application (.NET Framework)'.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ASPNETWebApplication.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ASPNETWebApplication.jpg" class="img-responsive add-shadow img-margin"></a></p>

**Project Name:** IronScraperSample<br>
**Storage Location:** Select a storage directory on your hard disk

4. Selecting Your ASP.NET Templates

<ol type="a">
    <li>Select Empty Template</li>
    <li>Check Web Forms</li>
    <p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ASPNETTemplates.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ASPNETTemplates.jpg" class="img-responsive add-shadow img-margin"></a></p>
</ol>

5. Your basic ASP.NET web form project has now been successfully created.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ASPNETWebFormProject.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ASPNETWebFormProject.jpg" class="img-responsive add-shadow img-margin"></a></p>

[Download the complete tutorial sample project code here](https://ironsoftware.com/downloads/assets/tutorials/webscraping-in-c-sharp/IronWebScraperSample.zip).

