using System;
using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharp
{
    public static class Section1
    {
        public static void Run()
        {
            // Identities belongs to WebScraper, so the snippet is shown on a scraper class.
            var scraper = new IdentityScraper();
        }

        private class IdentityScraper : WebScraper
        {
            public override void Init()
            {
                HttpIdentity id = new HttpIdentity
                {
                    NetworkUsername = "username",
                    NetworkPassword = "pwd"
                };
                Identities.Add(id);
            }

            public override void Parse(Response response) { }
        }
    }
}
