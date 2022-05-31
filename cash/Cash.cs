using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cash;

namespace cash
{
    public class Cash
    {
        public int ValorGavA { get; set; }
        public int ValorGavB { get; set; }
        public int ValorGavC { get; set; }
        public int NotaGavA { get; private set; }
        public int NotaGavB { get; private set; }
        public int NotaGavC { get; private set; }


        public Cash(int notaGavA, int notaGavB, int notaGavC)
        {
            NotaGavA = notaGavA;
            NotaGavB = notaGavB;
            NotaGavC = notaGavC;
        }

        public void Sacar(int saque)
        {

            int incremento = 0;


            while (incremento < saque)
            {
                incremento += this.NotaGavA;
                this.ValorGavA -= this.NotaGavA;

                if ((incremento + this.NotaGavA) > saque)
                {
                    while (incremento < saque)
                    {
                        incremento += NotaGavB;
                        this.ValorGavB -= this.NotaGavB;

                        if ((incremento + NotaGavB) > saque)
                        {
                            while (incremento < saque)
                            {
                                incremento += NotaGavC;
                                this.ValorGavC -= this.NotaGavC;
                            }
                        }
                    }

                }

                if (incremento == saque)
                {
                    Console.WriteLine("O saque foi efetuado com sucesso, no valor de " + incremento);
                    Console.WriteLine("As gavetas A, B e C agora tem, respectivamente, " + ValorGavA + ", " + ValorGavB + " e " + ValorGavC);
                }

            }
        }


    }
}
