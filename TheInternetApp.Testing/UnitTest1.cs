namespace TheInternetApp.Testing;

public class Tests
{
    private ChromeDriver _driver;
    [SetUp]
    public void Setup()
    {
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArgument("--headless");
        _driver = new(chromeOptions);
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
    }

    private By addButtonLocator = By.XPath(".//button[@onclick='addElement()']");
    private By addedButtonLocator = By.XPath(".//button[@class='added-manually']");

    [TearDown]
    public void TearDown()
    {
        _driver.Quit();    
    }
    
    [Test]
    public void AddRemoveComponentsTest()
    {
        var numberOfButtonsToAdd = Random.Shared.Next(1, 10);
        var addButton = _driver.FindElement(addButtonLocator);
        for (int i = 0; i < numberOfButtonsToAdd; i++)
        {
            addButton.Click();
        }

        var numberOfButtons = _driver.FindElements(addedButtonLocator).Count;
        numberOfButtons.Should().Be(numberOfButtonsToAdd);
    }
}