using System;
using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
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
                // Create a new instance of HttpIdentity
                HttpIdentity id = new HttpIdentity();

                // Set the network username and password for authentication
                id.NetworkUsername = "username";
                id.NetworkPassword = "pwd";

                // Add the identity to the collection of identities
                Identities.Add(id);
            }

            public override void Parse(Response response) { }
        }
    }
}
