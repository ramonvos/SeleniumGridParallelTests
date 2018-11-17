using OpenQA.Selenium;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;

namespace SeleniumGridTest.Helpers
{
    public class TextBoxHelper : DriverFactory
    {

        private IWebDriver Instance { get; set; }
        private IWebElement element;

        public TextBoxHelper(IWebDriver driver) : base(driver)
        {
            Instance = driver;
        }

        public void TypeInTextBox(IWebElement element, string value)
        {
            if (value.HasValue())
            {
                element.SendKeys(value);
            }

        }

        public void ClearTextBox(IWebElement element)
        {
            element.Clear();
        }

        public void TypeInTextBoxWithMask(IWebElement element, string text)
        {
            int aux = 0; 
            while(element.Text != text && aux < 10)
            {
                ClearTextBox(element);
                TypeInTextBox(element,text);
                aux++;
            }
            
        }

        public String GetTextInTextBox(IWebElement element)
        {
            return element.Text;
        }
        public  String GetValueInTextBox(IWebElement element)
        {
            return element.GetAttribute("value");
        }
    }
}
