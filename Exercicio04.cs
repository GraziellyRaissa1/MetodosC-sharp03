using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4) Calcular Média: Crie uma função que calcule a média de uma lista de números passada como parâmetro.

namespace MetodosCsharp03
{
    internal class Exercicio04
    {
       public static void Main(string[] args)
        {
            List<double> numeros = new List<double> { 20.0, 50.0, 90.0 };
            Console.WriteLine(CalculoDaMedia(numeros)); 
        }

        static double CalculoDaMedia(List<double> numeros)
        {
            double soma = 0;
            foreach (double numero in numeros)
            {
                soma += numero;
            }
            return soma / numeros.Count;
        }
    }
}
