using Dummy_Project.Wrapper;
using OpenQA.Selenium;

namespace Dummy_Project.PageObjects.Cart;

internal class CartPage
{
    private static readonly By RowLocator = By.CssSelector(".woocommerce-cart-form__cart-item"); //to get rows
    private static readonly By NameLocator = By.CssSelector(".product-name"); // for each row, return name.
    private static readonly By QuantityLocator = By.CssSelector(".product-quantity .qty");
    
    private readonly IWebDriver _webDriver;
    private readonly WrappedWebDriver _wrappedWebDriver;


    public CartPage(IWebDriver webDriver, WrappedWebDriver wrappedWebDriver)
    {
        _webDriver = webDriver;
        _wrappedWebDriver = wrappedWebDriver;
    }


    // private static readonly By HappyNinja = By.CssSelector("#post-8 > div > div > form > table > tbody > tr:nth-child(2) > td.product-name > a");
    //
    // private static readonly By PatientNinja = By.CssSelector("#post-8 > div > div > form > table > tbody > tr:nth-child(3) > td.product-name > a");
    //
    // private static readonly By WooAlbum = By.CssSelector("#post-8 > div > div > form > table > tbody > tr:nth-child(4) > td.product-name > a");
    public void GotoPage()
    {
        _webDriver.Navigate().GoToUrl("https://cms.demo.katalon.com/cart/");
    }

    public (string Name, int Quantity)[] GetCartItems()
    {
        _wrappedWebDriver.WaitForAndFindElement(RowLocator);
        var Rows = _webDriver.FindElements(RowLocator);
        return Rows.Select(row =>
                (row.FindElement(NameLocator).Text,
                    int.Parse(row.FindElement(QuantityLocator).GetDomAttribute("value"))))
            .ToArray();
    } // method returning array of tuples


    // Method to return list of items in a page 
    // want  a method to return an array of cart table 

    public CartTableRow[] GetCartRows()
    {
        _wrappedWebDriver.WaitForAndFindElement(RowLocator);
        var Rows = _webDriver.FindElements(RowLocator);
        return Rows.Select(row => new CartTableRow(row)).ToArray();
    }
}

internal class CartTableRow
{
    private static readonly By RowLocator = By.CssSelector(".woocommerce-cart-form__cart-item"); //to get rows
    private static readonly By NameLocator = By.CssSelector(".product-name"); // for each row, return name.
    private static readonly By QuantityLocator = By.CssSelector(".product-quantity .qty");
    private static readonly By RemoveItem = By.CssSelector(".product-remove .remove");

    private readonly IWebElement _webElement;


    public CartTableRow(IWebElement webElement)
    {
        _webElement = webElement;
    }

    public string GetName()
    {
        var element = _webElement.FindElement(NameLocator);
        var name = element.Text;
        return name;
    }

    public int GetQuantity()
    {
        return int.Parse(_webElement.FindElement(QuantityLocator).GetDomAttribute("value"));
    }

    public void RemoveRow()
    {
        var element = _webElement.FindElement(RemoveItem);
        element.Click();
    }
}