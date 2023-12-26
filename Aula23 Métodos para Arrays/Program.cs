using System;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2,5]{{1,2,3,4,5}, {11,22,33,44,55}};

            Random random = new Random();
            for(int i = 0; i < vetor1.Length; i++) {
                vetor1[i] = random.Next(50);
            }

            Console.WriteLine("Elementos do vetor1");
            foreach(int i in vetor1) {
                Console.WriteLine(i);
            }
            Console.WriteLine("_________________________________");

            // public static int BinarySearch(array, valor);
            Console.WriteLine("BinarySearch");
            int search = 34;
            int position = Array.BinarySearch(vetor1, search);
            Console.WriteLine($"Valor {search} está na posição {position}");
            Console.WriteLine("_________________________________");

            // public static void Copy(origem, destino, elementos);
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);
            foreach (int i in vetor2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("_________________________________");

            // public void CopyTo(destino, posição);
            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0);
            foreach (int i in vetor3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("_________________________________");

            // public long GetLongLength(dimensão)
            Console.WriteLine("GetLongLength");
            long qtdeElementosVetor=vetor1.GetLongLength(0);
            Console.WriteLine($"Quantidade de elementos {qtdeElementosVetor}");
            Console.WriteLine("_________________________________");
            
            // public int GetLowerBound(dimensão)
            Console.WriteLine("GetLowerBound");
            int MenorIndiceVetor=vetor1.GetLowerBound(0);
            int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
            Console.WriteLine($"Quantidade de elementos {MenorIndiceVetor}");
            Console.WriteLine("_________________________________");

            // public int GetUpperBound(dimensão)
            Console.WriteLine("GetUpperBound");
            int MenorIndiceVetor=vetor1.GetUpperBound(0);
            int MenorIndiceMatriz_D1=matriz.GetUpperBound(1);
            Console.WriteLine($"Quantidade de elementos {MenorIndiceVetor}");
            Console.WriteLine("_________________________________");

            // public object GetValue(long índice);
            Console.WriteLine("GetValue");
            int valor0=Convert.ToInt32(vetor1.GetValue(3));
            int valor1=Convert.ToInt32(matriz.GetValue(1,3));
            Console.WriteLine($"Valor da posição 3 do vetor 1: {valor0}");
            Console.WriteLine("_________________________________");

            // public static int IndexOf(array, valor);
            Console.WriteLine("IndexOf");
            int indice1=Array.IndexOf(vetor1,3);
            Console.WriteLine($"Indice do primeiro valor 3: {indice1}");
            Console.WriteLine("_________________________________");

            // public static int LastIndexOf(array, valor);
            Console.WriteLine("LastIndexOf");
            int indice1=Array.LastIndexOf(vetor1,3);
            Console.WriteLine($"Indice do último valor 3: {indice1}");
            Console.WriteLine("_________________________________");

            // public static void Reverse(array);
            Console.WriteLine("Reverse");
            Array.Reverse(vetor1);
            foreach(int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");

            // public void SetValue(object valor, long pos);
            Console.WriteLine("SetValue");
            vetor2.SetValue(99,0);
            for(int i=0;i<vetor2.Length;i++)
            {
                vetor2.SetValue(0,i);
            }
            Console.WriteLine("Vetor 2");
            foreach(int n in vetor2);
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");

            // public static void Sort(array);
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            Console.WriteLine("Vetor 1");
            foreach(int n in vetor1);
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nVetor 2");
            foreach(int n in vetor2);
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nVetor 3");
            foreach(int n in vetor3);
            {
                Console.WriteLine(n);
            }
        }
    }
}
