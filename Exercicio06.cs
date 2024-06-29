using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6) Contar Vogais: Escreva uma função que conte o número de vogais em uma string.

namespace MetodosCsharp03
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(EliminarVogais("Pudim de leite condensado"));
        }

        static string EliminarVogais(string texto)
        {
            string vogais = "aeiouAEIOU";
            string resultado = string.Empty;
            foreach (char c in texto)
            {
                if (!vogais.Contains(c))
                {
                    resultado += c;
                }
            }
            return resultado;
        }
    }
}
