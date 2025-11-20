using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section4
    {
        public static void Run()
        {
            // Enable web cache without an expiration time
            EnableWebCache();
            
            // OR enable web cache with a specified expiration time
            EnableWebCache(new TimeSpan(1, 30, 30));
        }
    }
}