# Utilizing IronWebScraper License Keys

***Based on <https://ironsoftware.com/how-to/license-keys/>***


Upon completing the purchase of an IronWebScraper license, you will be immediately provided with a license key once your payment is processed. This key will appear on the checkout page and will also be delivered to your email address.

### Configuring Your IronWebScraper License Key with Code

For programming purposes, make sure to enter this line at the beginning of your application or before employing IronWebScraper:

```cs
IronWebScraper.License.LicenseKey = "IRONSCRAPER-MYLICENSE-KEY-1EF01";
```

### Configuring Your IronWebScraper License Key through Web.Config or App.Config

To integrate the license key into your entire application via the Web.Config or App.Config file, insert the following entry in the `appSettings` section of your configuration file:

```xml
<configuration>
...
  <appSettings>
    <add key="IronWebScraper.LicenseKey" value="IRONWEBSCRAPER-MYLICENSE-KEY-1EF01"/>
  </appSettings>
...
</configuration>
```

Be aware of a licensing complication that affects IronWebScraper versions [2023.4.13](https://www.nuget.org/packages/IronWebScraper/2023.4.13) to [2024.3.6](https://www.nuget.org/packages/IronWebScraper/2024.3.6) in the following scenarios:
- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

In these cases, the license key placed in a `Web.config` file may not be correctly recognized or utilized by the software. For a solution, refer to the '[Setting License Key in Web.config](https://ironsoftware.com/csharp/webscraper/troubleshooting/license-key-web.config/)' guide.

### Verifying the Installation of Your License Key

To confirm if your license key is functioning correctly:

```cs
bool result = IronWebScraper.License.IsValidLicense("IRONWEBSCRAPER-MYLICENSE-KEY-1EF01");
```

<hr class="separator">

## Kickstarting Your Project

Begin by reviewing our guide on how to [Get Started with IronWebsraper](https://ironsoftware.com/csharp/webscraper/docs/).