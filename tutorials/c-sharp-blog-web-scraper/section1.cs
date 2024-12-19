using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.CSharpBlogWebScraper
{
    public static class Section1
    {
        public static void Run()
        {
            /// <summary>
            /// Override this method to create the default Response handler for your web scraper.
            /// If you have multiple page types, you can add additional similar methods.
            /// </summary>
            /// <param name="response">The http Response object to parse</param>
            public override void Parse(Response response)
            {
                foreach (var link in response.Css("div.section-nav > ul > li > a "))
                {
                    switch(link.TextContentClean)
                    {
                        case "Reviews":
                            {
            
                            }break;
                        case "Science":
                            {
            
                            }break;
                        default:
                            {
                                // Save Result to File
                                Scrape(new ScrapedData() { { "Title", link.TextContentClean } }, "BlogScraper.Jsonl");
                            }
                            break;
                    }
                }
            }
        }
    }
}