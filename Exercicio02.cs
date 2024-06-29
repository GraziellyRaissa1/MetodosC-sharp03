using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2) Calcular Fatorial: Escreva um método para calcular o fatorial de um número 
//inteiro positivo passado como parâmetro.

namespace MetodosCsharp03
{
    internal class Exercicio02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CalculoDoFatorial(50)); // vai retornar 0
        }

        static int CalculoDoFatorial(int numero)
        {
            if (numero == 0) return 1;
            int fatorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }
}
