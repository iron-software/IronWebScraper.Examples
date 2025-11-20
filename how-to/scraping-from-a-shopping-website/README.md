# Extracting Data from an E-commerce Website

***Based on <https://ironsoftware.com/how-to/scraping-from-a-shopping-website/>***


Choose an e-commerce site from which to extract data.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg" class="img-responsive add-shadow img-margin"></a></p>

From the image provided, you will notice a sidebar on the left that lists links to the product categories of the website. The initial phase of our task involves examining the site’s HTML structure to strategize our scraping approach.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg" class="img-responsive add-shadow img-margin"></a></p>

The fashion website organizes its items into main categories with several subcategories for each, including Men, Women, and Kids.

Here's the paraphrased section with resolved URL paths:

```html
<li class="menu-item" data-id="">
    <a href="https://ironsoftware.com/fashion-by/" class="main-category">
        <i class="cat-icon osh-font-fashion"></i>
        <span class="nav-subTxt">FASHION</span>
        <i class="osh-font-light-arrow-left"></i><i class="osh-font-light-arrow-right"></i>
    </a>
    <div class="navLayerWrapper" style="width: 633px; display: none;">
        <div class="submenu">
            <div class="column">
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/fashion-by/?sort=newest&amp;dir=desc&amp;viewType=gridView3">New Arrivals</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/men-fashion/">Men</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-shoes/">Shoes</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-clothing/">Clothing</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-accessories/">Accessories</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/women-fashion/">Women</a>
                    <a class="subcategory" href="https://ironsoftware.com/womens-shoes/">Shoes</a>
                    <a class="subcategory" href="https://ironsoftware.com/womens-clothing/">Clothing</a>
                    <a class="subcategory" href="https://ironsoftware.com/womens-accessories/">Accessories</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/girls-boys-fashion/">Kids</a>
                    <a class="subcategory" href="https://ironsoftware.com/boys-fashion/">Boys</a>
                    <a class="subcategory" href="https://ironsoftware.com/girls/">Girls</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/maternity-clothes/">Maternity Clothes</a>
                </div>
            </div>
            <div class="column">
                <div class="categories">
                    <span class="category defaultCursor">Men Best Sellers</span>
                    <a class="subcategory" href="https://ironsoftware.com/mens-casual-shoes/">Casual Shoes</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-sneakers/">Sneakers</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-t-shirts/">T-shirts</a>
                    <a class="subcategory" href="https://ironsoftware.com/mens-polos/">Polos</a>
                </div>
                <div the="categories">
                    <span class="category defaultCursor">Women Best Sellers</span>
                    <a class="subcategory" href="https://ironsoftware.com/womens-sandals/">Sandals</a>
                    <a class="subcategory" href="https://ironsoftware.com/womens-sneakers/">Sneakers</a>
                    <a class="subcategory" href="https://ironsoftware.com/women-dresses/">Dresses</a>
                    <a class="subcategory" href="https://ironsoftware.com/women-tops/">Tops</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/womens-curvy-clothing/">Women's Curvy Clothing</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/fashion-bundles/v/">Fashion Bundles</a>
                </div>
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/hijab-fashion/">Hijab Fashion</a>
                </div>
            </div>
            <div class="column">
                <div class="categories">
                    <a class="category" href="https://ironsoftware.com/brands/fashion-by/">SEE ALL BRANDS</a>
                    <a class="subcategory" href="https://ironsoftware.com/adidas/">Adidas</a>
                    <a class="subcategory" href="https://ironsoftware.com/converse/">Converse</a>
                    <a class="subcategory" href="https://ironsoftware.com/ravin/">Ravin</a>
                    <a class="subcategory" href="https://ironsoftware.com/dejavu/">Dejavu</a>
                    <a class="subcategory" href="https://ironsoftware.com/agu/">Agu</a>
                    <a class="subcategory" href="https://ironsoftware.com/activ/">Activ</a>
                    <a class="subcategory" href="https://ironsoftware.com/oxford--bellini--tie-house--milano/">Tie House</a>
                    <a class="subcategory" href="https://ironsoftware.com/shoe-room/">Shoe Room</a>
                    <a class="subcategory" href="https://ironsoftware.com/town-team/">Town Team</a>
                </div>
            </div>
        </div>
    </div>
</li>
```

