using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumGridTest.Helpers.AdvancedReport;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Helpers.Helpers
{
    public class SeleniumGetMethods : DriverFactory
    {
        private IWebDriver _driver;
        public SeleniumGetMethods(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        public static bool GetElement(IWebElement element)
        {
            try
            {

                if (element.Displayed || element.Enabled)
                {
                    return true;

                }
                return false;

            }
            catch (NoSuchElementException ex)
            {
                //Reporter.AddTestInfo(ProjectUtilities.Utilities.GetCurrentMethod() + " => " + "ERRO! Elemento esperado não apareceu." + "<pre>" + ex.Message + "</pre>");
                //Reporter.TestException(ex);
                Assert.IsTrue(false);
                return false;
            }

        }

        public  bool IsElementPresent(By locator)
        {

            try
            {
                return  _driver.FindElement(locator).Displayed;
            }
            catch (NoSuchElementException)
            {

                return false;
            }
        }
    }
}
