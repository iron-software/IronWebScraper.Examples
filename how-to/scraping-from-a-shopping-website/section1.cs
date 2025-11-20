using IronWebScraper;
namespace IronWebScraper.Examples.HowTo.ScrapingFromAShoppingWebsite
{
    public static class Section1
    {
        public static void Run()
        {
            public override void Parse(Response response)
            {
                // List of Category Links (Root)
                var categoryList = new List<Category>();
            
                // Traverse each 'li' under the fixed menu
                foreach (var li in response.Css("#menuFixed > ul > li"))
                {
                    // List of Main Links
                    foreach (var Links in li.Css("a"))
                    {
                        var cat = new Category
                        {
                            URL = Links.Attributes["href"],
                            Name = Links.InnerText,
                            SubCategories = new List<Category>()
                        };
            
                        // List of Subcategories Links
                        foreach (var subCategory in li.Css("a[class=subcategory]"))
                        {
                            var subcat = new Category
                            {
                                URL = subCategory.Attributes["href"],
                                Name = subCategory.InnerText
                            };
            
                            // Check if subcategory link already exists
                            if (cat.SubCategories.Find(c => c.Name == subcat.Name && c.URL == subcat.URL) == null)
                            {
                                // Add sublinks
                                cat.SubCategories.Add(subcat);
                            }
                        }
                        
                        // Add Main Category to the list
                        categoryList.Add(cat);
                    }
                }
            
                // Save the scraped data into a JSONL file.
                Scrape(categoryList, "Shopping.jsonl");
            }
        }
    }
}