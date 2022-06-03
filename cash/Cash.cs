using System;

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

        public void Suprir()
        {
            Console.WriteLine("Gaveta A possui " + ValorGavA + " e está configurada com notas de " + NotaGavA + ". Qual valor você deseja suprir nesta gaveta?");
            ValorGavA += int.Parse(Console.ReadLine());
            Console.WriteLine("Suprimento efetuado com sucesso, agora a gaveta A possui " + ValorGavA + ".");

            Console.WriteLine("Gaveta B possui " + ValorGavB + " e está configurada com notas de " + NotaGavB + ". Qual valor você deseja suprir nesta gaveta?");
            ValorGavB += int.Parse(Console.ReadLine());
            Console.WriteLine("Suprimento efetuado com sucesso, agora a gaveta B possui " + ValorGavB + ".");

            Console.WriteLine("Gaveta C possui " + ValorGavC + " e está configurada com notas de " + NotaGavC + ". Qual valor você deseja suprir nesta gaveta?");
            ValorGavC += int.Parse(Console.ReadLine());
            Console.WriteLine("Suprimento efetuado com sucesso, agora a gaveta C possui " + ValorGavC + ".");
        }

        public void Sacar(int valor)
        {
            int incremento = valor;

            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido para saque.");
            }

            if (valor % NotaGavC != 0)
            {
                throw new ArgumentException("Composição de notas não disponível. Este equipamento possui notas de " + NotaGavA + ", " + NotaGavB + " e " + NotaGavC + ".");
            }

            if (valor > (ValorGavA + ValorGavB + ValorGavC))
            {
                throw new ArgumentException("Equipamento sem dinheiro suficiente para o saque.");
            }


            while (incremento != 0)
            {

                while (((incremento - NotaGavA) >= 0) && (ValorGavA >= NotaGavA))
                {
                    ValorGavA -= NotaGavA;
                    incremento -= NotaGavA;
                }

                while (((incremento - NotaGavB) >= 0) && (ValorGavB >= NotaGavB))
                {
                    ValorGavB -= NotaGavB;
                    incremento -= NotaGavB;
                }

                while (((incremento - NotaGavC) >= 0) && (ValorGavC >= NotaGavC))
                {
                    ValorGavC -= NotaGavC;
                    incremento -= NotaGavC;
                }

                if (incremento == 0)
                {
                    Console.WriteLine("O saque foi efetuado com sucesso, no valor de " + valor);
                    Console.WriteLine("As gavetas A, B e C agora tem, respectivamente: " + ValorGavA + ", " + ValorGavB + " e " + ValorGavC);
                }
            }




            //while (incremento < valor)
            //{

            //        incremento += NotaGavA;
            //        ValorGavA -= NotaGavA;

            //        if ((incremento + NotaGavA) > valor)
            //        {
            //            while (incremento < valor)
            //            {
            //                incremento += NotaGavB;
            //                ValorGavB -= NotaGavB;

            //                if ((incremento + NotaGavB) > valor)
            //                {
            //                    while (incremento < valor)
            //                    {
            //                        incremento += NotaGavC;
            //                        ValorGavC -= NotaGavC;
            //                    }
            //                }
            //            }
            //        }


            //    if (incremento == valor)
            //    {
            //        Console.WriteLine("O saque foi efetuado com sucesso, no valor de " + incremento);
            //        Console.WriteLine("As gavetas A, B e C agora tem, respectivamente: " + ValorGavA + ", " + ValorGavB + " e " + ValorGavC);
            //    }

            //}



        }

        public void VerificaNotas(int valor)
        {
            Console.WriteLine("");
        }

    }
}
