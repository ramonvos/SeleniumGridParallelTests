namespace SeleniumGridTest.Helpers
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
