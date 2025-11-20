using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.CSharpBlogWebScraper
{
    public static class Section1
    {
        public static void Run()
        {
            /// <summary>
            /// Override this method to handle the Http Response for your web scraper.
            /// Add additional methods if you handle multiple page types.
            /// </summary>
            /// <param name="response">The HTTP Response object to parse.</param>
            public override void Parse(Response response)
            {
                // Iterate over each link found in the section navigation
                foreach (var link in response.Css("div.section-nav > ul > li > a"))
                {
                    switch(link.TextContentClean)
                    {
                        case "Reviews":
                            {
                                // Handle reviews case
                            }
                            break;
                        case "Science":
                            {
                                // Handle science case
                            }
                            break;
                        default:
                            {
                                // Save the link title to a file
                                Scrape(new ScrapedData() { { "Title", link.TextContentClean } }, "BlogScraper.Jsonl");
                            }
                            break;
                    }
                }
            }
        }
    }
}