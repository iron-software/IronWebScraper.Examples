using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section5
    {
        public static void Run()
        {
            public override void Init()
            {
                // Set the license key for IronWebScraper
                License.LicenseKey = "LicenseKey";
            
                // Set the logging level to capture all logs
                this.LoggingLevel = WebScraper.LogLevel.All;
            
                // Assign the working directory for the output files
                this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
            
                // Enable web cache with a specific expiration time of 1 hour, 30 minutes, and 30 seconds
                EnableWebCache(new TimeSpan(1, 30, 30));
                
                // Make an initial request to the website with a parse method
                this.Request("http://www.Website.com", Parse);
            }
        }
    }
}