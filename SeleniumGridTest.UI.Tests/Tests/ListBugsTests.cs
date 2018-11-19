using NUnit.Framework;
using SeleniumGridTest.Selenium.SeleniumPages;
using SeleniumGridTest.UI.Tests.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.UI.Tests.Tests
{
    [TestFixture, Order(3), Parallelizable(ParallelScope.Self)]
    public class ListBugsTests : TestBase
    {
        LoginPage objLogin = null;
        ListBugPage objList = null;

        [Test, Description("")]
        public void TEST_ListAllBugs()
        {
            objLogin = new LoginPage(_driver);
            objList = new ListBugPage(_driver);
            objLogin.NavigateToLoginPage().LogIn();

            objList.ClickIssueDetails();

            //ValidationResult.AssertTextInElement(objList.bugId, ListBugPage.selectBug);
        }

        [Test, Description("")]
        public void TEST_ListBugsForPriority()
        {


        }

        [Test, Description("")]
        public void TEST_ListBugsForCriticality()
        {


        }


        [Test, Description("")]
        public void TEST_ListBugsForDateCreateDesc()
        {


        }

        [Test, Description("")]
        public void TEST_ListBugsForDateCreateAsc()
        {


        }

        [Test, Description("")]
        public void TEST_ListBugsForReporter()
        {


        }

        [Test, Description("")]
        public void TEST_ListBugsForStatus()
        {


        }
    }
}
