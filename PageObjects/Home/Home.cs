using Dummy_Project.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Dummy_Project.PageObjects.Home
{
    internal class Home
    {

        private readonly IWebDriver _webDriver;
        private readonly WrappedWebDriver _wrappedWebDriver;


        public Home(IWebDriver webDriver,WrappedWebDriver wrappedWebDriver)
        {
            _webDriver = webDriver;
            _wrappedWebDriver = wrappedWebDriver;
        }

        private static readonly By FlyingNinja = By.CssSelector("#main > div.columns-3 > ul > li.product.type-product.post-54.status-publish.first.instock.product_cat-posters.has-post-thumbnail.sale.taxable.shipping-taxable.purchasable.product-type-simple > div > a.button.product_type_simple.add_to_cart_button.ajax_add_to_cart");
        private static readonly By FlyingNinjaProduct = By.CssSelector("#main > div.columns-3 > ul > li.product.type-product.post-54.status-publish.first.instock.product_cat-posters.has-post-thumbnail.sale.taxable.shipping-taxable.purchasable.product-type-simple > div > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link");
        private static readonly By HappyNinja = By.CssSelector("#main > div.columns-3 > ul > li.product.type-product.post-26.status-publish.instock.product_cat-clothing.product_cat-t-shirts.has-post-thumbnail.taxable.shipping-taxable.purchasable.product-type-simple > div > a.button.product_type_simple.add_to_cart_button.ajax_add_to_cart");

        private static readonly By HappyNinjaProduct = By.CssSelector("#main > div.columns-3 > ul > li.product.type-product.post-26.status-publish.instock.product_cat-clothing.product_cat-t-shirts.has-post-thumbnail.taxable.shipping-taxable.purchasable.product-type-simple > div > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link");
        private static readonly By PatientNinja = By.CssSelector("#main > div.columns-3 > ul > li.product.type-product.post-66.status-publish.last.instock.product_cat-clothing.product_cat-hoodies.has-post-thumbnail.taxable.shipping-taxable.purchasable.product-type-simple > div > a.button.product_type_simple.add_to_cart_button.ajax_add_to_cart");

        private static readonly By PatientNinjaProduct = By.CssSelector("#main > div.columns-3 > ul > li.product.type-product.post-66.status-publish.last.instock.product_cat-clothing.product_cat-hoodies.has-post-thumbnail.taxable.shipping-taxable.purchasable.product-type-simple > div > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link");
        private static readonly By WooAlbum = By.CssSelector("#main > div.columns-3 > ul > li.product.type-product.post-15.status-publish.last.instock.product_cat-albums.product_cat-music.has-post-thumbnail.virtual.taxable.purchasable.product-type-simple > div > a.button.product_type_simple.add_to_cart_button.ajax_add_to_cart");

        private static readonly By WooAlbumProject = By.CssSelector("#main > div.columns-3 > ul > li.product.type-product.post-15.status-publish.last.instock.product_cat-albums.product_cat-music.has-post-thumbnail.virtual.taxable.purchasable.product-type-simple > div > a.woocommerce-LoopProduct-link.woocommerce-loop-product__link");

        public void GotoPage()
        {
             _webDriver.Navigate().GoToUrl("https://cms.demo.katalon.com/");
            
        }

        public void AddtoCartFlyingNinja()
        {
            var webElement = _wrappedWebDriver.WaitForAndFindElement(FlyingNinjaProduct);
            _wrappedWebDriver.Hover(webElement);
            var element = _wrappedWebDriver.Wait(d => d.FindElement(FlyingNinja));
            element.Click();
            Thread.Sleep(250);

        }

        public void AddtoCartHappyNinja()
        {
            var webElement = _wrappedWebDriver.WaitForAndFindElement(HappyNinjaProduct);
            _wrappedWebDriver.Hover(webElement);
            var element = _wrappedWebDriver.Wait(d => d.FindElement(HappyNinja));
            element.Click();
            Thread.Sleep(250);
        }
        public void AddtoCartPatientNinja()
        {
            var webElement = _wrappedWebDriver.WaitForAndFindElement(PatientNinjaProduct);
            _wrappedWebDriver.Hover(webElement);
            var element = _wrappedWebDriver.Wait(d => d.FindElement(PatientNinja));
            element.Click();
            Thread.Sleep(250);

        }
        public void AddtoCartWooAlbum()
        {
            var webElement = _wrappedWebDriver.WaitForAndFindElement(WooAlbumProject);
            _wrappedWebDriver.Hover(webElement);
            var element = _wrappedWebDriver.Wait(d => d.FindElement(WooAlbum));
            element.Click();
            Thread.Sleep(250);
        }

    }
}