Let's get started on our project:

1. Start by creating a new Console App or by establishing a new directory named "ShoppingSiteSample" for our project.
   
2. Create a fresh class titled "ShoppingScraper".

3. Initially, our focus will be on extracting the primary site categories along with their respective subcategories.

Next, we need to define a Categories Model:

Here is the paraphrased section of the article with the resolved URL paths and formatted in Markdown:

```csharp
public class Category
{
    /// <summary>
    /// Retrieves or updates the category name.
    /// </summary>
    /// <value>
    /// A string representing the category name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Retrieves or updates the hyperlink associated with the category.
    /// </summary>
    /// <value>
    /// A string representing the URL.
    /// </value>
    public string URL { get; set; }

    /// <summary>
    /// Retrieves or updates the list of subcategories related to this category.
    /// </summary>
    /// <value>
    /// A list of Category objects representing the subcategories.
    /// </value>
    public List<Category> SubCategories { get; set; }
}
```

Here's the paraphrased section of the article regarding building the scraper logic:

---

4. Next, let's construct the logic for our scraper

```csharp
public class ShoppingScraper : WebScraper
{
    /// <summary>
    /// Set up the web scraper by defining allowed connections and initial URLs.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
        this.Request("www.webSite.com", Parse);
    }

    /// <summary>
    /// Parse the HTML content obtained from the web response to extract essential data.
    /// </summary>
    /// <param name="response">The response object containing the HTTP response to parse.</param>
    public override void Parse(Response response)
    {
        var categoryList = new List<Category>();
        
        // Cycle through each navigation link in the menu to gather category details.
        foreach (var Links in response.Css("#menuFixed > ul > li > a"))
        {
            var cat = new Category
            {
                URL = Links.Attributes["href"],
                Name = Links.InnerText
            };
            categoryList.Add(cat);
        }
        
        // Persist the gathered category data in a JSONL formatted file.
        Scrape(categoryList, "Shopping.jsonl");
    }
}
```

In this section, we've refined the way we initiate and parse our web scraper for a more streamlined data extraction process.

```csharp
public class ShoppingScraper : WebScraper
{
    /// <summary>
    /// Sets up the web scraper with initial configuration, defining start URLs and rules for allowed or blocked domains.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey"; // Initialize license key for the scraper
        this.LoggingLevel = WebScraper.LogLevel.All; // Set logging to capture all events
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\"; // Define the output directory
        this.Request("www.webSite.com", Parse); // Initial request to start scraping
    }

    /// <summary>
    /// This method parses the received HTML to extract necessary data.
    /// </summary>
    /// <param name="response">The response object containing the HTML document.</param>
    public override void Parse(Response response)
    {
        var categoryList = new List<Category>(); // Prepare a list to hold category data

        // Loop through each anchor tag within the specified path to gather categories
        foreach (var link in response.Css("#menuFixed > ul > li > a"))
        {
            var cat = new Category
            {
                URL = link.Attributes["href"], // Retrieve the URL
                Name = link.InnerText // Retrieve the category name
            };
            categoryList.Add(cat); // Add the category to the list
        }

        // Save the extracted category data to a JSONL file named 'Shopping.jsonl'
        Scrape(categoryList, "Shopping.jsonl");
    }
}
```

