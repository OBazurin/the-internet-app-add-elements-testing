namespace TheInternetApp.Testing;

public abstract class BaseTest
{
    protected IWebDriver Driver => DriverHandler.Driver;
    protected AddRemoveElementsPage AddRemoveElementsPage => new AddRemoveElementsPage();
    
    [TearDown]
    public void TearDown()
    {
        DriverHandler.QuitDriver();
    }
}