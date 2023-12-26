using System;

namespace Aula18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[2,2];
            
            n[0,0] = 13;
            n[0,1] = 69;
            n[1,0] = 55;
            n[1,1] = 00;

            Console.WriteLine(n[0,1]);

            Console.WriteLine("--");

            int[,] n2 = new int[3,3]{{69, 55, 13}, {00, 11, 22}, {01, 02, 03}};

            Console.WriteLine(n2[0,0]);
        }
    }
}
