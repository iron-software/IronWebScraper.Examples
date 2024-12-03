***Based on <https://ironsoftware.com/tutorials/c-sharp-blog-web-scraper/>***

## How to Extract Content from a Blog Using C#

Explore the capabilities of Iron WebScraper by extracting content from a WordPress blog or a similar platform using C# or VB.NET.

This guide takes you through the process of using .NET to capture content from a blog.

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FireShotScreenCaptureGizmodo.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/FireShotScreenCaptureGizmodo.jpg" class="img-responsive add-shadow img-margin"></a></p>

```cs
public class BlogScraper : WebScraper
{
    /// <summary>
    /// This method sets up your web-scraper. Key tasks include setting the initial URL and defining allowed or banned domains and URL patterns.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = " LicenseKey ";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\BlogSample\Output\";
        EnableWebCache(new TimeSpan(1, 30, 30)); // Enable caching to save web pages locally
        this.Request("http://blogSite.com/", Parse); // Initial URL request
    }
}
```

In this tutorial, we begin by deriving `BlogScraper` from the `WebScraper` class.

We designate a directory at `"\BlogSample\Output\"` to store all output and cache files.

We then turn on the web cache to store pages locally in the "WebCache" folder.

Next, we set up a parsing function:

```cs
/// <summary>
/// This method handles parsing of the http Response to capture necessary data.
/// You may introduce additional methods for handling different types of pages.
/// </summary>
/// <param name="response">The http Response to parse</param>
public override void Parse(Response response)
{
    foreach (var link in response.Css("div.section-nav > ul > li > a "))
    {
        switch(link.TextContentClean)
        {
            case "Reviews":
                // Add handling for "Reviews" category
                break;
            case "Science":
                // Add handling for "Science" category
                break;
            default:
                {
                    // Generic parsing and saving
                    Scrape(new ScrapedData() { { "Title", link.TextContentClean } }, "BlogScraper.Jsonl");
                }
                break;
        }
    }
}
```

In the `Parse` method, we extract links to categories like Movies, Science, Reviews, etc., and switch to the appropriate parsing function based on the category link.

Let’s structure our data model for the Science category:

```cs
/// <summary>
/// Represents data model for Science-related content.
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

Following the data model setup, we implement the scraping of a specific page:

```cs
/// <summary>
/// Parses content specifically from review pages, collecting various details.
/// </summary>
/// <param name="response">The http response from the review page.</param>
public void ParseReviews(Response response)
{
    var scienceList = new List<ScienceModel>(); // Collection of science articles

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

    Scrape(scienceList, "BlogScience.Jsonl"); // Save data to file
}
```

After defining our model and implementing the page scrape, we can parse and extract visible elements such as title, author, date, image, and text, then save the data in a separate file using `Scrape(object, fileName)`.

[Read more about using IronWebscraper in the full tutorial by Ahmed](https://ironsoftware.com/webscraping-in-c-sharp/)

<div class="article-img tutorial-img">
	<img src="https://ironsoftware.com/img/tutorials/c-sharp-blog-web-scraper/banner.jpg" alt="Webscraping was never an easy task, with no leading frameworks in the C# or .NET environments. Iron Web Scraper was developed to transform this scenario" class="img-responsive">
</div>