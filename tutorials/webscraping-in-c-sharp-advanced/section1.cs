using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section1
    {
        public static void Run()
        {
            // Create a new instance of HttpIdentity
            HttpIdentity id = new HttpIdentity();
            
            // Set the network username and password for authentication
            id.NetworkUsername = "username";
            id.NetworkPassword = "pwd";
            
            // Add the identity to the collection of identities
            Identities.Add(id);
        }
    }
}