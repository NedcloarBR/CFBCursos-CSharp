using System;

namespace Aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "123";
            string ReadPass;
            int Tries = 0;

            do {
                Console.Clear();
                Console.Write("Digite a senha: ");
                ReadPass = Console.ReadLine();
                Tries++;
            } while(pass != ReadPass);

            Console.Clear();
            Console.WriteLine($"Correct! Tries: {Tries}");
        }
    }
}
