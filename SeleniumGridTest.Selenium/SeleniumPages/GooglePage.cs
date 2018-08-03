using OpenQA.Selenium;
using SeleniumGridTest.Selenium.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Selenium.SeleniumPages
{
    public class GooglePage : BasePage
    {
        public IWebDriver Instance  {get;set;}
        public GooglePage(IWebDriver driver) : base(driver)
        {
            Instance = driver;
        }
        string partUrl = "webhp";

        public IWebElement txtFind => GetElement(By.Name("q"));
        public IWebElement btnFind => GetElement(By.Name("q"));

        public GooglePage OpenGooglePage()
        {
            string BASE_URL = ConfigurationManager.AppSettings["BaseURL"];
           
            NavigateTo(BASE_URL + partUrl);
            return new GooglePage(Instance);
        }

        public GooglePage FindGoogle(string text)
        {
            var element = txtFind;

            Type(txtFind,text);
            Submit(txtFind);

            return new GooglePage(Instance);
        }
    }
}
