using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cash
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cash c2001 = new Cash(100, 20, 5);

            c2001.ValorGavA = 1000;
            c2001.ValorGavB = 1000;
            c2001.ValorGavC = 1000;

            

            c2001.Sacar(145);

            Console.ReadLine();
        }
     
    }
}
