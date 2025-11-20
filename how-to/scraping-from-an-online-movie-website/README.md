# Scraping an Online Movie Website

***Based on <https://ironsoftware.com/how-to/scraping-from-an-online-movie-website/>***


Let’s embark on another practical example from a real-world context. In this instance, we'll opt to scrape a movie website.

First, we'll create a new class named `MovieScraper`:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScraperAddClass.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScraperAddClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

Next, let's review the site we intend to scrape:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/123movies.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/123movies.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's a snippet of the homepage HTML from the website:

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

This structure includes a movie ID, title, and a clickable link to a detailed page.

Let's initiate the data scraping process:

```csharp
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        // Set up initial scraper settings
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        
        // Begin by requesting home page content for scraping
        this.Request("www.website.com", Parse);
    }
    
    public override void Parse(Response response)
    {
        // Loop through every movie div within the featured movie section
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.Attributes["class"] != "clearfix")
            {
                var movieId = Convert.ToInt32(div.GetAttribute("data-movie-id"));
                var link = div.Css("a")[0];
                var movieTitle = link.TextContentClean;
                
                // Collect movie data into key-value pairs and store
                Scrape(new ScrapedData() 
                { 
                    { "MovieId", movieId }, 
                    { "MovieTitle", movieTitle }
                }, "Movie.Jsonl");
            }
        }           
    }
}
```

*Key Updates in this code:*

The Working Directory property is now configured to designate the main directory for all scraped data and related files.

*Expanding our scope:*

What if our project requires building typed objects to hold and organize our scraped data more formally?

Let's define a `Movie` class to store our formatted data:

```csharp
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string URL { get; set; }
}
```

Subsequent updates to our scraping code will include:

```csharp
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        // Set scraper configurations
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";

        // Start by requesting the homepage content
        this.Request("https://website.com/", Parse);
    }
    
    public override void Parse(Response response)
    {
        // Process each movie div within the featured section
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.Attributes["class"] != "clearfix")
            {
                var movie = new Movie
                {
                    Id = Convert.ToInt32(div.GetAttribute("data-movie-id"))
                };

                var link = div.Css("a")[0];
                movie.Title = link.TextContentClean;
                movie.URL = link.Attributes["href"];

                // Initiate scraping of movie details
                Scrape(movie, "Movie.Jsonl");
            }
        }
    }
}
```

*Key New Integrations:*
1. Implementation of a `Movie` class to neatly structure our scraped data.
2. The `Scrape` method now accepts movie objects, which facilitates structured data storage as illustrated below:
<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass.jpg" class="img-responsive add-shadow img-margin"></a></p>