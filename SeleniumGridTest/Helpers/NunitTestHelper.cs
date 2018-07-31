using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest
{
    public class NunitTestHelper
    {       

       

        public static String GetTestName()
        {
            return TestContext.CurrentContext.Test.Name;
        }

        public static String GetTestAttribute(string attr)
        {
            
            return TestContext.CurrentContext.Test.Properties.Get(attr).ToString();
        }

        public static String GetClassName()
        {

            return TestContext.CurrentContext.Test.ClassName.Substring(23);
        }


        public static TestContext GetTestContext()
        {
            return TestContext.CurrentContext;
        }

        public static String GetProjectName()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        }

        public static String GetPathToProject()
        {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);

        }

    }
}
