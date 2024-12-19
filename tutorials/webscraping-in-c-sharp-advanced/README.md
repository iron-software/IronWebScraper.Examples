# Enhanced Web Scraping Techniques

***Based on <https://ironsoftware.com/tutorials/webscraping-in-c-sharp-advanced/>***


## HttpIdentity Feature

For websites that necessitate user authentication for accessing content, the `HttpIdentity` class offers a solution:

```cs
HttpIdentity id = new HttpIdentity();
id.NetworkUsername = "username";
id.NetworkPassword = "pwd";
Identities.Add(id); 
```

IronWebScraper's standout feature is its capacity to handle multiple login sessions simultaneously. This functionality allows the use of varied user credentials and browser specifications to efficiently emulate or scrape data from numerous websites.

```cs
public override void Init()
{
    License.LicenseKey = " LicenseKey ";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    var proxies = "IP-Proxy1: 8080,IP-Proxy2: 8081".Split(',');
    foreach (var UA in IronWebScraper.CommonUserAgents.ChromeDesktopUserAgents)
    {
        foreach (var proxy in proxies)
        {
            Identities.Add(new HttpIdentity()
            {
                UserAgent = UA,
                UseCookies = true,
                Proxy = proxy
            });
        }
    }
    this.Request("http://www.Website.com", Parse);
}
```

Many properties allow you to adapt behaviors to avoid getting blocked by websites:

* **NetworkDomain**: Specify this for user authentication across various network types including Windows, NTLM, Kerberos, Linux, BSD, and Mac OS X.
* **NetworkUsername**: Define the network or HTTP username for authentication. It supports various protocols and networks, including HTTP, Windows, and NTLM.
* **NetworkPassword**: Set this for the network or HTTP password. Compatible with multiple network types.
* **Proxy**: Use this to configure proxy settings.
* **UserAgent**: Specify the browser type, such as desktop Chrome, mobile Chrome, Internet Explorer, and Firefox.
* **HttpRequestHeaders**: Implement custom header values with a dictionary object `(Dictionary<string, string>)`.
* **UseCookies**: Turn on or off the use of cookies.

Using random identities, IronWebScraper optimizes scraping efficacy. However, a specific identity can be assigned when needed.

```cs
public override void Init()
{
    License.LicenseKey = " LicenseKey ";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    HttpIdentity identity = new HttpIdentity();
    identity.NetworkUsername = "username";
    identity.NetworkPassword = "pwd";
    Identities.Add(identity);
    this.Request("http://www.Website.com", Parse, identity);
}
```

## Web Cache Feature

This functionality allows for caching of requested pages, mainly during the development and testing phases, to enable code reuse after updates without needing a live website connection.

Activate it within the `Init()` method:

```cs
public override void Init()
{
    License.LicenseKey = " LicenseKey ";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    EnableWebCache(new TimeSpan(1, 30, 30));  // Setting cache expiration time
    this.Request("http://www.WebSite.com", Parse);
}
```

IronWebScraper also supports resuming scraping post-code restart by specifying a crawl ID.

```cs
static void Main(string[] args)
{
    EngineScraper scrape = new EngineScraper();
    scrape.Start("enginestate");
}
```

Request and response data are stored in the `SavedState` folder within the working directory.

## Throttling

Limiting the number and speed of connections per domain is feasible through the following parameters:

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    this.MaxHttpConnectionLimit = 80;  // Total number of allowed open HTTP requests
    this.RateLimitPerHost = TimeSpan.FromMilliseconds(50);  // Minimum delay between requests to the same domain or IP
    this.OpenConnectionLimitPerHost = 25;  // Allowed concurrent HTTP requests per host
    this.ObeyRobotsDotTxt = false;
    this.ThrottleMode = Throttle.ByDomainHostName;
    this.Request("https://www.Website.com", Parse);
}
```

### Throttling Properties:

* **MaxHttpConnectionLimit**: Maximum open HTTP connections (threads) allowed.
* **RateLimitPerHost**: Minimum delay or pause (in milliseconds) between requests to the same domain or IP.
* **OpenConnectionLimitPerHost**: Maximum concurrent HTTP requests allowed per host.
* **ThrottleMode**: Enables intelligent throttling, considering both the domain name and the host server’s IP address.

-----------------------------

<h3>Begin with IronWebscraper</h3>