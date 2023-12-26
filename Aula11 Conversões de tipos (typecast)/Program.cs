using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            float n2 = n1;

            Console.WriteLine(n2);

            float n3 = 10.5f;
            // int n2 = n1; //! Error
            int n4 = (int)n3; //@ Typecast
            
            Console.WriteLine(n4);

            int vInt = 10;
            long vLong = vInt; //# Sem Typecast
            short vShort = (short)vInt; //% Typecast

            Console.WriteLine(vLong);
            Console.WriteLine(vLong);
        }
    }
}
