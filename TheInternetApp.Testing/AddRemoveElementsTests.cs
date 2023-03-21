namespace TheInternetApp.Testing;

public class AddRemoveElementsTests : BaseTest
{
    [Test]
    public void AddRemoveComponentsTest([Random(1,10,1)]int numberOfButtonsToAdd)
    {
        AddRemoveElementsPage.GetAmountOfCreatedButtonsOnPage().Should().Be(0);
        AddRemoveElementsPage.AddButtons(numberOfButtonsToAdd);
        AddRemoveElementsPage.GetAmountOfCreatedButtonsOnPage().Should().Be(numberOfButtonsToAdd);
    }
}