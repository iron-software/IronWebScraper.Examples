using IronWebScraper;
namespace IronWebScraper.Examples.GettingStarted.LicenseKeys
{
    public static class Section1
    {
        public static void Run()
        {
            // Set the license key for IronWebScraper at the startup of your application.
            IronWebScraper.License.LicenseKey = "IRONSCRAPER-MYLICENSE-KEY-1EF01";
        }
    }
}