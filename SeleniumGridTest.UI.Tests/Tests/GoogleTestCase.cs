using NUnit.Framework;
using SeleniumGridTest.Selenium.SeleniumPages;
using SeleniumGridTest.UI.Tests.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.UI.Tests.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class GoogleTestCase : TestBase
    {

        //[Test, Description("Desc"), Category("Critical")]
        //public void FindGooglePageSuccess1()
        //{
        //    //AdvancedReport.Reporter.AddTest();
        //    int level = Convert.ToInt32(ConfigurationManager.AppSettings["LevelOfParallelism"]);
        //    string text = "Selenium lesson page";
        //    GooglePage page = new GooglePage(_driver);

        //    page.OpenGooglePage().FindGoogle(text);
            
        //    Assert.That(_driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");

        //}


        //[Test, Description("Desc"), Category("Critical")]
        //public void FindGooglePageSuccess2()
        //{
        //    //AdvancedReport.Reporter.AddTest();

        //    string text = "Selenium lesson page";
        //    GooglePage page = new GooglePage(_driver);

        //    page.OpenGooglePage().FindGoogle(text);

        //    Assert.That(_driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");

        //}

        //[Test, Description("Desc"), Category("Critical")]
        //public void FindGooglePageSuccess3()
        //{
        //    //AdvancedReport.Reporter.AddTest();

        //    string text = "Selenium lesson page";
        //    GooglePage page = new GooglePage(_driver);

        //    page.OpenGooglePage().FindGoogle(text);

        //    Assert.That(_driver.PageSource.Contains("Free Selenium Tutorials - Guru99"), Is.EqualTo(true), "Erro ao validar o texto!");

        //}


    }
}
