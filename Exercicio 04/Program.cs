using System;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quer saber a tabuada de qual número?");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            { 
            int resultado = num * i;
                Console.WriteLine(num + " * " + i + " = " + resultado);

            }






        }
    }
}
