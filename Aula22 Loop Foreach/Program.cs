using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3]{1, 2, 3};

            // for(int i=0; i < num.Length; i++) {
            //     Console.WriteLine(num[i]);
            // }

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
