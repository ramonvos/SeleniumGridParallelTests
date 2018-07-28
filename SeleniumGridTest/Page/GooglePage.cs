using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumGridTest.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumGridTest.Page
{
    public class GooglePage 
    {

        

        IWebElement txtFind => BaseTest.driver.FindElement(By.Name("q"));
        IWebElement btnFind => BaseTest.driver.FindElement(By.Name("q"));

        public GooglePage OpenGooglePage()
        {
            BaseTest.driver.Navigate().GoToUrl(BaseTest.BASE_URL);

            return new GooglePage();
        }

        public GooglePage FindGoogle(string text)
        {
            txtFind.SendKeys(text);
            btnFind.Submit();

            

            
            return new GooglePage();
        }
    }
}
