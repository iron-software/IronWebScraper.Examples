# Extracting Data from an Online Movie Website

***Based on <https://ironsoftware.com/how-to/scraping-from-an-online-movie-website/>***


Embarking on a practical example, let's extract data from a movie-related website.

First, we'll create a new `C#` class called `MovieScraper`:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScraperAddClass.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScraperAddClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

Next, let's examine the website we'll be scraping:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/123movies.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/123movies.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's a snippet of the HTML from the homepage:
```html
<div id="movie-featured" class="movies-list movies-list-full tab-pane in fade active">
    <!-- Snippet reduced for brevity -->
</div>
```
This HTML contains movie IDs, titles, and links to more detailed pages.

Time to start extracting this dataset:
```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("https://website.com", Parse);
    }
    public override void Parse(Response response)
    {
        foreach (var Divs in response.Css("#movie-featured > div"))
        {
            if (Divs.Attributes["class"] != "clearfix")
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

**New Enhancements:**

- `Working Directory` property sets up the directory for all scraped outputs.

Want to encapsulate scraped data in properly formatted objects?

Implement a `Movie` class like so:
```cs
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string URL { get; set; }
}
```

Update our scraping class:
```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("https://website.com/", Parse);
    }
    public override void Parse(Response response)
    {
        foreach (var Divs in response.Css("#movie-featured > div"))
        {
            if (Divs.Attributes["class"] != "clearfix")
            {
                var movie = new Movie();
                movie.Id = Convert.ToInt32(Divs.GetAttribute("data-movie-id"));
                var link = Divs.Css("a")[0];
                movie.Title = link.TextContentClean;
                movie.URL = link.Attributes["href"];
                Scrape(movie, "Movie.Jsonl");
            }
        }
    }
}
```

**What’s new here?**
1. Data is encapsulated in a `Movie` class.
2. Data is saved in a standardized format.

Explore detailed pages for more comprehensive data scraping:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/movieDetailsSample.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/movieDetailsSample.jpg" class="img-responsive add-shadow img-margin"></a></p>

Add attributes like Description, Genre, and Actors to our class:
```cs
public class Movie
{
    // Basic properties already mentioned earlier with added ones
    public string Description { get; set; }
    public List<string> Genre { get; set; }
    public List<string> Actor { get; set; }
}
```

We can enhance the `MovieScraper` class further to scrape different types of page formats:

```cs
public class MovieScraper : WebScraper
{
    // Initialization and simple parsing functions as before
    public void ParseDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("movie");
        var Div = response.Css("div.mvic-desc")[0];
        movie.Description = Div.Css("div.desc")[0].TextContentClean;
        foreach (var Genre in Div.Css("div > p > a"))
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

**Recent Improvements:**
- Added detailed page scraping functionality.
- Employed `MetaData` feature to pass movie objects between functions.
- Produced and saved enriched movie data.

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass1.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieResultMovieClass1.jpg" class="img-responsive add-shadow img-margin"></a></p>