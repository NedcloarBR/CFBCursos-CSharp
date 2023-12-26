using System;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for(int i = 0; i < arr.Length ; i++) {
                arr[i] = i;
                Console.WriteLine($"N-D-B - {i}, Arr: {arr[i]}");
            }
        }
    }
}
