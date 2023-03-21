namespace TheInternetApp.Testing;

public abstract class BasePage
{
    private string _url = "https://the-internet.herokuapp.com/";

    protected static IWebDriver Driver => DriverHandler.Driver;
    protected BasePage(string pageRelativePath)
    {
        UpdateUrl(pageRelativePath);
        if (Driver.Url != _url)
        {
            Driver.Navigate().GoToUrl(_url);
        }
    }

    private void UpdateUrl(string ending)
    {
        _url = $"{Path.Combine(_url, ending)}/";
    }
}