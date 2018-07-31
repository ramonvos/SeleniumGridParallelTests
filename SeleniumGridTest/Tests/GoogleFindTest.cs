using AventStack.ExtentReports;
using NUnit.Framework;
using SeleniumGridTest.AdvancedReport;
using SeleniumGridTest.Base;
using SeleniumGridTest.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumGridTest.Tests
{
    [TestFixture]
    public class GoogleFindTest : BaseTest
    {
        
        [Test,Description("Desc"), Category("Critical")]
        public void FindGooglePageSuccess1()
        {   
            AdvancedReport.Reporter.AddTest();

            string text = "Selenium lesson page";
            GooglePage page = new GooglePage();

            page.OpenGooglePage().FindGoogle(text);

            Reporter.TestInfo();
            Reporter.TestInfo();
            Reporter.TestInfo();
            Reporter.TestInfo();
            Reporter.TestInfo();

            Assert.That(BaseTest.driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true),"Erro ao validar o texto!");
            Reporter.TestPass();

        }

        [Test, Description("Desc"), Category("Smoke Test")]
        public void FindGooglePageFail1()
        {
            

            string text = "Selenium lesson page";
            GooglePage page = new GooglePage();

            page.OpenGooglePage().FindGoogle(text);
            Reporter.TestInfo();

            Reporter.TestFail();

            Assert.That(BaseTest.driver.PageSource.Contains("Free Selium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o label");
           
            
            

        }

        [Test, Description("Optional Description"), Category("Smoke Test")]
        public void FindGooglePageIntentionalEx()
        {


            string text = "Selenium lesson page";
            GooglePage page = new GooglePage();

            page.OpenGooglePage().FindGoogle(text);
            Reporter.TestInfo();

            
            try
            {
                Assert.That(BaseTest.driver.PageSource.Contains("Free Selium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o label");
            }
            catch (Exception ex)
            {
                Reporter.exceptionLog(ex);
                
            }
            




        }


        [Test, Description("Optional Description"), Category("Exploratory")]
        public void FindGooglePageSuccess2()
        {
            

            string text = "Selenium lesson page";
            GooglePage page = new GooglePage();

            page.OpenGooglePage().FindGoogle(text);

            Reporter.TestPass();
            Assert.That(BaseTest.driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");
            

        }
        [Test, Description("Optional Description"), Category("Exploratory")]
        public void FindGooglePageSuccess3()
        {

            string text = "Selenium lesson page";
            GooglePage page = new GooglePage();

            page.OpenGooglePage().FindGoogle(text);
            Reporter.TestPass();
            Assert.That(BaseTest.driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");
            

        }

        [Test, Description("Optional Description"), Category("Exploratory")]
        public void FindGooglePageSuccess4()
        {

            string text = "Selenium lesson page";
            GooglePage page = new GooglePage();

            page.OpenGooglePage().FindGoogle(text);
            Reporter.TestPass();
            Assert.That(BaseTest.driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");
            

        }

        [Test, Description("Optional Description"), Category("Exploratory")]
        public void FindGooglePageSuccess5()
        {
            

            string text = "Selenium lesson page";
            GooglePage page = new GooglePage();

            page.OpenGooglePage().FindGoogle(text);
            Reporter.TestPass();
            Assert.That(BaseTest.driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");
            

        }

        [Test, Description("Optional Description"), Category("Exploratory")]
        public void FindGooglePageSuccess6()
        {

            string text = "Selenium lesson page";
            GooglePage page = new GooglePage();

            page.OpenGooglePage().FindGoogle(text);
            Reporter.TestPass();
            Assert.That(BaseTest.driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");
            

        }
    }
}
