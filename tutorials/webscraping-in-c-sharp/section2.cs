using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharp
{
    public static class Section2
    {
        public static void Run()
        {
            public override void Init()
            {
                License.LicenseKey = "LicenseKey";
                this.LoggingLevel = WebScraper.LogLevel.All;
                this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
                EnableWebCache();
                this.Request("http://www.WebSite.com", Parse);
            }
        }
    }
}