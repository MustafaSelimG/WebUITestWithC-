using BDDTest.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BDDTest.Pages
{
    public class ProductPage
    {
        public ProductPage()
        {
            PageFactory.InitElements(Driver.get(), this);
        }

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        private IWebElement addBasketButton; 

        [FindsBy(How = How.Id, Using = "nav-cart-count-container")]
        private IWebElement basketButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='corePrice_feature_div']/div/span/span[2]")]
        private IWebElement productPrice;

        [FindsBy(How = How.CssSelector, Using = ".sc-product-price.a-text-bold")]
        private IWebElement basketPrice;

        public void addProductToBasket() => addBasketButton.Click();

        public void openBasketPage() => basketButton.Click();

        public void verifyThePrice()
        {
            Helper.scrollToElement(productPrice);
            string product = productPrice.Text.Replace(" ", ""); 
            addProductToBasket();
            openBasketPage();

            string basket = basketPrice.Text.Replace(" ", "");
            Assert.AreEqual(basket, product);
        }

    }
}
