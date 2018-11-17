using OpenQA.Selenium;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Selenium.SeleniumPages
{
    public class DeleteBugSPage : DriverFactory
    {
        public IWebDriver Instance { get; set; }
        public DeleteBugSPage(IWebDriver driver) : base(driver)
        {
            Instance = driver;
        }

        public IWebElement linkVerTarefas => Instance.FindElement(By.LinkText("View Issues"));

        public IWebElement ckSelecionarBug => Instance.FindElement(By.XPath("//table[@id='buglist']/tbody/tr/td/div/label/span"));


        public IWebElement linkDetalharBug => Instance.FindElement(By.XPath("//table[@id='buglist']/tbody/tr/td[4]/a"));

        public IWebElement ddlSelecionarAcaoRemover => Instance.FindElement(By.Name("action"));

        public IWebElement btnOk => Instance.FindElement(By.XPath("//input[@value='OK']"));

        public IWebElement btnConfirmar => Instance.FindElement(By.XPath("//input[@value='Delete Issues']"));

        public IWebElement btnApagar => Instance.FindElement(By.XPath("//input[@value='Delete']"));

        public IWebElement msgSucesso => Instance.FindElement(By.XPath("//*[@id='bug_action']/div/div[1]/h4"));
        public DeleteBugSPage OpenViewTask()
        {
            //linkVerTarefas.ClickLink();
            return new DeleteBugSPage(Instance);
        }

        public DeleteBugSPage DeleteBugFromList()
        {
            string action = "Delete";



            //ckSelecionarBug.CheckboxChecked();

            //ddlSelecionarAcaoRemover.SelectText(action);

            //btnOk.ClickButton();

            //btnConfirmar.ClickButton();
            return new DeleteBugSPage(Instance);
        }


        public DeleteBugSPage DeleteBugFromDetails()
        {

            //linkDetalharBug.ClickLink();

            //btnApagar.ClickButton();
            //btnConfirmar.ClickButton();

            return new DeleteBugSPage(Instance);
        }
    }
}
