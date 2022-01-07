using OpenQA.Selenium;
using System;

namespace BDDTest.Utils
{
    public class Helper
    {
        private static WebDriver driver = Driver.get();

        public static void scrollToElement(IWebElement element)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("arguments[0].scrollIntoView(false);", element);
        }

    }
}
