using System;

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, soma;
            string nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Nome: {0}", nome);

            Console.Write("Digite o 1º Valor : ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º Valor : ");
            v2 = Convert.ToInt32(Console.ReadLine());
            soma = v1 + v2;
            Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);
        }
    }
}
