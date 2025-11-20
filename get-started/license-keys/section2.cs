using IronWebScraper;
namespace IronWebScraper.Examples.GettingStarted.LicenseKeys
{
    public static class Section2
    {
        public static void Run()
        {
            // Test if the IronWebScraper license key is valid.
            bool result = IronWebScraper.License.IsValidLicense("IRONWEBSCRAPER-MYLICENSE-KEY-1EF01");
        }
    }
}