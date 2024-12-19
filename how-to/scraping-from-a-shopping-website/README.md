# Scrape Content from a Shopping Website

***Based on <https://ironsoftware.com/how-to/scraping-from-a-shopping-website/>***


We choose a shopping website to extract content from it.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/shoppingSite.jpg" class="img-responsive add-shadow img-margin"></a></p>

From the displayed image, it's evident that there's a sidebar containing links for various product categories of the website.

The initial phase involves analyzing the HTML structure of the site to strategize our web scraping approach.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/shoppingSiteLeftBar.jpg" class="img-responsive add-shadow img-margin"></a></p>

The fashion site is organized into various subcategories including Men, Women, and Kids.

```html
<li class="menu-item" data-id="">
    <a href="https://domain.com/fashion-by-/" class="main-category">
        <i class="cat-icon osh-font-fashion"></i> <span class="nav-subTxt">FASHION </span> <i class="osh-font-light-arrow-left"></i><i class="osh-font-light-arrow-right"></i>
    </a> <div class="navLayerWrapper" style="width: 633px; display: none;"><div class="submenu"><div class="column"><div class="categories"><a class="category" href="https://domain.com/fashion-by-/?sort=newest&amp;dir=desc&amp;viewType=gridView3">New Arrivals !</a>  </div><div class="categories"><a class="category" href="https://domain.com/men-fashion/">Men</a>   <a class="subcategory" href="https://domain.com/mens-shoes/">Shoes</a>   <a class="subcategory" href="https://domain.com/mens-clothing/">Clothing</a>   <a class="subcategory" href="https://domain.com/mens-accessories/">Accessories</a>  </div><div class="categories"><a class="category" href="https://domain.com/women-fashion/">Women</a>   <a class="subcategory" href="https://domain.com/womens-shoes/">Shoes</a>   <a class="subcategory" href="https://domain.com/womens-clothing/">Clothing</a>   <a class="subcategory" href="https://domain.com/womens-accessories/">Accessories</a>  </div><div class="categories"><a class="category" href="https://domain.com/girls-boys-fashion/">Kids</a>   <a class="subcategory" href="https://domain.com/boys-fashion/">Boys</a>   <a class="subcategory" href="https://domain.com/girls/">Girls</a>  </div><div class="categories"><a class="category" href="https://domain.com/maternity-clothes/">Maternity Clothes</a>  </div></div><div class="column"><div class="categories"> <span class="category defaultCursor">Men Best Sellers</span>  <a class="subcategory" href="https://domain.com/mens-casual-shoes/">Casual Shoes</a>   <a class="subcategory" href="https://domain.com/mens-sneakers/">Sneakers</a>   <a class="subcategory" href="https://domain.com/mens-t-shirts/">T-shirts</a>   <a class="subcategory" href="https://domain.com/mens-polos/">Polos</a>  </div><div class="categories"> <span the="category defaultCursor">Women Best Sellers</span>  <a class="subcategory" href="https://domain.com/womens-sandals/">Sandals</a>   <a class="subcategory" href="https://domain.com/womens-sneakers/">Sneakers</a>   <a class="subcategory" href="https://domain.com/women-dresses/">Dresses</a>   <a class="subcategory" href="https://domain.com/women-tops/">Tops</a>  </div><div class="categories"><a class="category" href="https://domain.com/womens-curvy-clothing/">Women's Curvy Clothing</a>  </div><div class="categories"><a class="category" href="https://domain.com/fashion-bundles/v/">Fashion Bundles</a>  </div><div class="categories"><a class="category" href="https://domain.com/hijab-fashion/">Hijab Fashion</a>  </div></div><div class="column"><div class="categories"><a class="category" href="https://domain.com/brands/fashion-by-/">SEE ALL BRANDS</a>   <a class="subcategory" href="https://domain.com/adidas/">Adidas</a>   <a class="subcategory" href="https://domain.com/converse/">Converse</a>   <a class="subcategory" href="https://domain.com/ravin/">Ravin</a>   <a class="subcategory" href="https://domain.com/dejavu/">Dejavu</a>   <a class="subcategory" href="https://domain.com/agu/">Agu</a>   <a class="subcategory" href="https://domain.com/activ/">Activ</a>   <a class="subcategory" href="https://domain.com/oxford--bellini--tie-house--milano/">Tie House</a>   <a class="subcategory" href="https://domain.com/shoe-room/">Shoe Room</a>   <a class="subcategory" href="https://domain.com/town-team/">Town Team</a>  </div></div></div></div>
</li>
```

