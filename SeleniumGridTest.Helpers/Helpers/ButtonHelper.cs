using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Helpers.Helpers
{
    public static class ButtonHelper
    {
        public static object ProjectUtilities { get; private set; }

        public static void ClickButton(this IWebElement element)
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

        public static string GetButtonText(IWebElement element)
        {
            SeleniumGetMethods.GetElement(element);

            if (element.GetAttribute("value") == null)
                return string.Empty;
            return element.GetAttribute("value");
        }
    }
}
