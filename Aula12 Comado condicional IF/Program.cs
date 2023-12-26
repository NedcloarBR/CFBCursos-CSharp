using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            string result = "Não passou";

            if(num >= 6) {
                result = "Passou";
            }

            Console.WriteLine("?: {0}", result);

            Console.WriteLine("--------------------------------");

            int num1 = 10;
            string result1 = "Não passou";
            Console.WriteLine("Digite uma nota");
            num1 = int.Parse(Console.ReadLine());

            if(num >= 6) {
                result1 = "Passou";
            }

            Console.WriteLine("?: {0}", result1);
        }
    }
}
