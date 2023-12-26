using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int i = 0;
            while (i < arr.Length) {
                i++;
                arr[i] = i + 1;
                Console.WriteLine($"N-D-B {i}: {arr[i]}");
            }
            Console.WriteLine("Final");
        }
    }
}
