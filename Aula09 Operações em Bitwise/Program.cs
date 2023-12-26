using System;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //! << Dobrar o Valor
            //@ >> Metade do valor

            int num = 10;
            num=num<<1;
            Console.WriteLine(num);

            int num1 = 10;
            num1=num1>>1;
            Console.WriteLine(num1);
        }
    }
}
