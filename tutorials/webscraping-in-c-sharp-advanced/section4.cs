using System;
using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section4
    {
        public static void Run()
        {
            // EnableWebCache is a WebScraper method, so the snippet is shown on a scraper class.
            var scraper = new CachingScraper();
        }

        private class CachingScraper : WebScraper
        {
            public override void Init()
            {
                // Enable web cache without an expiration time
                EnableWebCache();

                // OR enable web cache with a specified expiration time
                EnableWebCache(new TimeSpan(1, 30, 30));
            }

            public override void Parse(Response response) { }
        }
    }
}
