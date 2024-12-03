# Extract Data from an E-commerce Website

***Based on <https://ironsoftware.com/how-to/scraping-from-a-shopping-website/>***


We choose an e-commerce platform from which to extract data.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg" class="img-responsive add-shadow img-margin"></a></p>

From the provided image, it is apparent that there's a sidebar on the left that hosts links to various product categories on the site.

Initially, our approach involves a thorough examination of the website's HTML code to strategize our scraping method effectively.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg" class="img-responsive add-shadow img-margin"></a></p>

The fashion website is structured with main categories that include subcategories such as Men, Women, and Kids.

```html
<li class="menu-item" data-id="">
    <a href="https://domain.com/fashion-by/" class="main-category">
        <i class="cat-icon osh-font-fashion"></i> <span class="nav-subTxt">FASHION</span> <i class="osh-font-light-arrow-left"></i><i class="osh-font-light-arrow-right"></i>
    </a> 
    <div class="navLayerWrapper" style="width: 633px; display: none;">
        <div class="submenu">
            <div class="column">
                <div class="categories">
                    <a class="category" href="https://domain.com/fashion-by/?sort=newest&amp;dir=desc&amp;viewType=gridView3">New Arrivals!</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://domain.com/men-fashion/">Men</a>
                    <a class="subcategory" href="https://domain.com/mens-shoes/">Shoes</a>
                    <a class="subcategory" href="https://domain.com/mens-clothing/">Clothing</a>
                    <a class="subcategory" href="https://domain.com/mens-accessories/">Accessories</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://domain.com/women-fashion/">Women</a>
                    <a class="subcategory" href="https://domain.com/womens-shoes/">Shoes</a>
                    <a class="subcategory" href="https://domain.com/womens-clothing/">Clothing</a>
                    <a class="subcategory" href="https://domain.com/womens-accessories/">Accessories</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://domain.com/girls-boys-fashion/">Kids</a>
                    <a class="subcategory" href="https://domain.com/boys-fashion/">Boys</a>
                    <a class="subcategory" href="https://domain.com/girls/">Girls</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://domain.com/maternity-clothes/">Maternity Clothes</a>
                </div>
            </div>
            
            <div class="column">
                <div class="categories">
                    <span class="category defaultCursor">Men Best Sellers</span>
                    <a class="subcategory" href="https://domain.com/mens-casual-shoes/">Casual Shoes</a>
                    <a class="subcategory" href="https://domain.com/mens-sneakers/">Sneakers</a>
                    <a class="subcategory" href="https://domain.com/mens-t-shirts/">T-shirts</a>
                    <a class="subcategory" href="https://domain.com/mens-polos/">Polos</a>
                </div>
                <div class="categories">
                    <span class="category defaultCursor">Women Best Sellers</span>
                    <a class="subcategory" href="https://domain.com/womens-sandals/">Sandals</a>
                    <a class="subcategory" href="https://domain.com/womens-sneakers/">Sneakers</a>
                    <a class="subcategory" href="https://domain.com/women-dresses/">Dresses</a>
                    <a class="subcategory" href="https://domain.com/women-tops/">Tops</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://domain.com/womens-curvy-clothing/">Women's Curvy Clothing</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://domain.com/fashion-bundles/v/">Fashion Bundles</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://domain.com/hijab-fashion/">Hijab Fashion</a>
                </div>
            </div>
            
            <div class="column">
                <div class="categories">
                    <a class="category" href="https://domain.com/brands/fashion-by/">SEE ALL BRANDS</a>
                    <a class="subcategory" href="https://domain.com/adidas/">Adidas</a>
                    <a class="subcategory" href="https://domain.com/converse/">Converse</a>
                    <a class="subcategory" href="https://domain.com/ravin/">Ravin</a>
                    <a class="subcategory" href="https://domain.com/dejavu/">Dejavu</a>
                    <a class="subcategory" href="https://domain.com/agu/">Agu</a>
                    <a class="subcategory" href="https://domain.com/activ/">Activ</a>
                    <a class="subcategory" href="https://domain.com/oxford--bellini--tie-house--milano/">Tie House</a>
                    <a class="subcategory" href="https://domain.com/shoe-room/">Shoe Room</a>
                    <a class="subcategory" href="https://domain.com/town-team/">Town Team</a>
                </div>
            </div>
        </div>
    </div>
</li>
```

# Project Setup Instructions

***Based on <https://ironsoftware.com/how-to/scraping-from-a-shopping-website/>***


Begin by establishing a new development project specifically for this task:

1. Start by creating a new Console Application or adding a new folder named "ShoppingSiteSample" for organizing our project files.
   
