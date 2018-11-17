using OpenQA.Selenium;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Selenium.SeleniumPages
{
    public class ListBugPage : DriverFactory
    {

        public IWebDriver Instance { get; set; }
        public ListBugPage(IWebDriver driver) : base(driver)
        {
            Instance = driver;
        }

        public static string selectBug = string.Empty;
        private By gridIssues = By.Id("buglist");


        public IWebElement linkViewIssues => Instance.FindElement(By.LinkText("View Issues"));

        public IWebElement linkBugDetails => Instance.FindElement(By.XPath("//table[@id='buglist']/tbody/tr/td[4]"));

        public IWebElement bugId => Instance.FindElement(By.CssSelector("td.bug-id"));

        public String GetLinkTextBug()
        {
            //WaitForElementHelpers.WaitForElementDisplayed(gridIssues);

            return linkBugDetails.Text;
        }

        // Get all number link all bugs first page
        public List<string> GetNumberAllBugs()
        {
            List<string> bugs = new List<string>();
            int aux = CountBugList();

            for (int i = 1; i < aux; i++)
            {
                string bugNumber = Instance.FindElement(By.XPath("//table[@id='buglist']/tbody/tr[" + i + "]/td[4]")).Text;
                bugs.Add(bugNumber);
            }

            return bugs;

        }


        public int CountBugList()
        {
            return Instance.FindElements(By.XPath("//table[@id='buglist']/tbody/tr")).Count;
        }

        public void ClickIssueDetails()
        {
            //linkViewIssues.ClickLink();

            //string linkBug = GetLinkTextBug();

            //List<String> allBugs = GetNumberAllBugs();
            //selectBug = allBugs.StringRandom();

            //Instance.FindElement(By.LinkText(selectBug)).ClickLink();

            //int bugNumber = Convert.ToInt32(selectBug);
        }



    }
}
