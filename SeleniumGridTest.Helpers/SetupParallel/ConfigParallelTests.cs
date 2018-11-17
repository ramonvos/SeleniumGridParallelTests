using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Helpers.SetupParallel
{
    public class ConfigParallelTests
    {

        public int valor = 0;
        public const int LevelOfParallelism = 0;


        public ConfigParallelTests()
        {
            valor = LevelOfParallelism;


        }


        public static void Definir()
        {
            int valor = Convert.ToInt32(ConfigurationManager.AppSettings["LevelOfParallelism"]);
        }


       

        
        
    }
}
