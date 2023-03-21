namespace TheInternetApp.Testing;

public class AddRemoveElementsTests : BaseTest
{
    private By addButtonLocator = By.XPath(".//button[@onclick='addElement()']");
    private By addedButtonLocator = By.XPath(".//button[@class='added-manually']");
    [Test]
    public void AddRemoveComponentsTest()
    {
        var numberOfButtonsToAdd = Random.Shared.Next(1, 10);
        var addButton = Driver.FindElement(addButtonLocator);
        for (int i = 0; i < numberOfButtonsToAdd; i++)
        {
            addButton.Click();
        }

        var numberOfButtons = Driver.FindElements(addedButtonLocator).Count;
        numberOfButtons.Should().Be(numberOfButtonsToAdd);
    }
}