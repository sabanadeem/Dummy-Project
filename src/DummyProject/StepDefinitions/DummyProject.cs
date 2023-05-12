using Dummy_Project.PageObjects.Cart;
using Dummy_Project.PageObjects.Home;
using NUnit.Framework;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace Dummy_Project.StepDefinitions;

[Binding]
internal class DummyProject
{
    private readonly CartPage _cartPage;
    private readonly Home _home;

    private readonly ScenarioContext _scenarioContext;

    public DummyProject(CartPage cartPage, Home home, ScenarioContext scenarioContext)

    {
        _cartPage = cartPage;
        _home = home;
        _scenarioContext = scenarioContext;
    }

    [Given(@"I am on HomePage")]
    public void IamonHomePage()
    {
        _home.GotoPage();
    }

    [Given(@"I add four random items to my cart")]
    public void Iaddfourrandomitemstomycart()
    {

        _home.AddtoCartFlyingNinja();
        _home.AddtoCartHappyNinja();
        _home.AddtoCartPatientNinja();
        _home.AddtoCartWooAlbum();
        var items = new[]
        {
            "Flying Ninja","Happy Ninja", "Patient Ninja", "Woo Album #1"
        };
        _scenarioContext.Add("items",items);
    }

    [When(@"I view my cart")]
    public void Iviewmycart()
    {
        _cartPage.GotoPage();
        
    }

    [Then(@"I find total four items listed in my cart")]
    public void Ifindtotalfouritemslistedinmycart()
    {
        var expectedItems = _scenarioContext.Get<string[]>("items");
        var actualItems = _cartPage.GetCartItems();
        foreach (var expectedItem in expectedItems )
        {
           var x =  actualItems.Any(actualItem => actualItem.Name.Equals(expectedItem, StringComparison.InvariantCultureIgnoreCase));
           Assert.That(x, Is.True);
        }
    }

    [Given(@"I get Item rows in a cart")]
    public void IgetItemrowsinacart()
    {
        _cartPage.GetCartRows();
    }

    [When(@"I remove an item")]

    public void IRemoveItem()
    {
        _cartPage.GetCartItems();
        _cartPage.GetCartRows();
        //_cartPage.GetName();

    }

    [Then(@"I can see remaining items in cart")]
    public void ICanSeeRemainingItems()
    {

    }
}