# Activating Your IronWebScraper License Key

***Based on <https://ironsoftware.com/get-started/license-keys/>***


Upon purchasing a license for IronWebScraper, you will receive a license key immediately after the payment is processed. This key will be shown on the checkout page and will also be sent to you via email.

### Programmatic Activation of Your IronWebScraper License

To activate your IronWebScraper license within your application, insert the following code at the application's startup, prior to utilizing IronWebScraper.

```csharp
// Apply the IronWebScraper license key as the application starts.
IronWebScraper.License.LicenseKey = "IRONSCRAPER-MYLICENSE-KEY-1EF01";
```

### Configuring Your IronWebScraper License Key through Web.Config or App.Config

You can set the license key for your entire application using Web.Config or App.Config by inserting this configuration in the appSettings section.

```xml
<configuration>
  ...
  <appSettings>
    <add key="IronWebScraper.LicenseKey" value="IRONWEBSCRAPER-MYLICENSE-KEY-1EF01"/>
  </appSettings>
  ...
</configuration>
```

There is a notable licensing issue for IronWebScraper versions [2023.4.13](https://www.nuget.org/packages/IronWebScraper/2023.4.13) to [2024.3.6](https://www.nuget.org/packages/IronWebScraper/2024.3.6) specifically affecting:
- **ASP.NET** projects
- Projects using **.NET Framework version >= 4.6.2**

In these cases, the license key set in the `Web.config` file does not get recognized. For a detailed explanation, visit our guide on '[Setting License Key in Web.config](https://ironsoftware.com/csharp/webscraper/troubleshooting/license-key-web.config/)'.

### Verifying the Installation of Your License Key

Run the following code snippet to test if your IronWebScraper license key has been successfully validated.

```csharp
// Check the validity of the IronWebScraper license key.
bool result = IronWebScraper.License.ValidLicense("IRONWEBSCRAPER-MYLICENSE-KEY-1EF01");
```

<hr class="separator">

## Begin Your Project

To start building your project with IronWebScraper, follow our [Introduction to IronWebScraper](https://ironsoftware.com/csharp/webscraper/docs/) guide.