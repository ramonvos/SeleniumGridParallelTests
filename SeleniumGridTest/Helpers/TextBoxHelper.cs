using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest
{
    public static class TextBoxHelper
    {   
        public static void TypeInTextBox(this IWebElement element, string value)
        {
            if (value.HasValue())
            {
                element.SendKeys(value);
            }

        }

        public static void ClearTextBox(this IWebElement element)
        {
            element.Clear();
        }

        public static void TypeInTextBoxWithMask(this IWebElement element, string text)
        {
            int aux = 0; 
            while(element.Text != text && aux < 10)
            {
                element.ClearTextBox();
                element.TypeInTextBox(text);
                aux++;
            }
            
        }

        public static String GetTextInTextBox(this IWebElement element)
        {
            return element.Text;
        }
        public static String GetValueInTextBox(this IWebElement element)
        {
            return element.GetAttribute("value");
        }
    }
}