Here's a paraphrased version of the provided section, with all relative URL paths resolved to "ironsoftware.com":

---

## Project Setup

Begin configuring our scraping project by following these steps:

1. Initiate by either creating a new Console Application or by adding a new folder titled "ShoppingSiteSample" specifically for our project.

2. Proceed to create a new class named `ShoppingScraper` which will hold all our scraping logic.

3. Start off our scraping tasks by aiming to gather data on the main site categories and their respective subcategories.

### Define the Categories Model

We'll now put together a model to represent our site’s categories, encompassing subcategories as well. Here's the structured outline for our categories model:

```cs
public class Category
{
    /// <summary>
    /// Category name property.
    /// </summary>
    /// <value>
    /// Name of the category.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// URL referencing the category.
    /// </summary>
    /// <value>
    /// Address URL of the category.
    /// </value>
    public string URL { get; set; }

    /// <summary>
    /// A list representing subcategories.
    /// </summary>
    /// <value>
    /// Subcategories within the category.
    /// </value>
    public List<Category> SubCategories { get; set; }
}
```

In this setup, we delineate the schema necessary for capturing category attributes which includes a listing of any inherent subcategories.

---

```cs
public class Category
{
    /// <summary>
    /// Property for getting or setting the category name.
    /// </summary>
    /// <value>
    /// Represents the category name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Property for getting or setting the category URL.
    /// </summary>
    /// <value>
    /// The web address of the category.
    /// </value>
    public string URL { get; set; }

    /// <summary>
    /// Property for getting or setting subordinate categories.
    /// </summary>
    /// <value>
    /// A list containing subcategories.
    /// </value>
    public List<Category> SubCategories { get; set; }
}
```

Here is the paraphrased section of the article:

-----
## Constructing the Scraping Logic

Next, we'll develop the core logic for our web scraper.

```cs
public class ShoppingScraper : WebScraper
{
    /// <summary>
    /// Initialize key components of the web scraper.
    /// Set up initial URLs and define domain rules.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
        this.Request("www.webSite.com", Parse);
    }

    /// <summary>
    /// A standard method to handle web responses.
    /// Design this method based on the type of web pages you are targeting.
    /// </summary>
    /// <param name="response">The HTTP response to process</param>
    public override void Parse(Response response)
    {
        var categoryList = new List<Category>();
        
        // Extract main category links
        foreach (var Links in response.Css("#menuFixed > ul > li > a "))
        {
            var cat = new Category
            {
                URL = Links.Attributes["href"],
                Name = Links.InnerText
            };
            categoryList.Add(cat);
        }
        // Output the results to a JSONL file
        Scrape(categoryList, "Shopping.Jsonl");
    }
}
```

The preceding extract demonstrates setting up the web scraper, initializing fundamental configurations, and crafting a method to parse the HTTP responses to extract data strictly structured as `Category` objects and subsequently storing them into a `.Jsonl` file.

Here is the paraphrased section:

```cs
public class ShoppingScraper : WebScraper
{
    /// <summary>
    /// This method sets up the initialization for the web scraper.
    /// Key activities include making a request to a starting URL and configuring the domains or URLs to allow or ban.
    /// </summary>
    public override void Init()
    {
        License.LicenseKey = "LicenseKey";
        this.LoggingLevel = WebScraper.LogLevel.All;
        this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
        this.Request("www.webSite.com", Parse);
    }

    /// <summary>
    /// This overridden method handles the web scraper's default http response parsing.
    /// You can implement additional methods for handling different page types as needed.
    /// </summary>
    /// <param name="response">The http Response object to interpret</param>
    public override void Parse(Response response)
    {
        List<Category> categoryList = new List<Category>();

        foreach (var link in response.Css("#menuFixed > ul > li > a "))
        {
            Category category = new Category
            {
                URL = link.Attributes ["href"],
                Name = link.InnerText
            };
            categoryList.Add(category);
        }
        Scrape(categoryList, "Shopping.Jsonl");
    }
}
```

This rewritten section maintains the original intent and technical details while altering the sentence structure and some terminology for a fresh presentation.

## Extracting Links from the Menu

<p><a rel="nofollow" href="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" target="_blank"><img src="https://ironsoftware.com/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" class="img-responsive add-shadow img-margin"></a></p>

Let's expand our code to efficiently gather both primary categories and their subcategories.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ShoppingSiteScrapeMenu.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's the revised section of the article where the code is updated to scrape both the Main Categories and any related sub-links:

