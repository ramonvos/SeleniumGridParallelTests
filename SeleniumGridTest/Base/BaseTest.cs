using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using SeleniumGridTest.AdvancedReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Base
{
    public class BaseTest
    {
        public static IWebDriver driver;
       //public static RemoteWebDriver driver { get; set; }

        public static string BASE_URL = "https://www.google.com.br";

        [OneTimeSetUp]
        public void SetUpTest() 
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--headless");
       
            //DesiredCapabilities capability = DesiredCapabilities.Chrome();
            //capability.SetCapability("platform", "WIN10");
            //capability.SetCapability("browserName", "chrome");
            //capability.SetCapability("platformName", "WIN10");
            //capability.SetCapability("maxInstances", "5");
            ////capability.SetCapability(ChromeOptions.Capability, "--headless");
            ////capability.SetCapability("version", "latest");
            //////capability.SetCapability("gridlasticUser", USERNAME);
            //////capability.SetCapability("gridlasticKey", ACCESS_KEY);
            ////capability.SetCapability("video", "True");
            //driver = new RemoteWebDriver(
            //  new Uri("http://192.168.0.104:11661/wd/hub"), capability, TimeSpan.FromSeconds(600));




            //driver = new RemoteWebDriver(new Uri("http://192.168.0.104:4444/wd/hub"), options);


            driver = new ChromeDriver(chromeOptions());
            //AdvancedReport.Reporter.CreateManagerReport();
            AdvancedReport.Reporter.CreateReport();

        }
        [OneTimeTearDown]
        public void TearDownTest()
        {
            
            AdvancedReport.Reporter.CreateManagerReport();
            AdvancedReport.Reporter.GenerateReport();
            //driver.Close();
            driver.Quit();
        }
        [SetUp]
        public void SetUpTestCase()
        {
            AdvancedReport.Reporter.AddTest();
        }

        [TearDown]
        public void TearDownTestCase()
        {
            


            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                    ? ""
                    : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            Reporter.Log(logstatus, "Test ended with " + logstatus + stacktrace);

        }


        public ChromeOptions chromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            return options;
        }
    }
}
