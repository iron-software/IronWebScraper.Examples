using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section3
    {
        public static void Run()
        {
            public override void Init()
            {
                License.LicenseKey = " LicenseKey ";
                this.LoggingLevel = WebScraper.LogLevel.All;
                this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
                HttpIdentity identity = new HttpIdentity();
                identity.NetworkUsername = "username";
                identity.NetworkPassword = "pwd";
                Identities.Add(id);
                this.Request("http://www.Website.com", Parse, identity);
            }
        }
    }
}