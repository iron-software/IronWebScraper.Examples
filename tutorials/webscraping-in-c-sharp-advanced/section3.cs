using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section3
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
            
                // Create a new instance of HttpIdentity
                HttpIdentity identity = new HttpIdentity();
                
                // Set the network username and password for authentication
                identity.NetworkUsername = "username";
                identity.NetworkPassword = "pwd";
                
                // Add the identity to the collection of identities
                Identities.Add(identity);
                
                // Make a request to the website with the specified identity
                this.Request("http://www.Website.com", Parse, identity);
            }
        }
    }
}