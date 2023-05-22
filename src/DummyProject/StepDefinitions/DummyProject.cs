using Dummy_Project.PageObjects.Cart;
using Dummy_Project.PageObjects.Home;
using NUnit.Framework;
using System.Security.Policy;
using FluentAssertions;
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
        var rowResults = _cartPage.GetCartRows();
        _scenarioContext.Add("results", rowResults);
    }

    [When(@"I remove an item")]

    public void IRemoveFirstItem()
    {
        var rowItems = _scenarioContext.Get<CartTableRow[]>("results");// 
        var firstItem = rowItems[0].GetName();
        rowItems.First().RemoveRow();
        _scenarioContext.Add("removeditem",firstItem);
        Thread.Sleep(TimeSpan.FromSeconds(5));

    }
    
    public void RemoveItemByName(string item)
    {
        var rowItems = _scenarioContext.Get<CartTableRow[]>("results");
        rowItems.First(row => row.GetName() == item).RemoveRow();
        var updateditems = _scenarioContext.Get<CartTableRow>("updatedresults");
        Thread.Sleep(TimeSpan.FromSeconds(5));


    }

    [Then(@"I can see remaining items in cart")]
    public void ICanSeeRemainingItems()
    {
        var updatedItems = _cartPage.GetCartRows();
        var removedItem = _scenarioContext.Get<string>("removeditem");
        updatedItems.Select(row => row.GetName()).Should().NotContain(removedItem);

    }

    [Given(@"I check item rows in cart")]
    public void Icheckitemrowsincart()
    {
        var rowItems = _cartPage.GetCartRows();
        _scenarioContext.Add("rowitems",rowItems);
    }

    [When(@"I remove item by Name")]

    public void IremoveitembyName(String name)
    {
        var rowitems = _scenarioContext.Get<CartTableRow[]>("results");
        var n = 0;
        var emovedItem;
        if (rowitems[n].GetName() == name)
        {
            removedItem== rowitems[n].GetName();
            

        }

        n++;

    }

    Then I can see remaining item in cart
}