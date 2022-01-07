using BDDTest.Pages;
using BDDTest.Utils;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDDTest
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext context;

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            context = scenarioContext;
        }

        HomePage homepage = new HomePage();
        LoginPage loginpage = new LoginPage();
        SearchResultPage searchresultpage = new SearchResultPage();
        ProductPage productpage = new ProductPage();
        BasketPage basketpage = new BasketPage(); 

        [Given(@"I launch the website")]
        public void GivenILaunchTheWebsite()
        {
            Driver.get().Navigate().GoToUrl("https://www.amazon.com.tr");
            Driver.get().Manage().Window.Maximize();
            Driver.get().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [Given(@"I accept the cookies")]
        public void GivenIAcceptTheCookies()
        {
            homepage.acceptCookies();
        }

        [When(@"navigate the login page")]
        public void WhenNavigateTheLoginPage()
        {
            homepage.navigateToLoginpage();
        }

        [When(@"I enter following details")]
        public void WhenIEnterFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpage.login((string)data.Email, (string)data.Password);

        }

        [Given(@"I verify the homepage is open")]
        public void GivenIVerifyTheHomepageIsOpen()
        {
            homepage.verifyHomepage();
        }

        [When(@"I search for electronics from categories")]
        public void WhenISearchForElectronicsFromCategories()
        {
            homepage.searchForElectronics();
        }

        [When(@"I click the subcategory sound systems")]
        public void WhenIClickTheSubcategorySoundSystems()
        {
            searchresultpage.clickSoundSystems();
        }

        [When(@"I click first product from best seller")]
        public void WhenIClickFirstProductFromBestSeller()
        {
            searchresultpage.clickTheProduct();
        }

        [When(@"I add product the basket")]
        public void WhenIAddProductTheBasket()
        {
            productpage.addProductToBasket();
            productpage.openBasketPage();
        }

        [When(@"I delete product from the basket")]
        public void WhenIDeleteProductFromTheBasket()
        {
            basketpage.deleteProductFromBasket();
        }

        [Then(@"basket should be empty")]
        public void ThenBasketShouldBeEmpty()
        {
            basketpage.verifyBasketIsEmpty();
        }

        [When(@"I open the deals of the day")]
        public void WhenIOpenTheDealsOfTheDay()
        {
            homepage.openDealsOfTheDay();
        }

        [When(@"I filter the laptops")]
        public void WhenIFilterTheLaptops()
        {
            searchresultpage.filterLaptops();
        }

        [When(@"I click the first product")]
        public void WhenIClickTheFirstProduct()
        {
            searchresultpage.clickTheFirstProduct();
        }

        [Then(@"product price should be equal")]
        public void ThenProductPriceShouldBeEqual()
        {
            productpage.verifyThePrice();
        }


    }
}
