using System;

//8) Calcular Potência: Crie uma função que calcule a potência de 
 //um número inteiro base elevado a um expoente inteiro positivo.

namespace MetodosCsharp03
{
    internal class Exercicio08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CalculoDaPotencia(2, 35));
        }

        static long CalculoDaPotencia(long baseNum, int expoente)
        {
            long resultado = 1;
            for (int i = 0; i < expoente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }
    }
}
