using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using BoDi;
using Dummy_Project.Wrapper;


namespace Dummy_Project
{
    [Binding]

    public class Hooks
    {
        [BeforeScenario()]

        public static void Startup(IObjectContainer container)

        {
            var webdriver = new ChromeDriver();
            webdriver.Manage().Window.Maximize();
            container.RegisterInstanceAs<IWebDriver>(webdriver);
            container.RegisterInstanceAs<WrappedWebDriver>(new WrappedWebDriver(webdriver));
        }
        [AfterScenario()]
        public static void teardown(IWebDriver webDriver)
        {
            webDriver.Quit();

        }

    }
}
