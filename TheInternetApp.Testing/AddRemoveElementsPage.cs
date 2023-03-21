namespace TheInternetApp.Testing;

public class AddRemoveElementsPage : BasePage
{
    private readonly By _addButtonLocator = By.XPath(".//button[@onclick='addElement()']");
    private readonly By _addedButtonLocator = By.XPath(".//button[@class='added-manually']");

    public AddRemoveElementsPage() : base("add_remove_elements")
    {
    }

    public void AddButtons(int numberOfButtonsToAdd)
    {
        Console.WriteLine($"Going to add {numberOfButtonsToAdd} buttons on a page.");

        var addButton = Driver.FindElement(_addButtonLocator);

        for (var i = 0; i < numberOfButtonsToAdd; i++)
        {
            addButton.Click();
        }
    }

    public int GetAmountOfCreatedButtonsOnPage()
    {
        var amount = Driver.FindElements(_addedButtonLocator).Count;
        Console.WriteLine($"Getting amount of buttons on a page will return {amount}.");
        return amount;
    }
}
