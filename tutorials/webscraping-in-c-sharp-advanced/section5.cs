using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section5
    {
        public static void Run()
        {
            public override void Init()
            {
                License.LicenseKey = "LicenseKey";
                this.LoggingLevel = WebScraper.LogLevel.All;
                this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
                // Gets or sets the total number of allowed open HTTP requests (threads)
                this.MaxHttpConnectionLimit = 80;
                // Gets or sets minimum polite delay (pause)between request to a given domain or IP address.
                this.RateLimitPerHost = TimeSpan.FromMilliseconds(50);            
                //     Gets or sets the allowed number of concurrent HTTP requests (threads) per hostname
                //     or IP address. This helps protect hosts against too many requests.
                this.OpenConnectionLimitPerHost = 25;
                this.ObeyRobotsDotTxt = false;
                //     Makes the WebSraper intelligently throttle requests not only by hostname, but
                //     also by host servers' IP addresses. This is polite in-case multiple scraped domains
                //     are hosted on the same machine.
                this.ThrottleMode = Throttle.ByDomainHostName;
                this.Request("https://www.Website.com", Parse);
            }
        }
    }
}