using System;

namespace cash
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cash c2001 = new Cash(100, 20, 5);

            //c2001.ValorGavA = 1000;
            //c2001.ValorGavB = 1000;
           // c2001.ValorGavC = 1000;

            Suprir(c2001);

            Sacar(c2001);


            

            Console.ReadLine();
        }

        public static void Sacar(Cash cash)
        {

            try
            {
                cash.Sacar(1200);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void Suprir(Cash cash)
        {

            try
            {
                cash.Suprir();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }
}
