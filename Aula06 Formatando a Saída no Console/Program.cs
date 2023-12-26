using System;

namespace aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n1, n2, n3;

            // n1 = 10; n2 = 20; n3 = 30; 

            // Console.Write(n1 + ", " + n2 + ", " + n3);
            // Console.Write("n1={0}, n2={1}, n3={2}", n1,n2,n3);
            // Console.Write("\nn1={0}\nn2={1}\nn3={2}\n", n1,n2,n3); //! \n Quebra a linha
            // Console.Write("\tn1={0}\tn2={1}\tn3={2}\t", n1,n2,n3); //@ \t tubulação = espaço(tab)

            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.5;
            string produto = "Pastel";

            valorVenda = valorCompra+(valorCompra*lucro);

            Console.WriteLine("Produto.........:{0,15}", produto); //$ 0 = indice da variavel; 15 = espaçamento
            Console.WriteLine("Val.Compra......:{0,15:c}", valorCompra); //$ :c = Formatação Monetaria
            Console.WriteLine("Lucro...........:{0,15:p}", lucro); //$ :p = Formatação de Porcentagem(%)
            Console.WriteLine("Val.Venda.......:{0,15:c}", valorVenda);
        }
    }
}