```csharp
public override void Parse(Response response)
{
    // Initialize a list to hold the links to the categories
    var categoryList = new List<Category>();

    // Scan each 'li' element within the fixed menu to explore navigation links
    foreach (var li in response.Css("#menuFixed > ul > li"))
    {
        // Fetch main category links
        foreach (var link in li.Css("a"))
        {
            var mainCategory = new Category
            {
                URL = link.Attributes["href"],
                Name = link.InnerText,
                SubCategories = new List<Category>()
            };

            // Loop for subcategory links within each main category
            foreach (var subLink in li.Css("a[class=subcategory]"))
            {
                var subCategory = new Category
                {
                    URL = subLink.Attributes["href"],
                    Name = subLink.InnerText
                };

                // Ensure no duplication of subcategory links
                if (mainCategory.SubCategories.Find(c => c.Name == subCategory.Name && c.URL == subCategory.URL) == null)
                {
                    mainCategory.SubCategories.Add(subCategory);
                }
            }
            
            // Populate the main category list with the extracted data
            categoryList.Add(mainCategory);
        }
    }

    // Store the scraped category data into a JSONL file for further processing.
    Scrape(categoryList, "Shopping.jsonl");
}
```

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's the paraphrased section of the article:

-----
Let's modify our script to efficiently gather both Main Categories and their sub-links:

```csharp
public override void Parse(Response response)
{
    // Collection of Main Category Links
    var categoryList = new List<Category>();

    // Loop through each 'li' element under the fixed menu
    foreach (var listItem in response.Css("#menuFixed > ul > li"))
    {
        // Iterate through all primary links within each list item
        foreach (var link in listItem.Css("a"))
        {
            var category = new Category
            {
                URL = link.Attributes["href"],
                Name = link.InnerText,
                SubCategories = new List<Category>()
            };

            // Extract subcategory links
            foreach (var subLink in listItem.Css("a[class=subcategory]"))
            {
                var subCategory = new Category
                {
                    URL = subLink.Attributes["href"],
                    Name = subLink.InnerText
                };

                // Ensure subcategory is unique before adding
                if (!category.SubCategories.Any(sub => sub.Name == subCategory.Name && sub.URL == subCategory.URL))
                {
                    // Add sublinks under main category
                    category.SubCategories.Add(subCategory);
                }
            }
            
            // Add each Main Category to our list
            categoryList.Add(category);
        }
    }

    // Output the aggregated data to a JSONL file
    Scrape(categoryList, "Shopping.jsonl");
}
``` 

In this revision, we have streamlined the process of accumulating both primary categories and their respective sub-links into a single operation. This approach not only simplifies the script but also enhances its efficiency in categorizing and saving the data.

```csharp
public override void Parse(Response response)
{
    // Initialize a new list to hold categories extracted from the menu
    var categoryList = new List<Category>();

    // Loop through each list item in the designated menu
    foreach (var li in response.Css("#menuFixed > ul > li"))
    {
        // Extract all anchor links within the list item
        foreach (var linkItem in li.Css("a"))
        {
            var category = new Category
            {
                URL = linkItem.Attributes["href"],
                Name = linkItem.InnerText,
                SubCategories = new List<Category>()
            };

            // Find and assemble the list of Subcategories
            foreach (var subLinkItem in li.Css("a[class=subcategory]"))
            {
                var subcategory = new Category
                {
                    URL = subLinkItem.Attributes["href"],
                    Name = subLinkItem.InnerText
                };

                // Ensure subcategories are unique before adding
                if (category.SubCategories.Find(c => c.Name == subcategory.Name && c.URL == subcategory.URL) == null)
                {
                    category.SubCategories.Add(subcategory);
                }
            }

            // Include this category into our main list
            categoryList.Add(category);
        }
    }

    // Archive the structured category data into a JSONL formatted file
    Scrape(categoryList, "Shopping.jsonl");
}
```

We now possess the links to all the website's categories. Our next step is to begin extracting product data from each category. To do this, we will explore specific categories and examine their content.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" class="img-responsive add-shadow img-margin"></a></p>

Explore the HTML structure used on the page:

