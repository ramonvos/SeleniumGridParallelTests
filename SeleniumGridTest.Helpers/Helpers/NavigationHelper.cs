using OpenQA.Selenium;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Helpers.Helpers
{
    public class NavigationHelper : DriverFactory
    {
        private IWebDriver Instance { get; set; }
        private IWebElement element;
        public NavigationHelper(IWebDriver driver) : base(driver)
        {
            Instance = driver;

        }
        public void NavigateToPage(string url)
        {
            Instance.Navigate().GoToUrl(url);
        }
    }
}
