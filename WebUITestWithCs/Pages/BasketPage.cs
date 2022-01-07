using BDDTest.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BDDTest.Pages
{
    public class BasketPage
    {
        public BasketPage()
        {
            PageFactory.InitElements(Driver.get(), this);
        }


        [FindsBy(How = How.XPath, Using = "//input[@value='Sil']")]
        private IWebElement deleteButton; 

        [FindsBy(How = How.CssSelector, Using = ".a-spacing-mini.a-spacing-top-base")]
        private IWebElement emptyBasketTitle; 


        public void deleteProductFromBasket()
        { 
            deleteButton.Click();
        }

        public void verifyBasketIsEmpty()
        {
            string actual = emptyBasketTitle.Text;
            Assert.AreEqual("Amazon sepetiniz boş.", actual);
        }


    }
}
