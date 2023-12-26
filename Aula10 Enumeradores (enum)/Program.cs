using System;

namespace Aula10
{
    class Program
    {
        enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

        static void Main(string[] args)
        {
            //! DiasSemana ds = DiasSemana.Domingo;
            //@ DiasSemana ds = (DiasSemana)3;
            int ds = (int)DiasSemana.Sexta;

            Console.WriteLine(ds);
        }
    }
}
