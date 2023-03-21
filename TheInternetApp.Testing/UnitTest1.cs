namespace TheInternetApp.Testing;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        DriverHandler.Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
    }

    private By addButtonLocator = By.XPath(".//button[@onclick='addElement()']");
    private By addedButtonLocator = By.XPath(".//button[@class='added-manually']");

    [TearDown]
    public void TearDown()
    {
        DriverHandler.Driver.Quit();    
    }
    
    [Test]
    public void AddRemoveComponentsTest()
    {
        var numberOfButtonsToAdd = Random.Shared.Next(1, 10);
        var addButton = DriverHandler.Driver.FindElement(addButtonLocator);
        for (int i = 0; i < numberOfButtonsToAdd; i++)
        {
            addButton.Click();
        }

        var numberOfButtons = DriverHandler.Driver.FindElements(addedButtonLocator).Count;
        numberOfButtons.Should().Be(numberOfButtonsToAdd);
    }
}