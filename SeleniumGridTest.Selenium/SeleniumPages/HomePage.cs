using OpenQA.Selenium;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Selenium.SeleniumPages
{
    public class HomePage : DriverFactory
    {
        public IWebDriver Instance { get; set; }
        public HomePage(IWebDriver driver) : base(driver)
        {
            Instance = driver;
        }

        public IWebElement containerPrincipal => Instance.FindElement(By.Id("main-container"));
    }
}