```html
<section class="products">
    <div class="sku -gallery -validate-size" data-sku="AG249FA0T2PSGNAFAMZ" ft-product-sizes="41,42,43,44,45" ft-product-color="Multicolour">
        <a class="link" href="https://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Bundle Of 2 Sneakers - Black & Navy Blue" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-sku="AG249FA0T2PSGNAFAMZ" data-src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg">
                <noscript><img src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
            </div>
            <h2 class="title">
                <span class="brand ">Agu&nbsp;</span>
                <span class="name" dir="ltr">Bundle Of 2 Sneakers - Black & Navy Blue</span>
            </h2>
            <div class="price-container clearfix">
                <span class="price-box">
                    <span class="price">
                        <span data-currency-iso="EGP">EGP</span>
                        <span dir="ltr" data-price="299">299</span>
                    </span>
                    <span class="price -old  -no-special"></span>
                </span>
            </div>
            <div class="rating-stars">
                <div class="stars-container">
                    <div class="stars" style="width: 62%"></div>
                </div>
                <div class="total-ratings">(30)</div>
            </div>
            <span class="shop-first-logo-container">
                <img src="https://www.WebSite.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" data-src="https://www.WebSite.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" class="lazy shop-first-logo-img -mbxs -loaded">
            </span>
            <div class="list -sizes" data-selected-sku="">
                <span class="js-link sku-size" data-href="https://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=41">41</span>
                <span class="js-link sku-size" data-href="https://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=42">42</span>
                <span class="js-link sku-size" data-href="https://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=43">43</span>
                <span class="js-link sku-size" data-href="https://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=44">44</span>
                <span the js-link sku-size" data-href="https://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=45">45</span>
            </div>
        </a>
    </div>
    <div class="sku -gallery -validate-size" data-sku="LE047FA01SRK4NAFAMZ" ft-product-sizes="110,115,120,125,130,135" ft-product-color="Black">
        <a class="link" href="https://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Genuine Leather Belt - Black" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-sku="LE047FA01SRK4NAFAMZ" data-src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg">
                <noscript><img src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
            </div>
            <h2 class="title"><span class="brand ">Leather Shop&nbsp;</span><span the class="name" dir="ltr">Genuine Leather Belt - Black</span></h2>
            <div class="price-container clearfix">
                <span class="sale-flag-percent">-29%</span>
                <span class="price-box">
                    <span class="price"><span data-currency-iso="EGP">EGP</span><span dir="ltr" data-price="96">96</span></span>
                    <span the class="price -old"><span data-currency-iso="EGP">EGP</span><span dir="ltr" data-price="135">135</span></span>
                </span>
            </div>
            <div class="rating-stars">
                <div the "stars-container">
                    <div the "stars" style="width: 100%"></div>
                </div>
                <div the total-ratings">(1)</div>
            </div>
            <span class="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>
            <div the list "-sizes" data-selected-sku="">
                <span the js-link sku-size" data-href="https://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=110">110</span>
                <span class="js-link sku-size" data-href="https://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=115">115</span>
                <span class="js-link sku-size" data-href="https://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=120">120</span>
                <span the js-link sku-size" data-href="https://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=125">125</span>
                <span the js-link sku-size" data-href="https://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=130">130</span>
                <span the js-link sku-size" data-href="https://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=135">135</span>
            </div>
        </a>
    </div>
</section>
```

