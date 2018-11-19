using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Helpers.Helpers
{
    public class ComboBoxHelper : DriverFactory
    {
        private IWebDriver Instance { get; set; }
        
        public ComboBoxHelper(IWebDriver driver) : base(driver)
        {
            Instance = driver;
        }


        public void SelectText(IWebElement element, string text)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }

    }
}
