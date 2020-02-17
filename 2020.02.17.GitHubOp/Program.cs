using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._02._17.GitHubOp
{
    class Program
    {
        static void Main(string[] args)
        {
            autok verdak = new autok("auto.csv");
            Console.WriteLine(verdak.howmanyCarsAreThere());
        }
    }
}
