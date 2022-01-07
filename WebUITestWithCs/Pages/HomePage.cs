using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using BDDTest.Utils;

namespace BDDTest.Pages
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.get(), this);
        }

        [FindsBy(How = How.Id, Using = "sp-cc-accept")]
        private IWebElement cookiesAcceptButton; 

        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        private IWebElement accountSection; 

        [FindsBy(How = How.Id, Using = "gw-layout")]
        private IWebElement homepageLayout;

        [FindsBy(How = How.Id, Using = "searchDropdownBox")]
        private IWebElement searchDropdownBox;

        [FindsBy(How = How.XPath, Using = "//option[@value='search-alias=electronics']")]
        public IWebElement electronicsCategory;

        [FindsBy(How = How.Id,Using = "nav-search-submit-button")]
        public IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//a[@data-csa-c-content-id='nav_cs_gb']")]
        public IWebElement dealsOfTheDay;

        public void acceptCookies() => cookiesAcceptButton.Click();

        public void navigateToLoginpage() => accountSection.Click();

        public void verifyHomepage() => Assert.That(homepageLayout.Displayed);

        internal void searchForElectronics()
        {
            searchDropdownBox.Click();
            electronicsCategory.Click();
            searchButton.Click();
        }

        public void openDealsOfTheDay() => dealsOfTheDay.Click();
    }
}
