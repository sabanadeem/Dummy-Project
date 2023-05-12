using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Dummy_Project.Wrapper
{
    internal class WrappedWebDriver
    {
        private readonly IWebDriver _webDriver;

        public WrappedWebDriver(IWebDriver webDriver)
        {
            _webDriver = webDriver;

        }

        // T : it define a generic return
        // (Func<T?>) : function that return generic type
        // Wait<T> : wait until T is not default and then return it 
        // ? : to make nullable
        public T Wait<T>(Func<IWebDriver, T?> condition)
        {
            // creating variable wait class to driver to be visible
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(25));
            return wait.Until(condition)!;
            // ! :  to suppress warnings

        }

        public IWebElement WaitForAndFindElement(By locator)
        {
            return Wait(driver => driver.FindElement(locator));
        }

        public void Hover(IWebElement webElement)
        {
            new Actions(_webDriver).MoveToElement(webElement).Perform();
        }

    }
}
