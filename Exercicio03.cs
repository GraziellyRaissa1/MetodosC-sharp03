using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3) Verificar Palíndromo: Desenvolva um método que receba uma string como
//entrada e retorne verdadeiro se ela for um palíndromo (ou seja, se ela 
//pode ser lida da mesma forma de trás para frente), e falso caso contrário.

namespace MetodosCsharp03
{
    internal class Exercicio03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Palindromo("Miau!")); 
            Console.WriteLine(Palindromo("Au Au!")); 
        }

        static bool Palindromo(string texto)
        {
            int esquerda = 0;
            int direita = texto.Length - 1;
            while (esquerda < direita)
            {
                if (texto[esquerda] != texto[direita])
                {
                    return false;
                }
                esquerda++;
                direita--;
            }
            return true;
        }
    }
}
