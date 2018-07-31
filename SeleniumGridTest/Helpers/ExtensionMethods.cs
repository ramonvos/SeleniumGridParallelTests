using SeleniumGridTest.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest
{
    public static class ExtensionMethods
    
    {   

        public static bool HasValue(this string value)
        {
            if (value != string.Empty || value != null)
            {
                return true;
            }
            else return false;
   
        }


    }
}
