# Utilizing License Keys with IronWebScraper

***Based on <https://ironsoftware.com/how-to/license-keys/>***


Upon purchasing an IronWebScraper license, you will be immediately provided with a license key once your transaction is confirmed.
This license key can be viewed on the checkout page and will also be emailed to you.

### Implementing Your IronWebScraper License Key Through Code

To integrate the license within your application, insert this line of code during the initialization phase, before any usage of IronWebScraper.

```cs
IronWebScraper.License.LicenseKey = "IRONSCRAPER-MYLICENSE-KEY-1EF01";
```

### Deploying Your IronWebScraper License Key via Web.Config or App.Config

For a more global approach, incorporate your license key into your Web.Config or App.Config. Simply add this entry within the `appSettings` section:

```xml
<configuration>
...
  <appSettings>
    <add key="IronWebScraper.LicenseKey" value="IRONWEBSCRAPER-MYLICENSE-KEY-1EF01"/>
  </appSettings>
...
</configuration>
```

Please note a prevalent licensing complication affecting IronWebScraper versions from [2023.4.13](https://www.nuget.org/packages/IronWebScraper/2023.4.13) to [2024.3.6](https://www.nuget.org/packages/IronWebScraper/2024.3.6) associated with:
- **ASP.NET** environments
- **.NET Framework version 4.6.2 and above**

There's a particular issue where the license key in `Web.config` is **NOT** being recognized. For further guidance, refer to our detailed problem-solving guide here: ['Setting License Key in Web.config'](https://ironsoftware.com/csharp/webscraper/troubleshooting/license-key-web.config/).

### Verifying Successful License Key Installation

To confirm if your license key is active, execute the following check:

```cs
bool result = IronWebScraper.License.IsValidLicense("IRONWEBSCRAPER-MYLICENSE-KEY-1EF01");
```

<hr class="separator">

## Kickstarting Your Project

Embark on your project by exploring our guide on [Getting Started with IronWebScraper](https://ironsoftware.com/csharp/webscraper/docs/).