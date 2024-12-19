using IronWebScraper;
namespace IronWebScraper.Examples.Tutorial.WebscrapingInCSharp
{
    public static class Section1
    {
        public static void Run()
        {
            public override void Parse(Response response)
            {
                // List of Categories Links (Root)
                var categoryList = new List<Category>();
                
                foreach (var li in response.Css("#menuFixed > ul > li"))
                {
                    // List Of Main Links
                    foreach (var Links in li.Css("a"))
                    {
                        var cat = new Category();
                        cat.URL = Links.Attributes ["href"];
                        cat.Name = Links.InnerText;
                        cat.SubCategories = new List<Category>();
                        // List of Sub Catgories Links
                        foreach (var subCategory in li.Css("a [class=subcategory]"))
                        {
                            var subcat = new Category();
                            subcat.URL = Links.Attributes ["href"];
                            subcat.Name = Links.InnerText;
                            // Check If Link Exist Before 
                            if (cat.SubCategories.Find(c=>c.Name== subcat.Name && c.URL == subcat.URL) == null)
                            {
                                // Add Sublinks
                                cat.SubCategories.Add(subcat);
                            }
                        }
                        // Add Categories
                        categoryList.Add(cat);
                    }
                }
                Scrape(categoryList, "Shopping.Jsonl");
            }
        }
    }
}