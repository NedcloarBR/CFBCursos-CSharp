using System;

namespace Aula13
{
  class Program
  {
    static void Main(string[] args)
    {
      int num;
      string result;
      
      Console.Write("Digite um número: ");
      num = int.Parse(Console.ReadLine());

      if(num >= 10) {
        result = "OK!";
      } else if(num <= 8) {
        result = "Hmm";
      } else {
        result = "BAD NUMBER";
      }

      Console.WriteLine($"Expected: 10 - Give: {num} - Result: {result}");
    }
  }
}
