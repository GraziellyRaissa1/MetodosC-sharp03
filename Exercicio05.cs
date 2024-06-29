using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5) Inverter String: Implemente um método que inverta uma string passada como argumento.


namespace MetodosCsharp03
{
    internal class Exercicio05
    {
       public static void Main(string[] args)
        {
            Console.WriteLine(InverterString("Miau! Au Au!")); // "dlroW olleH"
        }

        static string InverterString(string texto)
        {
            char[] array = texto.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
