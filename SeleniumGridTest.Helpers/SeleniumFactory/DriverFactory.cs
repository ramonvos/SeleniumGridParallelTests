using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Helpers.SeleniumFactory
{
    public class DriverFactory
    {
        //private IWebDriver _driver;

        //public DriverFactory()
        //{
        //    _driver = null;
        //    //BASE_URL = ConfigurationManager.AppSettings["Base_URL"];
        //}


        private IWebDriver _driver;

        public DriverFactory(IWebDriver driver) 
        {
            _driver = driver;
        }


        public IWebDriver Initialize(string browser)
        {
            double timeout = Convert.ToDouble(ConfigurationManager.AppSettings["DefaultTimeout"]);

            if (_driver == null)
            {
                if (browser.Equals("Chrome"))
                {
                    if (Convert.ToBoolean(ConfigurationManager.AppSettings["Remote"]))
                    {
                        _driver = Chrome.Build();
                    }
                    else
                    {
                        _driver = Chrome.BuildLocal();
                    }
                }

                else if (browser.Equals("Firefox"))
                {
                    _driver = Firefox.Build();
                }

                else
                {
                    throw new Exception("Driver não suportado!");
                }
            }

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeout);
            _driver.Manage().Window.Maximize();
            return _driver;
        }

    }

    static class Chrome
    {
        public static RemoteWebDriver Build()
        {
            Uri uri = new Uri(ConfigurationManager.AppSettings["SeleniumServerURL"]);

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("download.default_directory", AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "Downloads"));
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            chromeOptions.AddArguments("--start-maximized");
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("lang=en-US");


            return new RemoteWebDriver(uri, chromeOptions);
        }

        public static ChromeDriver BuildLocal()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("e.default_directory", AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "Downloads"));
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            chromeOptions.AddArguments("--start-maximized");
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--start-maximized");
            chromeOptions.AddArguments("lang=en-US");

            return new ChromeDriver(chromeOptions);
        }


    }
    static class Firefox
    {
        public static RemoteWebDriver Build()
        {
            Uri uri = new Uri(ConfigurationManager.AppSettings["SeleniumServerURL"]);

            var firefoxOptions = new FirefoxOptions();

            return new RemoteWebDriver(uri, firefoxOptions);
        }
    }
}