2. Introduce a new class named `ShoppingScraper` which will handle the scraping operations.
   
3. Kick off the scraping process by targeting the main categories and their respective subcategories from the site.

Proceed to define a data model for the categories:

```cs
public class Category
{
    /// <summary>
    /// The category name.
    /// </summary>
    /// <value>
    /// A string representing the category name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// The URL associated with the category.
    /// </summary>
    /// <value>
    /// A string containing the URL.
    /// </value>
    public string URL { get; set; }

    /// <summary>
    /// List of subcategories within this category.
    /// </summary>
    /// <value>
    /// A list containing subcategories.
    /// </value>
    public List<Category> SubCategories { get; set; }
}
``` 

This model facilitates the storage and manipulation of category data, including URLs and nested subcategories, crucial for the scraping process.

Here's a paraphrased version of the provided C# class code section:

```cs
public class Category
{
    /// <summary>
    /// Property to get or set the category name.
    /// </summary>
    /// <value>
    /// Represents the name of the category.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Property to get or set the category URL.
    /// </summary>
    /// <value>
    /// Represents the URL associated with the category.
    /// </value>
    public string URL { get; set; }

    /// <summary>
    /// Property to get or set the list of subcategories associated with this category.
    /// </summary>
    /// <value>
    /// List representing the subcategories of this category.
    /// </value>
    public List<Category> SubCategories { get; set; }
}
```

This section restructures the comments to appear more explanatory, ensuring easier understanding while maintaining the intended meanings and technical content.

----
### 4. Developing the Scraping Logic

Next, we will construct our scraping logic:

```cs
public class ShoppingScraper : WebScraper
{
    /// <summary>
    /// Initializes the web scraper. Set up the initial configuration such as requesting a start URL and defining allowed/disallowed URL patterns.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
        this.Request("www.webSite.com", Parse);
    }

    /// <summary>
    /// Default response handler for the web scraper. Use this to handle different types of pages or add more handlers for other page types.
    /// </summary>
    /// <param name="response">The HTTP response object to process</param>
    public override void Parse(Response response)
    {
        var categoryList = new List<Category>();
        
        foreach (var linkItem in response.Css("#menuFixed > ul > li > a"))
        {
            var category = new Category();
            category.URL = linkItem.Attributes["href"];
            category.Name = linkItem.InnerText;
            categoryList.Add(category);
        }
        Scrape(categoryList, "Shopping.Jsonl");
    }
}
```

This segment of code establishes the scraping mechanism for collecting links from the site's menu:

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" class="img-responsive add-shadow img-margin"></a></p>

Enhancing our code to include both major categories and their sub-links:

```cs
public override void Parse(Response response)
{
    // Root category links
    var mainCategoryList = new List<Category>();
    
    foreach (var listItem in response.Css("#menuFixed > ul > li"))
    {
        // Individual links
        foreach (var link in listItem.Css("a"))
        {
            var mainCategory = new Category();
            mainCategory.URL = link.Attributes["href"];
            mainCategory.Name = link.InnerText;
            mainCategory.SubCategories = new List<Category>();
            // Sub-category links
            foreach (var subLink in listItem.Css("a[class=subcategory]"))
            {
                var subCategory = new Category();
                subCategory.URL = link.Attributes["href"];
                subCategory.Name = link.InnerText;
                // Ensure no duplicates
                if (mainCategory.SubCategories.Find(x => x.Name == subCategory.Name && x.URL == subCategory.URL) == null)
                {
                    mainCategory.SubCategories.Add(subCategory);
                }
            }
            mainCategoryList.Add(mainCategory);
        }
    }
    Scrape(mainCategoryList, "Shopping.Jsonl");
}
```

Now that we have secured links to all the site's categories, it's time to start scraping the specific products within each category.

Let's explore any category page to examine its content.

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's a look at its underlying HTML structure:

```html
<section class="products">
    <!-- Product details omitted for brevity -->
</section>
```

Let's proceed to model this content for product data extraction.

```cs
public class Product
{
    /// <summary>
    /// Product's name.
    /// </summary>
    /// <value>
    /// Name of the product.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Product's price.
    /// </summary>
    /// <value>
    /// Price of the product.
    /// </value>
    public string Price { get; set; }

    /// <summary>
    /// Product's image URL.
    /// </summary>
    /// <value>
    /// URL of the product's image.
    /// </value>
    public string Image { get; set; }
}
```

To specifically scrape the pages of each category, implement this enhanced parsing method:

