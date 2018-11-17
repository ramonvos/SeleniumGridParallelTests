using OpenQA.Selenium;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Helpers.Helpers
{
    public class ButtonHelper : DriverFactory
    {
        public object ProjectUtilities { get; private set; }

        private IWebDriver Instance { get; set; }
        private IWebElement element;

        public ButtonHelper(IWebDriver driver) : base(driver)
        {
            Instance = driver;
        }





        public void ClickButton(IWebElement element)
        {
            SeleniumGetMethods.GetElement(element);
            //Reporter.AddTestInfo(GetCurrentMethod() + " => " + "Elemento encontrado: " + element.GetElementAttribute());
            element.Click();
        }

        public static bool IsButtonEnabled(IWebElement element)
        {
            SeleniumGetMethods.GetElement(element);
            return element.Enabled;
        }

        public string GetButtonText(IWebElement element)
        {
            SeleniumGetMethods.GetElement(element);

            if (element.GetAttribute("value") == null)
                return string.Empty;
            return element.GetAttribute("value");
        }
    }
}
