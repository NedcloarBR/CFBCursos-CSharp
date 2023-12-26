using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; //! Pode ser Negativo(-), Possui 32 Bytes
            byte n1 = 10; //# Pode Armazenar entre 0 e 255, Possui 8 Bytes
            char letra = 'a';
            float valor = 5.5f;
            string nome = "NedcloarBR";
            bool vf = true; // Boolean (Verdadeiro ou Falso)

            int num1, num2, res; //% Definindo Múltiplas Variáveis para depois definir o valor de cada

            num1 = 55;
            num2 = 13;
            res = num1 * num2; //$ Fazendo Operações com as variáveis 

            int num3 = 69, num4 = 0; //* Definindo Múltiplas Variáveis e definindo o Valor delas

            Console.WriteLine("A Multiplicação de " + num1 + " x " + num2 + " é igual a: " + res);

            var aux = 13; //@ Não precisa definir o tipo de Variavel pois no ato da compilação o tipo é definido automaticamente
        
            Console.WriteLine("Valor da Variável: " + aux);
        }
    }
}
