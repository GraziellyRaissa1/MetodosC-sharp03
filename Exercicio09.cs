using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9) Verificar Triângulo: Implemente um método que receba três números inteiros como argumentos e retorne verdadeiro
//se eles podem ser os comprimentos dos lados de um triângulo, e falso caso contrário.

namespace MetodosCsharp03
{
    internal class Exercicio09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(EhTriangulo(33, 46, 59)); 
            Console.WriteLine(EhTriangulo(16, 260, 31)); 
        }

        static bool EhTriangulo(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
