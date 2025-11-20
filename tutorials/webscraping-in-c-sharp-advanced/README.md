# Enhanced Web Scraping Capabilities

***Based on <https://ironsoftware.com/tutorials/webscraping-in-c-sharp-advanced/>***


## `HttpIdentity` Feature

For accessing protected content on websites that require user authentication, the `HttpIdentity` feature in IronWebScraper is invaluable. Below is a step-by-step guide on setting up an instance of `HttpIdentity`:

```csharp
// Initialize a new HttpIdentity instance
HttpIdentity httpIdentity = new HttpIdentity();

// Configure authentication credentials
httpIdentity.NetworkUsername = "username";
httpIdentity.NetworkPassword = "password";

// Add the HttpIdentity to the identity collection
Identities.Add(httpIdentity);
```

IronWebScraper supports managing multiple credentials and browser identities, which is particularly useful for scraping websites that demand authentication for each session.

```csharp
public override void Init()
{
    // Enter the license key
    License.LicenseKey = "YourLicenseKeyHere";

    // Adjust the logging level to track detailed activity
    this.LoggingLevel = WebScraper.LogLevel.All;

    // Specify the directory for storing output
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";

    // Prepare a list of proxy addresses
    var proxyArray = "IP-Proxy1:8080,IP-Proxy2:8081".Split(',');

    // Loop through standard Chrome user agents
    foreach (var userAgent in IronWebScraper.CommonUserAgents.ChromeDesktopUserAgents)
    {
        // Apply each proxy with the specified user agent
        foreach (var proxy in proxyArray)
        {
            Identities.Add(new HttpIdentity()
            {
                UserAgent = userAgent,
                UseCookies = true,
                Proxy = proxy
            });
        }
    }
    
    // Initiate the first request to parse the website
    this.Request("https://www.ironsoftware.com", Parse);
}
```

Using parameters such as `NetworkDomain`, `UserAgent`, and `UseCookies` allows for a diverse set of behaviors and prevents blocking by websites.

In scenarios where a specific identity is needed for a page, you can set it explicitly within your request methods:

```csharp
public override void Init()
{
    // Provide your license key
    License.LicenseKey = "LicenseKey";

    // Set a comprehensive logging level
    this.LoggingLevel = WebScraper.LogLevel.All;

    // Define where files should be saved
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";

    // Instantiate and configure a new HttpIdentity
    HttpIdentity specificIdentity = new HttpIdentity();
    specificIdentity.NetworkUsername = "username";
    specificIdentity.NetworkPassword = "password";
    Identities.Add(specificIdentity);
    
    // Direct a web request using the particular identity
    this.Request("https://www.ironsoftware.com", Parse, specificIdentity);
}
```

## Enabling Web Cache Feature

IronWebScraper can cache web pages, which is especially useful during development and testing, to prevent repetitive live server requests. Here’s how to turn on this feature:

```csharp
// Activate web cache functionality without expiration
EnableWebCache();

// Alternatively, activate web cache with a defined lifespan
EnableWebCache(new TimeSpan(1, 30, 30));
```

The cached data is stored in the `WebCache` folder inside your designated working directory:

```csharp
public override void Init()
{
    // Insert the license key
    License.LicenseKey = "LicenseKey";

    // Opt to record all log events
    this.LoggingLevel = WebScraper.LogLevel.All;

    // Assign a directory for output files
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";

    // Engage the web cache with a specified duration
    EnableWebCache(new TimeSpan(1, 30, 30));
    
    // Begin initial site request and parsing
    this.Request("https://www.ironsoftware.com", Parse);
}
```

## Throttling Controls

IronWebScraper offers the ability to manage connection speeds and numbers, ensuring respectful access to domains:

```csharp
public override void Init()
{
    // Enter your license key
    License.LicenseKey = "LicenseKey";

    // Set the logging verbosity to maximum
    this.LoggingLevel = WebScraper.LogLevel.All;

    // Specify the directory for saving outputs
    this.WorkingDirectory = AppSetting.GetAppRoot() + @"\ShoppingSiteSample\Output\";

    // Configure HTTP request limitations
    this.MaxHttpConnectionLimit = 80;
    this.RateLimitPerHost = TimeSpan.FromMilliseconds(50);
    this.OpenConnectionLimitPerHost = 25;
    this.ObeyRobotsDotTxt = false;
    this.ThrottleMode = Throttle.ByDomainHostName;
    
    // Proceed with the initial request parsing
    this.Request("https://www.ironsoftware.com", Parse);
}
```

### Throttling Details

- `MaxHttpConnectionLimit`: Restricts the total active HTTP request threads
- `RateLimitPerHost`: Sets minimal delays between requests to specific domains or IPs
- `OpenConnectionLimitPerHost`: Limits concurrent requests per host
- `ThrottleMode`: Applies intelligent throttle mechanisms across domains and IPs

---

<h3>Get Started with IronWebscraper</h3>

!!!--LIBRARY_START_TRIAL_BLOCK--!!!