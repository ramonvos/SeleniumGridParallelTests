using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Configuration;

namespace SeleniumGridTest.Helpers.AdvancedReport
{
    public class Reporter
    {
        public static ExtentReports extent;
        public static ExtentTest test;
        public static KlovReporter klov;

        public static string pathToReport = @"C:\Users\ramon\source\repos\SeleniumGridTest\SeleniumGridTest.UI.Tests\bin\Debug\";
        public static string reportName = "RelatorioDeTestes - ";
        private static string path = NunitTestHelper.GetPathToProject();


        public static void CreateReport()
        {
            var htmlReporter = new ExtentHtmlReporter(pathToReport + reportName + DateTime.Now.ToString("dd-MM-yyyy")+ ".html");
            var KlovManager = ConfigurationManager.AppSettings["EnableKlov"];

            // create ExtentReports and attach reporter(s)
            extent = new ExtentReports();
            
            if (KlovManager == "True")
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

        public static void LogPass(string text)
        {
            test.Pass(text);

        }

        public static void LogFail(string text)
        {
            test.Fail(text);
            Assert.Fail();

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
         
        public static void markupCodeblock(string text, Status status)
        {
            String code = "\n\t\n\t\t"+text+"\n\t\n";
            IMarkup m = MarkupHelper.CreateCodeBlock(code);
            

            test.Log(status, m);
        }

        public static void markupLabel(string text, Status status, ExtentColor color)
        {
            
            IMarkup m = MarkupHelper.CreateLabel(text, color);
            
            test.Log(status, m);
        }

    }
}
