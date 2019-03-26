using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Model mymodel = new Model();
            mymodel.AngerLevel = 99;
            Console.WriteLine(mymodel.AngerLevel);
            Console.ReadKey();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
