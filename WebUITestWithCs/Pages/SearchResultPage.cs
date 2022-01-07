using BDDTest.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BDDTest.Pages
{
    public class SearchResultPage
    {
        public SearchResultPage()
        {
            PageFactory.InitElements(Driver.get(), this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@title='Ses Sistemleri ve Hoparlörler']")]
        private IWebElement soundSystemButton;

        [FindsBy(How = How.CssSelector, Using = ".octopus-pc-item-block.octopus-pc-asin-block")]
        private IWebElement product;

        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[14]")]
        private IWebElement laptopsFilter;

        [FindsBy(How = How.CssSelector, Using = ".DealContent-module__truncate_sWbxETx42ZPStTc9jwySW")]
        private IWebElement firstProduct;

        public void clickSoundSystems()
        {
            Helper.scrollToElement(soundSystemButton);
            soundSystemButton.Click();
        }

        public void clickTheProduct()
        {
            Helper.scrollToElement(product);
            product.Click();
        }

        public void filterLaptops()
        {
            Helper.scrollToElement(laptopsFilter);
            laptopsFilter.Click();
        }

        public void clickTheFirstProduct()
        {
            Helper.scrollToElement(firstProduct);
            firstProduct.Click();
        }
    }
}
