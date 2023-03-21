namespace TheInternetApp.Testing;

public class DriverHandler
{
    private static IWebDriver? _driver;

    public static IWebDriver Driver => _driver ?? GetChromeDriver();

    private static IWebDriver GetChromeDriver()
    {
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArgument("--headless");
        _driver = new ChromeDriver(chromeOptions);
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        _driver.Manage().Window.Maximize();

        return _driver;
    }

    private static void QuitDriver()
    {
        _driver?.Quit();
        _driver = null;
    }
}