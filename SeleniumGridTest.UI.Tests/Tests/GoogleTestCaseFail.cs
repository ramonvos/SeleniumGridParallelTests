using NUnit.Framework;
using SeleniumGridTest.Selenium.SeleniumPages;
using SeleniumGridTest.UI.Tests.TestBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.UI.Tests.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class GoogleTestCaseFail : BaseTest
    {

        [Test, Description("Desc"), Category("SmokeTest")]
        public void FindGooglePageSuccess4()
        {
            //AdvancedReport.Reporter.AddTest();

            string text = "Selenium lesson page";
            GooglePage page = new GooglePage(_driver);

            page.OpenGooglePage().FindGoogle(text);

            Assert.That(_driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");

        }


        [Test, Description("Desc"), Category("SmokeTest")]
        public void FindGooglePageSuccess5()
        {
            //AdvancedReport.Reporter.AddTest();

            string text = "Selenium lesson page";
            GooglePage page = new GooglePage(_driver);

            page.OpenGooglePage().FindGoogle(text);

            Assert.That(_driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");

        }

        [Test, Description("Desc"), Category("SmokeTest")]
        public void FindGooglePageSuccess6()
        {
            //AdvancedReport.Reporter.AddTest();

            string text = "Selenium lesson page";
            GooglePage page = new GooglePage(_driver);

            page.OpenGooglePage().FindGoogle(text);

            Assert.That(_driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");

        }


    }
}
