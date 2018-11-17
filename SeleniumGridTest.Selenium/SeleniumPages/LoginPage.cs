using OpenQA.Selenium;
using SeleniumGridTest.Helpers;
using SeleniumGridTest.Helpers.Helpers;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Selenium.SeleniumPages
{
    public class LoginPage : DriverFactory
    {
        
        public IWebDriver Instance { get; set; }
        TextBoxHelper objText = null;
        ButtonHelper objButton = null;
        LinkHelper objLink = null;


        public LoginPage(IWebDriver driver) : base(driver)
        {
            Instance = driver;
            objText = new TextBoxHelper(Instance);
            objButton = new ButtonHelper(Instance);
            objLink = new LinkHelper(Instance);
        }

        public IWebElement txtLogin => Instance.FindElement(By.Id("username"));

        public IWebElement txtPass => Instance.FindElement(By.Id("password"));

        public IWebElement btnEntrar => Instance.FindElement(By.XPath("//input[@value='Login']"));

        //public IWebElement msgErroLogin => Instance.FindElement(By.XPath("//div[@id='main-container']/div/div/div/div/div[4]/p"));
        public IWebElement msgErroLogin => Instance.FindElement(By.XPath("//div[@id='main-container']/div/div/div/div/div[4]"));


        public LoginPage NavigateToLoginPage()
        {
            Instance.Manage().Cookies.DeleteAllCookies();
            NavigationHelper objNav = new NavigationHelper(Instance);
            objNav.NavigateToPage(ConfigurationManager.AppSettings["URL_BASE"] + "login_page.php");

            return new LoginPage(Instance);
        }

        public LoginPage LogIn()
        {
            string user = ConfigurationManager.AppSettings["username"];
            string pass = ConfigurationManager.AppSettings["password"];
            objText.TypeInTextBox(txtLogin,user);
            objButton.ClickButton(btnEntrar);

            objText.TypeInTextBox(txtPass,pass);
            objButton.ClickButton(btnEntrar);

            return new LoginPage(Instance);


        }

        public LoginPage LogIn(string user, string pass)
        {
            objText.TypeInTextBox(txtLogin, user);
            objButton.ClickButton(btnEntrar);
            if (user.HasValue())
            {
                objText.TypeInTextBox(txtPass, pass);
                objButton.ClickButton(btnEntrar);
            }

            return new LoginPage(Instance);
        }

        public LoginPage LogInDataDriven(string key)
        {
            String fileName = ConfigurationManager.AppSettings["TestDataSheetPath"];

            //ExcelUtil util = new ExcelUtil();

            //util.PopulateInCollection(fileName);

            //String userName = util.ReadData(2, "Column0");//Login
            //String pass = util.ReadData(2, "Column1");//senha 01

            //txtLogin.TypeInTextBox(userName);
            //btnEntrar.ClickButton();

            //txtPass.TypeInTextBox(pass);
            //btnEntrar.ClickButton();

            return new LoginPage(Instance);


        }

    }
}
