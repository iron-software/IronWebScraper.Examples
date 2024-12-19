using IronWebScraper;
namespace IronWebScraper.Examples.HowTo.LicenseKeys
{
    public static class Section2
    {
        public static void Run()
        {
            bool result = IronWebScraper.License.IsValidLicense("IRONWEBSCRAPER-MYLICENSE-KEY-1EF01");
        }
    }
}