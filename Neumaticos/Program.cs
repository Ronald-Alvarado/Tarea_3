using System;

namespace Neumaticos
{
    class Program
    {
        enum Neumatico {diagonal, radial, asimétricos, direccionales, tubuless};
        static void Main(string[] args)
        {
            

            String dato = " ";
            int numero;

            Console.WriteLine("Tipos de Neumaticos\n");

            Neumatico diag = Neumatico.diagonal;
            Neumatico rad = Neumatico.radial;
            Neumatico asi = Neumatico.asimétricos;
            Neumatico dir = Neumatico.direccionales;
            Neumatico tub = Neumatico.tubuless;

            Console.WriteLine("Los tipos de Neumaticos son: {0}, {1}, {2}, {3}, {4}", diag, rad, asi, dir, tub);
        }
    }
}
