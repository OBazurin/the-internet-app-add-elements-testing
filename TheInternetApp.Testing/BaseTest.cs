namespace TheInternetApp.Testing;

public class BaseTest
{
    protected IWebDriver Driver => DriverHandler.Driver;
    
    [SetUp]
    public void Setup()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
    }

    [TearDown]
    public void TearDown()
    {
        DriverHandler.QuitDriver();
    }
}