```html
<section class="products">
    <!-- Product: Bundle of 2 Sneakers -->
    <div class="sku -gallery -validate-size" data-sku="AG249FA0T2PSGNAFAMZ" ft-product-sizes="41,42,43,44,45" ft-product-color="Multicolour">
        <a class="link" href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Bundle Of 2 Sneakers - Black & Navy Blue" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-sku="AG249FA0T2PSGNAFAMZ" data-src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg">
                <noscript><img src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
            </div>
            <h2 class="title">
                <span class="brand">Agu</span>
                <span class="name" dir="ltr">Bundle Of 2 Sneakers - Black & Navy Blue</span>
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
    <!-- Product: Genuine Leather Belt -->
    <div class="sku -gallery -validate-size" data-sku="LE047FA01SRK4NAFAMZ" ft-product-sizes="110,115,120,125,130,135" ft-product-color="Black">
        <a class="link" href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Genuine Leather Belt - Black" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-sku="LE047FA01SRK4NAFAMZ" data-src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg">
                <noscript><img src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
            </div>
            <h2 class="title">
                <span class="brand">Leather Shop</span>
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
                    <div the="stars" style="width: 100%"></div>
                </div>
                <div class="total-ratings">(1)</div>
            </div>
            <span class="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>
            <div class="list -sizes" data-selected-sku="">
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=110">110</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=115">115</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=120">120</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=125">125</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=130">130</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=135">135</span>
            </div>
        </a>
    </div>
</section>
```
In this revised HTML snippet, we presented two products featured in a typical online store's listings. Each product section contains well-defined blocks for images, titles, price details, ratings, and available sizes, providing a clear and structured layout for potential customers.

```csharp
// Defining a model for product details
public class Product
{
    /// <summary>
    /// Specifies the product name.
    /// </summary>
    /// <value>
    /// The representation name of the product.
    /// </value>
    public string Name { get; set; }
    
    /// <summary>
    /// Specifies the product price.
    /// </summary>
    /// <value>
    /// The selling price of the product.
    /// </value>
    public string Price { get; set; }
    
    /// <summary>
    /// Specifies the URL of the product image.
    /// </summary>
    /// <value>
    /// A string containing the image URL.
    /// </value>
    public string Image { get; set; }
}
```

Below is the paraphrased section of your article with resolved URL paths:

```csharp
public class Product
{
    /// <summary>
    /// Property to get or set product name.
    /// </summary>
    /// <value>
    /// The name of the product.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Property to get or set the product price.
    /// </summary>
    /// <value>
    /// The cost of the product.
    /// </value>
    public string Price { get; set; }

    /// <summary>
    /// Property to get or set the product image URL.
    /// </summary>
    /// <value>
    /// URL of the product image.
    /// </value>
    public string Image { get; set; }
}
``` 

This updated section adheres to a professional and concise formatting style, maintaining clarity in the definition of the product class properties.

```csharp
/// <summary>
/// This method contains the logic for scraping the product data from category pages.
/// </summary>
/// <param name="response">The HTTP response object containing HTML data.</param>
public void ExtractCategoryData(Response response)
{
    var products = new List<Product>(); // A list to hold the extracted products

    // Loop over all the product links located within the specific section of the document
    foreach (var link in response.Css("section.products > div > a"))
    {
        var product = new Product
        {
            Name = link.Css("h2.title > span.name").First().InnerText, // Extract the product name
            Price = link.Css("div.price-container > span.price-box > span.price > span[data-price]").First().InnerText, // Extract the product price
            Image = link.Css("div.image-wrapper.default-state > img").First().Attributes["src"] // Extract the product image URL
        };

        products.Add(product); // Add the product to the list
    }

    // Save the gathered product data into a JSONL formatted file
    Scrape(products, "Products.jsonl");
}
```

Here's the paraphrased section of your article:

```csharp
public void ParseCategory(Response response)
{
    // Generating a list to hold product details
    var productList = new List<Product>();

    // Processing each product link in the designated section to extract necessary details
    foreach (var link in response.Css("section.products > div > a"))
    {
        var product = new Product
        {
            Name = link.Css("h2.title > span.name").First().InnerText,
            Price = link.Css("div.price-container > span.price-box > span.price > span[data-price]").First().InnerText,
            Image = link.Css("div.image-wrapper.default-state > img").First().Attributes["src"]
        };

        // Adding the extracted product into the list
        productList.Add(product);
    }

    // Storing the gathered data into a JSONL format file for later use.
    Scrape(productList, "Products.jsonl");
}
``` 

This revised section maintains the original meaning and flow while employing different expressions and structure to present the same coding logic.

