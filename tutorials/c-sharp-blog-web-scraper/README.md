# How to Extract Content from a Blog Using C&#35;

***Based on <https://ironsoftware.com/tutorials/c-sharp-blog-web-scraper/>***


Explore the functionality of Iron WebScraper for harvesting content from a blog designed in WordPress or similar platforms using C# or VB.NET.

This guide demonstrates the extraction process utilizing .NET

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FireShotScreenCaptureGizmodo.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FireShotScreenCaptureGizmodo.jpg" class="img-responsive add-shadow img-margin"></a></p>

```csharp
// Create a class that inherits from IronWebScraper's WebScraper class
public class BlogScraper : WebScraper
{
    /// <summary>
    /// Override to instantiate your web-scraper.
    /// Set the initial URL and define URL or domain patterns for scraping.
    /// </summary>
    public override void Init()
    {
        // Apply your IronWebScraper license key
        License.LicenseKey = "YourLicenseKey";
        
        // Activate logging for tracing actions
        this.LoggingLevel = WebScraper.LogLevel.All;
        
        // Configure the directory for saving output and caching
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\BlogSample\Output\";
        
        // Set caching with a specified duration
        EnableWebCache(new TimeSpan(1, 30, 30));
        
        // Begin with an initial URL request and define the handler method for the response
        this.Request("http://blogSite.com/", Parse);
    }
}
```

In this example, we initiate a "BlogScraper" deriving from the `WebScraper` class.

We configure the software to use a directory at “\BlogSample\Output\” for storing all outputs and caching.

After activating the cache, let's outline how to parse content:

```csharp
/// <summary>
/// Method to handle the Http Response, designed for custom scraping logic.
/// Define additional methods for various content types.
/// </summary>
/// <param name="response">The HTTP Response object to process.</param>
public override void Parse(Response response)
{
    // Process each hyperlink found within the navigation section
    foreach (var link in response.Css("div.section-nav > ul > li > a"))
    {
        switch(link.TextContentClean)
        {
            case "Reviews":
                {
                    // Process review-related content
                }
                break;
            case "Science":
                {
                    // Process science-related content
                }
                break;
            default:
                {
                    // Record the link's title into a file
                    Scrape(new ScrapedData() { { "Title", link.TextContentClean } }, "BlogScraper.Jsonl");
                }
                break;
        }
    }
}
```

The `Parse` method acts by capturing hyperlinks from the top navigation and dispatching them to appropriate handlers based on the category.

Next, define a data model for the Science segment:

```csharp
/// <summary>
/// Data model representing details from a Science page
/// </summary>
public class ScienceModel
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Date { get; set; }
    public string Image { get; set; }
    public string Text { get; set; }
}
```

Implementing the scraping of a single page, particularly "Reviews":

```csharp
/// <summary>
/// Extracts reviews based on the document structure.
/// </summary>
/// <param name="response">The HTTP Response to use.</param>
public void ParseReviews(Response response)
{
    var scienceList = new List<ScienceModel>();

    foreach (var postBox in response.Css("section.main > div > div.post-list"))
    {
        var item = new ScienceModel
        {
            Title = postBox.Css("h1.headline > a")[0].TextContentClean,
            Author = postBox.Css("div.author > a")[0].TextContentClean,
            Date = postBox.Css("div.time > a")[0].TextContentClean,
            Image = postBox.Css("div.image-wrapper.default-state > img")[0].Attributes["src"],
            Text = postBox.Css("div.summary > p")[0].TextContentClean
        };

        scienceList.Add(item);
    }

    // Store the accumulated data into a JSONL file
    Scrape(scienceList, "BlogScience.Jsonl");
}
```

Each "Review" page is parsed to gather necessary details, which are then compiled into a model and saved.

[Access the complete tutorial on how to utilize IronWebscraper](https://ironsoftware.com/webscraping-in-c-sharp/)

### Start Using IronWebscraper Now

<div class="article-img tutorial-img">
    <img src="https://ironsoftware.com/img/tutorials/c-sharp-blog-web-scraper/banner.jpg" alt="Webscraping has never been a simple task, with no dominant frameworks for use in C# or .NET programming environments. Iron Web Scraper was created to change this" class="img-responsive">
</div>