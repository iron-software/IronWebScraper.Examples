using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section2
    {
        public static void Run()
        {
            public override void Init()
            {
                License.LicenseKey = " LicenseKey ";
                this.LoggingLevel = WebScraper.LogLevel.All;
                this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
                var proxies = "IP-Proxy1: 8080,IP-Proxy2: 8081".Split(',');
                foreach (var UA in IronWebScraper.CommonUserAgents.ChromeDesktopUserAgents)
                {
                    foreach (var proxy in proxies)
                    {
                        Identities.Add(new HttpIdentity()
                        {
                            UserAgent = UA,
                            UseCookies = true,
                            Proxy = proxy
                        });
                    }
                }
                this.Request("http://www.Website.com", Parse);
            }
        }
    }
}