```cs
public override void Parse(Response response)
{
    // Initialize a list to store category links
    var categoryList = new List<Category>();

    // Iterate over each category section
    foreach (var li in response.Css("#menuFixed > ul > li"))
    {
        // Process each main category link
        foreach (var Links in li.Css("a"))
        {
            var cat = new Category();
            cat.URL = Links.Attributes["href"];
            cat.Name = Links.InnerText;
            cat.SubCategories = new List<Category>();

            // Gather subcategory links under each main category
            foreach (var subCategory in li.Css("a[class=subcategory]"))
            {
                var subcat = new Category();
                subcat.URL = Links.Attributes["href"];
                subcat.Name = Links.InnerText;

                // Ensure there are no duplicates before adding to the list
                if (cat.SubCategories.Find(c => c.Name == subcat.Name && c.URL == subcat.URL) == null)
                {
                    cat.SubCategories.Add(subcat);
                }
            }
            // Add the fully constructed category to the list
            categoryList.Add(cat);
        }
    }
    // Use the Scrape method to process the collected data
    Scrape(categoryList, "Shopping.Jsonl");
}
```

In this revised version, the code efficiently iterates through main and subcategory elements, ensuring no redundant links are processed, before saving the structured data.

Here's the paraphrased section of the article, with all relative URL paths resolved to `ironsoftware.com`:

```cs
public override void Parse(Response response)
{
    // Initialize a list to hold the major category links
    var mainCategoryList = new List<Category>();

    // Iterate through each list item within the specified container
    foreach (var listItem in response.Css("#menuFixed > ul > li"))
    {
        // Extract each main link from the list items
        foreach (var link in listItem.Css("a"))
        {
            // Create a new category object and populate its properties
            var category = new Category();
            category.URL = link.Attributes["href"];
            category.Name = link.InnerText;
            category.SubCategories = new List<Category>();

            // Gather links for subcategories
            foreach (var subLink in listItem.Css("a[class=subcategory]"))
            {
                var subCategory = new Category();
                subCategory.URL = link.Attributes["href"];
                subCategory.Name = link.InnerText;

                // Ensure no duplicates before adding to subcategories list
                if (!category.SubCategories.Any(s => s.Name == subCategory.Name && s.URL == subCategory.URL))
                {
                    category.SubCategories.Add(subCategory);
                }
            }

            // Add the filled category to the main list
            mainCategoryList.Add(category);
        }
    }
    // Output the list to a JSONL file
    Scrape(mainCategoryList, "Shopping.Jsonl");
}
```

The section has been rewritten to maintain its original meaning while changing the structure and elements of the code comments and operations to offer a fresh perspective.

We have successfully gathered the links to all the categories on the site. Now, it's time to proceed with scraping the product details within each of these categories.

Next, let's move into a specific category to explore and examine its contents.

<p><a rel="nofollow" href="/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" target="_blank"><img src="/img/tutorials/webscraping-in-c-sharp/ProductSubCategoryList.jpg" class="img-responsive add-shadow img-margin"></a></p>

Here's a look at the HTML structure:

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
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=43">43</span>     <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=44">44</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html?size=45">45</span>
            </div>
        </a>
    </div>
    <div class="sku -gallery -validate-size " data-sku="LE047FA01SRK4NAFAMZ" ft-product-sizes="110,115,120,125,130,135" ft-product-color="Black">
        <a class="link" href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html">
            <div class="image-wrapper default-state"><img class="lazy image -loaded" alt="Genuine Leather Belt - Black" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-sku="LE047FA01SRK4NAFAMZ" data-src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg"><noscript>&lt;img src="https://static.WebSite.com/p/leather-shop-1831-030217-1-catalog_grid_3.jpg" width="210" height="262" class="image" /&gt;</noscript></div>
            <h2 class="title"><span class="brand ">Leather Shop&nbsp;</span> <span the "name" dir="ltr">Genuine Leather Belt - Black</span></h2><div

class="price-container clearfix">
                <span class="sale-flag-percent">-29%</span>  <span class="price-box"> <span class="price"><span data-currency-iso="EGP">EGP</span> <span dir="ltr" data-price="96">96</span> </span>   <span class="price -old "><span data-currency-iso="EGP">EGP</span> <span dir="ltr" data-price="135">135</span> </span> </span>
            </div><div class="rating-stars"><div the="stars-container"><div class="stars" style="width: 100%"></div></div> <div class="total-ratings">(1)</div> </div>
            <span class="osh-icon -ShoppingSite-local shop_local--logo -block -mbs -mts"></span>    <div class="list -sizes" data-selected-sku="">
                <span the "js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=110">110</span>     <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=115">115</span>
                <span the "js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=120">120</span>     <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=125">125</span>     <span the "js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=130">130</span>
                <span the "js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=135">135</span>
            </div>
        </a>
    </div>
