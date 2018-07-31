using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.AdvancedReport
{
    public static class Reporter
    {
        public static ExtentReports extent;
        public static ExtentTest test;
        public static KlovReporter klov;

        public static string pathToReport = @"C:\Users\ramon\source\repos\SeleniumGridTest\SeleniumGridTest\bin\Debug\";
        public static string reportName = "RelatorioDeTestes - ";
        private static string path = NunitTestHelper.GetPathToProject();


        public static void CreateReport()
        {
            var htmlReporter = new ExtentHtmlReporter(pathToReport + reportName + DateTime.Now.ToString("dd-MM-yyyy")+ ".html");
            var environment = ConfigurationManager.AppSettings["environment"];

            // create ExtentReports and attach reporter(s)
            extent = new ExtentReports();
            
            if (environment =="production")
            {
                klov = new KlovReporter();

                var klovUrlConnection = ConfigurationManager.AppSettings["klovUrl"];
                var klovPortConnection = ConfigurationManager.AppSettings["klovPort"];
                var klovProjectName = NunitTestHelper.GetProjectName(); 
                var KlovManagerUrl = ConfigurationManager.AppSettings["KlovManagerUrl"];

                klov.InitMongoDbConnection(klovUrlConnection, int.Parse(klovPortConnection));

                klov.ProjectName = NunitTestHelper.GetProjectName();

                klov.KlovUrl = KlovManagerUrl;

                klov.ReportName = "Build " + DateTime.Now.ToString();
                extent.AttachReporter(htmlReporter, klov);
            }
            else extent.AttachReporter(htmlReporter);


            //extent.AttachReporter(htmlReporter);

        }

        public static void AddTest()
        {
            var testName = NunitTestHelper.GetTestName();
            var description = NunitTestHelper.GetTestAttribute("Description");
            var className = NunitTestHelper.GetClassName();
            var category = NunitTestHelper.GetTestAttribute("Category");
            // creates a toggle for the given test, adds all log events under it    
            test = extent.CreateTest(testName, description).AssignCategory(category);
        }

        public static void Log(Status logstatus, string stacktrace)
        {
            test.Log(logstatus, "Test ended with " + logstatus + stacktrace);

        }

        public static void exceptionLog(Exception ex)
        {
            test.Fail(ex);

        }

        public static void GenerateReport()
        {
            // calling flush writes everything to the log file
            extent.Flush();
        }

        public static void TestFail()
        {
            test.Fail("ERRO! Teste falhou");
        }
        public static void TestPass()
        {
            test.Pass("Teste passou");
        }

        public static void TestInfo()
        {
            test.Info("Step test  " + Guid.NewGuid());
        }
        //public static ExtentReport extent {get;set;}

        //public void StartReport() { }

        //var htmlReporter = new ExtentHtmlReporter("extent.html");

        //// create ExtentReports and attach reporter(s)
        //var extent = new ExtentReports();
        //extent.AttachReporter(htmlReporter);

        //// creates a toggle for the given test, adds all log events under it    
        //var test = extent.CreateTest("MyFirstTest", "Sample description");

        //// log(Status, details)
        //test.Log(Status.Info, "This step shows usage of log(status, details)");

        //// info(details)
        //test.Info("This step shows usage of info(details)");

        //// log with snapshot
        //test.Fail("details", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());

        //// test with snapshot
        //test.AddScreenCaptureFromPath("screenshot.png");

        //// calling flush writes everything to the log file
        //extent.Flush();
        //var htmlReporter = new ExtentHtmlReporter("extent.html");

        //// create ExtentReports and attach reporter(s)
        //var extent = new ExtentReports();
        //extent.AttachReporter(htmlReporter);

        //// creates a toggle for the given test, adds all log events under it    
        //var test = extent.CreateTest("MyFirstTest", "Sample description");

        //// log(Status, details)
        //test.Log(Status.Info, "This step shows usage of log(status, details)");

        //// info(details)
        //test.Info("This step shows usage of info(details)");

        //// log with snapshot
        //test.Fail("details", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());

        //// test with snapshot
        //test.AddScreenCaptureFromPath("screenshot.png");

        //// calling flush writes everything to the log file
        //extent.Flush();

        public static void CreateManagerReport()
        {
            //var klovReporter = new KlovReporter();

            //// specify mongoDb connection
            //klovReporter.InitMongoDbConnection("localhost", 27017);

            //// specify project ! you must specify a project, other a "Default project will be used"
            //klovReporter.ProjectName = "CsharpReports";

            //// you must specify a reportName otherwise a default timestamp will be used
            //klovReporter.ReportName = "Build " + DateTime.Now.ToString();

            //// URL of the KLOV server
            //klovReporter.KlovUrl = "http://localhost";
            //extent.AttachReporter(klovReporter);


        }
    }
}
