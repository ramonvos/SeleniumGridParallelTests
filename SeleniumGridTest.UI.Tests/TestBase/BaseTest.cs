﻿using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumGridTest.AdvancedReport;
using SeleniumGridTest.Selenium.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.UI.Tests.TestBase
{
    public class BaseTest
    {
        protected IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            if (_driver == null)
            {
                _driver = new DriverFactory().Initialize(ConfigurationManager.AppSettings["DefaultBrowser"]);
                _driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["BaseURL"]);
            }
            Reporter.CreateReport();
        }

        [SetUp]
        public void SetupTest()
        {
           

            Console.WriteLine(TestContext.CurrentContext.Test.FullName);

            Reporter.AddTest();

        
        }

        [TearDown]
        public void TearDownTest()
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
                    Reporter.LogFail(logstatus.ToString() + " Teste falhou!");
                    break;
                //case TestStatus.Inconclusive:
                //    logstatus = Status.Warning;
                //    log.LogFail(logstatus.ToString());
                //    break;
                //case TestStatus.Skipped:
                //    logstatus = Status.Skip;
                //    log.LogFail(logstatus.ToString());
                //    break;
                default:
                    logstatus = Status.Pass;
                    Reporter.LogPass(logstatus.ToString() + " Teste passou!");
                    break;
            }

            // Reporter.Log(logstatus, "Test ended with " + logstatus + stacktrace);

            Reporter.GenerateReport();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}