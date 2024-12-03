# Advanced Webscraping Capabilities

***Based on <https://ironsoftware.com/tutorials/webscraping-in-c-sharp-advanced/>***


## Feature: HttpIdentity

In situations where a website requires login to access its content, `HttpIdentity` is used to accommodate these requirements:

```cs
HttpIdentity id = new HttpIdentity();
id.NetworkUsername = "username";
id.NetworkPassword = "pwd";
Identities.Add(id); 
```

IronWebScraper introduces a compelling feature enabling the use of numerous distinct credentials or browser types to simulate or scrape web content through various login sessions seamlessly.

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    var proxyList = "IP-Proxy1:8080,IP-Proxy2:8081".Split(',');
    foreach (var userAgent in IronWebScraper.CommonUserAgents.ChromeDesktopUserAgents)
    {
        foreach (var proxy in proxyList)
        {
            Identities.Add(new HttpIdentity()
            {
                UserAgent = userAgent,
                UseCookies = true,
                Proxy = proxy
            });
        }
    }
    this.Request("http://www.Website.com", Parse);
}
```

Numerous attributes are available that influence how the scraper behaves to avoid being blocked:

- **NetworkDomain**: Requires user authentication and supports multiple network types including Windows, NTLM, Kerberos, and more.
- **NetworkUsername** and **NetworkPassword**: Credentials for authentication across various network protocols.
- **Proxy**: For setting proxy configurations.
- **UserAgent**: To specify the browser engine used for requests.
- **HttpRequestHeaders**: For defining custom header values using a dictionary format.
- **UseCookies**: Toggle to enable or disable the usage of cookies.

IronWebScraper utilizes randomized identities for scraping. Specific identities can be set for targeted page parsing.

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    HttpIdentity identity = new HttpIdentity()
    {
        NetworkUsername = "username",
        NetworkPassword = "pwd"
    };
    Identities.Add(identity);
    this.Request("http://www.Website.com", Parse, identity);
}
```

## Enabling Web Cache

The caching feature keenly stashes requested pages. This is especially useful during development and testing, supporting developers by saving pages for reuse after code updates.

Implement this in the `Init()` method:

`EnableWebCache();`

You may set cache expiration with:

`EnableWebCache(Timespan ex);
``

Cached data is stored under the `WebCache` directory in the working directory.

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    EnableWebCache(new TimeSpan(1,30,30));
    this.Request("http://www.WebSite.com", Parse);
}
```

## Managing Throttling

Control over the frequency and number of connections per domain is crucial:

```cs
public override void Init()
{
    License.LicenseKey = "LicenseKey";
    this.LoggingLevel = WebScraper.LogLevel.All;
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";
    this.MaxHttpConnectionLimit = 80;
    this.RateLimitPerHost = TimeSpan.FromMilliseconds(50);
    this.OpenConnectionLimitPerHost = 25;
    this.ObeyRobotsDotTxt = false;
    this.ThrottleMode = Throttle.ByDomainHostName;
    this.Request("https://www.Website.com", Parse);
}
```

### Throttling Attributes

- **MaxHttpConnectionLimit**: Maximum open HTTP requests permitted.
- **RateLimitPerHost**: Minimum delay between successive requests to a domain.
- **OpenConnectionLimitPerHost**: Maximum concurrent HTTP requests allowed per host.
- **ThrottleMode**: Regulates requests by domain hostname and IP, maintaining polite scraping practices even on shared servers.