using System;

//10) Calcular Média Ponderada: Escreva uma função que calcule
//a média ponderada de três valores, onde os pesos são passados como argumentos.


namespace MetodosCsharp03
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
   
            Console.WriteLine(CalculoDaMediaPonderada(7.5, 8.3, 6.9, 3, 4, 2));
        }

        static double CalculoDaMediaPonderada(double valor1, double valor2, double valor3, int peso1, int peso2, int peso3)
        {
         
            double somaPesos = peso1 + peso2 + peso3;
            double somaPonderada = (valor1 * peso1 + valor2 * peso2 + valor3 * peso3);

            return somaPonderada / somaPesos;
        }
    }
}
