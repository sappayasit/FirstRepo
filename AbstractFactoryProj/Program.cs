using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Client twice
            new Client<Poochy>().ClientMain();
            new Client<Gucci>().ClientMain();
            new Client<Groundcover>().ClientMain();
            Console.ReadKey();
        }
    }
}
