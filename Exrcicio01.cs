using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1) Verificar Número Primo: Crie um método que receba um número inteiro como argumento e retorne verdadeiro
//se o número for primo, e falso caso contrário.

namespace MetodosCsharp03
{
    internal class Exercicio01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(NumeroPrimo(5)); 
            Console.WriteLine(NumeroPrimo(1)); 
        }

        static bool NumeroPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
