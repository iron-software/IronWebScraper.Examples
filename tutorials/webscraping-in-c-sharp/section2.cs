using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharp
{
    public static class Section2
    {
        public static void Run()
        {
            HttpIdentity id = new HttpIdentity();
            id.NetworkUsername = "username";
            id.NetworkPassword = "pwd";
            Identities.Add(id);
        }
    }
}