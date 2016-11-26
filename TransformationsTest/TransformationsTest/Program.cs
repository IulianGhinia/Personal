using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace TransformationsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string buildType = ConfigurationManager.AppSettings["buildType"].ToString();
            
            Console.Write(buildType);
            Console.ReadLine();

        }
    }
}
