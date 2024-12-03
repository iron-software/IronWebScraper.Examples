# Scraping a Film Database Online

***Based on <https://ironsoftware.com/how-to/scraping-from-an-online-movie-website/>***


We are embarking on a practical example of web scraping, focusing on a film-oriented website.

First, we create a class called `MovieScraper`. Here's the class being added:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/MovieScrapaerAddClass.jpg" class="img-responsive add-shadow img-margin"></a></p>

Next, we inspect the target website:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/123movies.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/123movies.jpg" class="img-responsive add-shadow img-margin"></a></p>

Below is a snippet of the homepage's HTML:

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
    <!-- Additional movie items go here -->
</div>
```
Here we find key elements such as the Movie ID, Title, and Direct Link to the Detailed Page.

To commence data extraction:

```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "YourLicenseKeyHere";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("www.website.com", Parse);
    }
    public override void Parse(Response response)
    {
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.Attributes ["class"] != "clearfix")
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

**Enhancements in the Code:**

- The `WorkingDirectory` property sets the primary directory for all scraped data and associated files.

Continuing to evolve:

Why not create typed objects that encapsulate scraped data?

```cs
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string URL { get; set; }
}
```

Code update with typed data handling:
```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "YourLicenseKeyHere";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("https://website.com/", Parse);
    }
    public override void Parse(Response response)
    {
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.Attributes ["class"] != "clearfix")
            {
                var movie = new Movie();
                movie.Id = Convert.ToInt32(div.GetAttribute("data-movie-id"));
                var link = div.Css("a")[0];
                movie.Title = link.TextContentClean;
                movie.URL = link.Attributes ["href"];
                Scrape(movie, "Movie.Jsonl");
            }
        }
    }
}
```

**What's New?**
1. Introduction of a `Movie` class to encapsulate scraped data.
2. Passing movie objects to the `Scrape` method which automates saving in a pre-defined format: 

Further enhancement:

Let's now focus on scraping more detailed pages from individual movie entries. Here's a view of such a movie page:

The detailed movie page appears as follows:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/movieDetailsSample.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/movieDetailsSample.jpg" class="img-responsive add-shadow img-margin"></a></p>

Addition of properties (Description, Genre, Actors) to our `Movie` class for a complete embrace of movie details:

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

Using IronWebScraper's features to extend the scraping to detailed pages:

```cs
public class MovieScraper : WebScraper
{
    public override void Init()
    {
        License.LicenseKey = "YourLicenseKeyHere";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\MovieSample\Output\";
        this.Request("https://domain/", Parse);
    }
    public override Parse(Response response)
    {
        foreach (var div in response.Css("#movie-featured > div"))
        {
            if (div.Attributes ["class"] != "clearfix")
            {
                var movie = new Movie();
                movie.Id = Convert.ToInt32(div.GetAttribute("data-movie-id"));
                var link = div.Css("a")[0];
                movie.Title = link.TextContentClean;
                movie.URL = link.Attributes ["href"];
                this.Request(movie.URL, ParseDetails, new MetaData() { { "movie", movie } });
            }
        }           
    }
    public void ParseDetails(Response response)
    {
        var movie = response.MetaData.Get<Movie>("movie");
        var div = response.Css("div.mvic-desc")[0];
        movie.Description = div.Css("div.desc")[0].TextContentClean;
        movie.Genre = new List<string>();
        movie.Actor = new List<string>();
        foreach(var genre in div.Css("div > p > a"))
        {
            movie.Genre.Add(genre.TextContentClean);
        }
        foreach (var actor in div.Css("div > p:nth-child(2) > a"))
        {