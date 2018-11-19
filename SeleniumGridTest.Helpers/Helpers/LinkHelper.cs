using OpenQA.Selenium;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Helpers.Helpers
{
    public class LinkHelper : DriverFactory
    {
        private IWebDriver Instance { get; set; }
        private IWebElement element;
        public LinkHelper(IWebDriver driver) : base(driver)
        {
            Instance = driver;
        }
        

        public void ClickLink(IWebElement element)
        {
            SeleniumGetMethods.GetElement(element);
            element.Click();
        }
    }
}
