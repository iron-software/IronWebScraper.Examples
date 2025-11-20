using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharp
{
    public static class Section3
    {
        public static void Run()
        {
            public override void Init()
            {
                License.LicenseKey = "LicenseKey";
                this.LoggingLevel = WebScraper.LogLevel.All;
                this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
                this.MaxHttpConnectionLimit = 80;
                this.RateLimitPerHost = TimeSpan.FromMilliseconds(50);
                this.OpenConnectionLimitPerHost = 25;
                this.ObeyRobotsDotTxt = false;
                this.ThrottleMode = Throttle.ByDomainHostName;
                this.Request("https://www.Website.com", Parse);
            }
        }
    }
}