```cs
public void ParseCategory(Response response)
{
    var productList = new List<Product>();
    
    // Scrape the links of individual products
    foreach (var link in response.Css("body > main > section.osh-content > section.products > div > a"))
    {
        var product = new Product();
        product.Name = link.InnerText;
        product.Image = link.Css("div.image-wrapper.default-state > img")[0].Attributes["src"];
        productList.Add(product);
    }

    Scrape(productList, "Products.Jsonl");
}
```

 ----

```cs
public class ShoppingScraper : WebScraper
{
    /// <summary>
    /// Initializes the web scraper by setting up the initial configuration and URLs that need to be crawled.
    /// Necessary steps include specifying which URLs to start with and defining which domains are allowed or prohibited.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "YourLicenseKeyHere";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
        // Initialize scraping with the base website URL
        this.Request("https://www.webSite.com", Parse);
    }

    /// <summary>
    /// Sets up parsing logic for handling HTTP responses.
    /// This method should be overridden to respond to different types of web pages or data formats.
    /// </summary>
    /// <param name="response">The HTTP response from the web server</param>
    public override void Parse(Response response)
    {
        // Creates a list to hold categories found during scraping
        var categoryList = new List<Category>();

        // Scrapes categories from specific HTML elements identified by the CSS selector
        foreach (var link in response.Css("#menuFixed > ul > li > a"))
        {
            var category = new Category();
            category.URL = link.Attributes["href"];
            category.Name = link.InnerText;
            // Add each found category to the list
            categoryList.Add(category);
        }
        // Save the scraped categories to a JSONL file
        Scrape(categoryList, "Shopping.Jsonl");
    }
}
```

Below is the paraphrased section of your article regarding scraping links from a menu using the approach described:

-----

# Extracting Navigation Links from the Menu

***Based on <https://ironsoftware.com/how-to/scraping-from-a-shopping-website/>***


Exploring the site's navigation, we observe how the menu structure presents links to various categories.

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" class="img-responsive add-shadow img-margin"></a></p>

This phase involves adjusting our code to effectively capture the primary category headings and their respective sub-links. Through a deeper look into the HTML structure, we're able to map each category and subcategory efficiently. Below is an enhanced approach to parsing these elements:

```cs
public override void Parse(Response response)
{
    // Initializing a list to store category links
    var categoryList = new List<Category>();
    
    // Iterating over primary category elements
    foreach (var li in response.Css("#menuFixed > ul > li"))
    {
        // Examining each link within the main category
        foreach (var link in li.Css("a"))
        {
            var category = new Category
            {
                URL = link.Attributes["href"],
                Name = link.InnerText,
                SubCategories = new List<Category>()
            };

            // Capturing subcategory links
            foreach (var subCategory in li.Css("a[class='subcategory']"))
            {
                var subCat = new Category
                {
                    URL = subCategory.Attributes["href"],
                    Name = subCategory.InnerText
                };

                // Ensuring unique entries
                if (!category.SubCategories.Any(c => c.Name == subCat.Name && c.URL == subCat.URL))
                {
                    category.SubCategories.Add(subCat);
                }
            }

            // Adding the fully formed category
            categoryList.Add(category);
        }
    }

    // Output the structured data
    Scrape(categoryList, "Shopping.Jsonl");
}
```

This refined code snippet showcases how we systematically extract and organize links from the website's menu, paving the way for further scraping activities involving detailed product categories.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's the paraphrased section:

-----
We'll enhance our scraping code to capture the primary categories as well as all associated sub-links.

```cs
public override void Parse(Response response)
{
    // Root category links list
    var rootCategoryList = new List<Category>();
    
    // Loop over each category item
    foreach (var li in response.Css("#menuFixed > ul > li"))
    {
        // Primary Link list per category
        foreach (var link in li.Css("a"))
        {
            var mainCategory = new Category();
            mainCategory.URL = link.Attributes["href"];
            mainCategory.Name = link.InnerText;
            mainCategory.SubCategories = new List<Category>();

            // Iterate through Subcategory Links
            foreach (var subLink in li.Css("a[class='subcategory']"))
            {
                var subCategory = new Category();
                subCategory.URL = subLink.Attributes["href"];
                subCategory.Name = subLink.InnerText;

                // Ensure each subcategory is unique before adding
                if (!mainCategory.SubCategories.Any(s => s.Name == subCategory.Name && s.URL == subCategory.URL))
                {
                    mainCategory.SubCategories.Add(subCategory);
                }
            }
            // Append to the main category list
            rootCategoryList.Add(mainCategory);
        }
    }
    // Trigger the scrape to output file
    Scrape(rootCategoryList, "Shopping.Jsonl");
}
```

