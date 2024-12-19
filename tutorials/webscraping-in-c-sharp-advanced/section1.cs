using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharpAdvanced
{
    public static class Section1
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