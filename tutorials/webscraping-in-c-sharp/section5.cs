using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharp
{
    public static class Section5
    {
        public static void Run()
        {
            public override void Init()
            {
                License.LicenseKey = " LicenseKey ";
                this.LoggingLevel = WebScraper.LogLevel.All;
                this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
                EnableWebCache(new TimeSpan(1,30,30));
                this.Request("http://www.WebSite.com", Parse);
            }
        }
    }
}