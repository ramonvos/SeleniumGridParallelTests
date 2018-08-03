using OpenQA.Selenium;
using SeleniumGridTest.AdvancedReport;
using SeleniumGridTest.Selenium.SeleniumComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Selenium.SeleniumFactory
{
    public class BasePage : SeleniumActions
    {
        private IWebDriver _driver;

        public BasePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void Refresh()
        {
            _driver.Navigate().Refresh();
        }

        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);

            
        }

        public void AcceptAlert()
        {
            _driver.SwitchTo().Alert().Accept();
        }

        public void DismissAlert()
        {
            _driver.SwitchTo().Alert().Dismiss();
        }
    }
}
