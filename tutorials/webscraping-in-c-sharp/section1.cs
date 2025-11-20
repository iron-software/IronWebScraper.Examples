using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharp
{
    public static class Section1
    {
        public static void Run()
        {
            HttpIdentity id = new HttpIdentity
            {
                NetworkUsername = "username",
                NetworkPassword = "pwd"
            };
            Identities.Add(id);
        }
    }
}