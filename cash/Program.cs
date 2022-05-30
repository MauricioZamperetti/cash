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

            int gav100 = 1000;
            int gav20 = 1000;
            int gav5 = 1000;
            int saqueSolicitado = 545;
            int incremento = 0;


            Console.WriteLine("As gavetas A, B e C tem, respectivamente, " + gav100 + ", " + gav20 + " e " + gav5);

            while (incremento < saqueSolicitado)
            {
                incremento += 100;
                gav100 -= 100;

                if ((incremento + 100) > saqueSolicitado)
                {
                    while (incremento < saqueSolicitado)
                    {
                        incremento += 20;
                        gav20 -= 20;

                        if ((incremento + 20) > saqueSolicitado)
                        {
                            while (incremento < saqueSolicitado)
                            {
                                incremento += 5;
                                gav5 -= 5;
                            }
                        }
                    }

                }

                if (incremento == saqueSolicitado)
                {
                    Console.WriteLine("O saque foi efetuado com sucesso, o valor de " + incremento);
                    Console.WriteLine("As gavetas A, B e C agora tem, respectivamente, " + gav100 + ", " + gav20 + " e " + gav5);
                }

            }

            Console.ReadLine();
        }

        public void Sacar(int saque)
        {

        }
    }
}