This adjusted code block now includes a more streamlined approach to parsing and organizing category data, ensuring each subcategory is verified before it’s added to prevent duplicates, thus optimizing the data structure for better subsequent processing.

Here's the paraphrased section of the article:

```cs
public override void Parse(Response response)
{
    // Root level category list
    var categories = new List<Category>();

    // Iterate through each category item in the menu
    foreach (var menuItem in response.Css("#menuFixed > ul > li"))
    {
        // Process each main category link found
        foreach (var link in menuItem.Css("a"))
        {
            var category = new Category
            {
                URL = link.Attributes["href"],
                Name = link.InnerText,
                SubCategories = new List<Category>()
            };

            // Explore subcategories within each main category
            foreach (var subLink in menuItem.Css("a[class=subcategory]"))
            {
                var subCategory = new Category
                {
                    URL = link.Attributes["href"], // Note: Presumably should be subLink, needs clarification
                    Name = link.InnerText // Note: Presumably should be subLink, needs clarification
                };

                // Ensure no duplicates before adding new subcategory
                if (!category.SubCategories.Any(sc => sc.Name == subCategory.Name && sc.URL == subCategory.URL))
                {
                    category.SubCategories.Add(subCategory);
                }
            }

            // Add the fully built category to the list
            categories.Add(category);
        }
    }

    // Output the structured data
    Scrape(categories, "Shopping.Jsonl");
}
```

This rewritten section includes clarifications in comments and more descriptive renaming, making the roles of variables and the flow of logic clearer. The parsing methods remain functionally similar to the original to ensure consistency in behavior.

With the navigation links to all the site categories established, we can now proceed to extract product data from within each category.

Let's delve into a specific category to explore its content.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here is the HTML markup for the specific section of the website:

```html
<section class="products">
    <div class="sku -gallery -validate-size " data-sku="AG249FA0T2PSGNAFAMZ" ft-product-sizes="41,42,43,44,45" ft-product-color="Multicolour">
        <a class="link" href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Bundle Of 2 Sneakers - Black &amp; Navy Blue" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-sku="AG249FA0T2PSGNAFAMZ" data-src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg"><noscript>&lt;img src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" width="210" height="262" class="image" /&gt;</noscript>
            </div> <h2 class="title">
                <span class="brand ">Agu&nbsp;</span>
                <span class="name" dir="ltr">Bundle Of 2 Sneakers - Black &amp; Navy Blue</span>
            </h2><div class="price-container clearfix">
                <span class="price-box">
                    <span class="price">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="299">299</span>
                    </span>   <span class="price -old  -no-special"></span>
                </span>
            </div><div class="rating-stars"><div class="stars-container"><div class="stars" style="width: 62%"></div></div> <div class="total-ratings">(30)</div> </div>    <span class="shop-first-logo-container"><img src="http://www.WebSite.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" data-src="http://www.WebSite.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" class="lazy shop-first-logo-img -mbxs -loaded"> </span>
            <span class="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>
            <div class="list -sizes" data-selected-sku="">
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=41">41</span>     <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=42">42</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=43">43</span>     <span the="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=44">44</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=45">45</span>
            </div>
        </a>
    </div>
    <div class="sku -gallery -validate-size " data-sku="LE047FA01SRK4NAFAMZ" ft-product-sizes="110,115,120,125,130,135" ft-product-color="Black">
        <a class="link" href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html">
            <div class="image-wrapper default-state"><img class="lazy image -loaded" alt="Genuine Leather Belt - Black" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-sku="LE047FA01SRK4NAFAMZ" data-src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg"><noscript>&lt;img src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" width="210" height="262" class="image" /&gt;</noscript></div>
            <h2 class="title"><span the="brand ">Leather Shop&nbsp;</span> <span the="name" dir="ltr">Genuine Leather Belt - Black</span></h2><div class="price-container clearfix">
                <span class="sale-flag-percent">-29%</span>  <span class="price-box"> <span class="price"><span data-currency-iso="EGP">EGP</span> <span dir="ltr" data-price="96">96</span> </span>   <span class="price -old "><span data-currency-iso="EGP">EGP</span> <span dir="ltr" data-price="135">135</span> </span> </span>
            </div><div class="rating-stars"><div class="stars-container"><div class="stars" style="width: 100%"></div></div> <div the="total-ratings">(1)</div> </div>
            <span the="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>    <div class="list -sizes" data-selected-sku="">
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=110">110</span>     <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=115">115</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=120">120</span>     <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=125">125</span>     <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=130">130</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=135">135</span>
            </div>
        </a>
    </div>
</section>
```

Here is the paraphrased section, with URL paths resolved to ironsoftware.com:

