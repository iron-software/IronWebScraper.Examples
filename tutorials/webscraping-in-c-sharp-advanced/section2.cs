using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section2
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
            
                // Define an array of proxies
                var proxies = "IP-Proxy1:8080,IP-Proxy2:8081".Split(',');
            
                // Iterate over common Chrome desktop user agents
                foreach (var UA in IronWebScraper.CommonUserAgents.ChromeDesktopUserAgents)
                {
                    // Iterate over the proxies
                    foreach (var proxy in proxies)
                    {
                        // Add a new HTTP identity with specific user agent and proxy
                        Identities.Add(new HttpIdentity()
                        {
                            UserAgent = UA,
                            UseCookies = true,
                            Proxy = proxy
                        });
                    }
                }
                
                // Make an initial request to the website with a parse method
                this.Request("http://www.Website.com", Parse);
            }
        }
    }
}