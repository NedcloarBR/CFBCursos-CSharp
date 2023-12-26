using System;

namespace aula16
{
  class Program
  {
    static void Main(string[] args)
    {
      int time;
      char chose;

    inicio:

      Console.Clear();

      Console.WriteLine("Destino: Guaíba/RS a Porto Alegre/RS");
      Console.WriteLine("Escolha o transporte: [a] Busão | [b] Carro | [c] Moto | [d] Catamarã");

      chose = char.Parse(Console.ReadLine());

      switch (chose)
      {
        case 'a':
          time = 60;
          break;
        case 'b':
          time = 40;
          break;
        case 'c':
          time = 30;
          break;
        case 'd':
          time = 20;
          break;
        default:
          time = -1;
          break;
      }

      if (time < 0)
      {
        Console.WriteLine("Vai a pé??? vai demorar muito!");
      }
      else
      {
        Console.WriteLine($"O tempo de viagem com o transporte escolhido é: {time} minutos");
      }

      Console.Write("\nEscolher outro transporte? [s/n] ");
      chose = char.Parse(Console.ReadLine());

      if(chose == 's' || chose == 'S') {
        goto inicio;
      } else {
        Console.Clear();
        Console.Write("Saindo do programa!");
      }
    }
  }
}