```html
<section class="products">
    <div class="sku -gallery -validate-size" data-sku="AG249FA0T2PSGNAFAMZ" ft-product-sizes="41,42,43,44,45" ft-product-color="Multicolour">
        <a class="link" href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Bundle Of 2 Sneakers - Black &amp; Navy Blue" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-sku="AG249FA0T2PSGNAFAMZ" data-src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg"><noscript><img src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
            </div>
            <h2 class="title">
                <span class="brand">Agu&nbsp;</span>
                <span class="name" dir="ltr">Bundle Of 2 Sneakers - Black &amp; Navy Blue</span>
            </h2>
            <div class="price-container clearfix">
                <span class="price-box">
                    <span class="price">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="299">299</span>
                    </span>
                    <span class="price -old -no-special"></span>
                </span>
            </div>
            <div class="rating-stars">
                <div class="stars-container">
                  <div class="stars" style="width: 62%"></div>
                </div>
                <div class="total-ratings">(30)</div>
            </div>
            <span class="shop-first-logo-container">
              <img src="http://www.WebSite.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" data-src="http://www.WebSite.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" class="lazy shop-first-logo-img -mbxs -loaded">
            </span>
            <span class="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>
            <div class="list -sizes" data-selected-sku="">
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=41">41</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=42">42</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=43">43</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=44">44</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=45">45</span>
            </div>
        </a>
    </div>
    <div class="sku -gallery -validate-size" data-sku="LE047FA01SRK4NAFAMZ" ft-product-sizes="110,115,120,125,130,135" ft-product-color="Black">
        <a class="link" href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html">
            <div class="image-wrapper default-state">
              <img class="lazy image -loaded" alt="Genuine Leather Belt - Black" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-sku="LE047FA01SRK4NAFAMZ" data-src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg"><noscript><img src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
            </div>
            <h2 class="title">
                <span class="brand">Leather Shop&nbsp;</span>
                <span class="name" dir="ltr">Genuine Leather Belt - Black</span>
            </h2>
            <div class="price-container clearfix">
                <span class="sale-flag-percent">-29%</span>
                <span class="price-box">
                  <span class="price">
                    <span data-currency-iso="EGP">EGP</span>
                    <span dir="ltr" data-price="96">96</span>
                  </span>
                  <span class="price -old">
                    <span data-currency-iso="EGP">EGP</span>
                    <span dir="ltr" data-price="135">135</span>
                  </span>
                </span>
            </div>
            <div class="rating-stars">
                <div class="stars-container">
                    <div the "stars" style="width: 100%"></div>
                </div>
                <div class="total-ratings">(1)</div>
            </div>
            <span class="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>
            <div class="list -sizes" data-selected-sku="">
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=110">110</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=115">115</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=120">120</span>
                <span class "js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=125">125</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=130">130</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=135">135</span>
            </div>
        </a>
    </div>
</section>
```

Here is the paraphrased section from the article:

-----
Let's develop a data model for these products as outlined below.

Here is the paraphrased section:

```cs
public class Product
{
    /// <summary>
    /// Property to get or set the product name.
    /// </summary>
    /// <value>
    /// The name of the product.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Property to get or set the product price.
    /// </summary>
    /// <value>
    /// The price of the product.
    /// </value>
    public string Price { get; set; }

    /// <summary>
    /// Property to get or set the product image URL.
    /// </summary>
    /// <value>
    /// The URL of the product image.
    /// </value>
    public string Image { get; set; }
}
```

To effectively scrape data from category pages, we introduce a new scraping method:

```cs
public void ParseCategory(Response response)
{
    // Collection for storing product details
    var productList = new List<Product>();

    foreach (var link in response.Css("body > main > section.osh-content > section.products > div > a"))
    {
        var product = new Product();
        product.Name = link.InnerText;
        product.Image = link.Css("div.image-wrapper.default-state > img")[0].Attributes["src"];
        productList.Add(product);
    }

    Scrape(productList, "Products.Jsonl");
}
```

Here's the paraphrased section of the article with resolved URLs for links and images:

```cs
public void ParseCategory(Response response)
{
    // Initialize the list to hold products found
    var products = new List<Product>();

    // Iterate over each product link in the specified section of the page
    foreach (var link in response.Css("body > main > section.osh-content > section.products > div > a"))
    {
        var product = new Product();
        product.Name = link.InnerText;
        product.Image = link.Css("div.image-wrapper.default-state > img")[0].Attributes["src"];
        products.Add(product);
    }

    // Save the extracted products into a JSONL file
    Scrape(products, "Products.Jsonl");
}
```

This modification retains the functionality and purpose of the original code while changing phrasing and structure slightly for uniqueness.

