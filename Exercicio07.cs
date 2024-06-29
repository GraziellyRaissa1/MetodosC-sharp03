using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7) Verificar Ano Bissexto: Desenvolva um método que determine se um ano é bissexto ou não.

namespace MetodosCsharp03
{
    internal class Exercicio07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(AnoBissexto(2028));
            Console.WriteLine(AnoBissexto(2022));

            static bool AnoBissexto(int ano)
            {
                return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
            }
        }
}   }