</section>
```

This section of code showcases the product information within the category, highlighting product details such as SKU, available sizes, pricing, and image sources. Each product section under the `<div class="sku">` tag provides a structured insight into the product features, facilitating further actions from site visitors.

```html
<section class="products">
    <div class="sku -gallery -validate-size" data-sku="AG249FA0T2PSGNAFAMZ" ft-product-sizes="41,42,43,44,45" ft-product-color="Multicolour">
        <a class="link" href="http://www.WebSite.com/agu-bundle-of-2-sneakers-black-navy-blue-653884.html">
            <div class="image-wrapper default-state">
                <img class="lazy image -loaded" alt="Bundle Of 2 Sneakers - Black & Navy Blue" data-image-vertical="1" width="210" height="262" src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-sku="AG249FA0T2PSGNAFAMZ" data-src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" data-placeholder="placeholder_m_1.jpg"><noscript><img src="https://static.WebSite.com/p/agu-6208-488356-1-catalog_grid_3.jpg" width="210" height="262" class="image" /></noscript>
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
                <img src="https://www.ironsoftware.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" data-src="https://www.ironsoftware.com/images/local/logos/shop_first/ShoppingSite/logo_normal.png" class="lazy shop-first-logo-img -mbxs -loaded">
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
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=120">120</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=125">125</span>
                <span the="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=130">130</span>
                <span class="js-link sku-size" data-href="http://www.WebSite.com/leather-shop-genuine-leather-belt-black-712030.html?size=135">135</span>
            </div>
        </a>
    </div>
</section>
```

## Build Our Product Model

For handling the retrieved product data, let's define a `Product` model class. Each product will have properties such as `Name`, `Price`, and `Image`, which correspond to its name, price, and image URL respectively.

Here’s how we can define our model:

```cs
public class Product
{
    /// <summary>
    /// The name of the product.
    /// </summary>
    /// <value>
    /// String representing the name of the product.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// The price of the product.
    /// </summary>
    /// <value>
    /// String representing the price of the product.
    /// </value>
    public string Price { get; set; }

    /// <summary>
    /// The image URL of the product.
    /// </summary>
    /// <value>
    /// The URL string pointing to the image of the product.
    /// </value>
    public string Image { get; set; }
}
``` 

This class encapsulates all relevant details of a product and assists in managing this data clearly within our application.

Here's the paraphrased section of the article:

```cs
public class Product
{
    /// <summary>
    /// This property retrieves or updates the product's name.
    /// </summary>
    /// <value>
    /// Product name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// This property retrieves or updates the product's price.
    /// </summary>
    /// <value>
    /// Cost of the product.
    /// </value>
    public string Price { get; set; }

    /// <summary>
    /// This property retrieves or updates the URL link to the product's image.
    /// </summary>
    /// <value>
    /// Web address of the product image.
    /// </value>
    public string Image { get; set; }
}
```

To extract data from category pages, we implement a new scraping method:

```cs
public void ParseCategory(Response response)
{          
    // List of Product Links (Root)
    var productList = new List<Product>();

    foreach (var Links in response.Css("body > main > section.osh-content > section.products > div > a"))
    {
        var product = new Product();
        product.Name = Links.InnerText;
        product.Image = Links.Css("div.image-wrapper.default-state > img")[0].Attributes ["src"];                
        productList.Add(product);
    }

    Scrape(productList, "Products.Jsonl");
}
```

Here's the paraphrased section of the article, with resolved URL paths:

```cs
public void ParseCategory(Response response)
{
    // Creating a list to hold the product details
    var productsCollection = new List<Product>();

    // Selecting each product link from the products section
    foreach (var link in response.Css("body > main > section.osh-content > section.products > div > a"))
    {
        // Creating a new product instance
        var item = new Product();
        item.Name = link.InnerText; // Setting the product name
        // Fetching and setting the image URL from the product's image tag
        item.Image = link.Css("div.image-wrapper.default-state > img")[0].Attributes["src"];
        productsCollection.Add(item); // Adding the product to the list
    }

    // Saving the extracted product list to a JSON lines file
    Scrape(productsCollection, "Products.Jsonl");
}
```

This rewritten code enhances readability and details while accomplishing the same tasks as described in the original section.

