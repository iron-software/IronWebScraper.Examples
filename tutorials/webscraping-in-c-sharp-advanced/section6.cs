using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section6
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
            
                // Set the total number of allowed open HTTP requests (threads)
                this.MaxHttpConnectionLimit = 80;
                
                // Set minimum polite delay (pause) between requests to a given domain or IP address
                this.RateLimitPerHost = TimeSpan.FromMilliseconds(50);
                
                // Set the allowed number of concurrent HTTP requests (threads) per hostname or IP address
                this.OpenConnectionLimitPerHost = 25;
                
                // Do not obey the robots.txt files
                this.ObeyRobotsDotTxt = false;
                
                // Makes the WebScraper intelligently throttle requests not only by hostname, but also by host servers' IP addresses
                this.ThrottleMode = Throttle.ByDomainHostName;
                
                // Make an initial request to the website with a parse method
                this.Request("https://www.Website.com", Parse);
            }
        }
    }
}