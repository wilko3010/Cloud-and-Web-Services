using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HebbracoModel;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Model1 db = new Model1();
            var stuff = db.BusinessUnits;
            foreach (var bu in stuff)
            {
                Console.WriteLine(bu.businessUnitCode);
            }
            Console.ReadKey();
        }
    }
}
