using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5_avaliacao_logica_de_programacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para encontrar todos os números pares entre 1 e 100.


            int op = 1, resto;

            while (op <= 100)
            {
                resto = op % 2;
                if (resto == 0)
                {
                    Console.WriteLine(op);
                    op++;
                }
                else
                {
                    op++;
                }

            }
            Console.ReadKey();
        }
    }
}
