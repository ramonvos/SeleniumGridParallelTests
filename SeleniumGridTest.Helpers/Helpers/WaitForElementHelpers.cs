using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Helpers.Helpers
{
    public class WaitForElementHelpers : DriverFactory
    {
        public IWebDriver Instance { get; set; }
        public WaitForElementHelpers(IWebDriver driver) : base(driver)
        {
            Instance = driver;
        }

        static WebDriverWait wait;
        public static int timeout = Convert.ToInt32(ConfigurationManager.AppSettings["DEFAULT_TIMEOUT"]);

        public void WaitForElementDisplayed(By locator)
        {
            try
            {
                wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(timeout));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch (NoSuchElementException ex)
            {
                Assert.Fail("{0} No Such Element.", ex);

            }

        }

        public void WaitForElementClickable(By locator)
        {
            try
            {

                wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(timeout));
                IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));

            }
            catch (NoSuchElementException ex)
            {

                Assert.Fail("{0} No Such Element.", ex);
            }
        }

        public void WaitForElementClickable(IWebElement element)
        {
            try
            {
                wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(timeout));
                element = wait.Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (NoSuchElementException ex)
            {

                Assert.Fail("{0} No Such Element.", ex);
            }

        }
        public void WaitForTextInElement(IWebElement element, string text)
        {
            try
            {
                wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(timeout));
                wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
            }
            catch (NoSuchElementException ex)
            {

                Assert.Fail("{0} No Such Element.", ex);
            }

        }
    }
}
