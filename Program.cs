using System;

namespace triangulo_base
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double basee;
            double altura;

            Console.Write("Qual o valor da base:");
            basee = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor da altura:");
            altura = double.Parse(Console.ReadLine());

            area = basee * altura / 2;

            Console.WriteLine("A área é " + area + ".");
            
        }
    }
}
