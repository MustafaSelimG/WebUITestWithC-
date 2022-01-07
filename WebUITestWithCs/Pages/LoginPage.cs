using BDDTest.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace BDDTest.Pages
{
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.get(), this);
        }

        [FindsBy(How = How.Id, Using = "ap_email")]
        private IWebElement emailBar; 

        [FindsBy(How = How.Id, Using = "continue")]
        private IWebElement nextButton; 

        [FindsBy(How = How.Id, Using = "ap_password")]
        private IWebElement passwordBar;


        public void login(String email,String password)
        {
            emailBar.SendKeys(email);
            nextButton.Click();
            passwordBar.SendKeys(password);
            passwordBar.SendKeys(Keys.Enter);
        }
    }
}
