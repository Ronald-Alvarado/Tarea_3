using System;

namespace Mascotas
{
    class Program
    {
        public struct Dueño
        {
            public String NombreDueño;
            public int EdadDueño;

            public Dueño(String nombreD, int edadD)
            {
                NombreDueño = nombreD;
                EdadDueño = edadD;
            }

        }
        public struct DatosMascota
        {
            public String NombreMascota;
            public int EdadMascota;

            public Dueño DatosDueño;
            

            public DatosMascota(String nombreM, int edadM, String nombreD, int edadD)
            {
                NombreMascota = nombreM;
                EdadMascota = edadM;

                DatosDueño = new Dueño(nombreD,edadD);
                
            }


        }

        static void Main(string[] args)
        {
            String dato = " ";
            String nombreM, nombreD;
            int edadM, edadD;

            String NombreMascota, NombreDueño;
            int EdadMascota, EdadDueño;

            Console.WriteLine("Mascotas y sus Dueños\n");

            Console.Write("Digite el Nombre de la Mascota: ");
            NombreMascota = Console.ReadLine();
            Console.Write("\nDigite la edad de la Mascota: ");
            dato = Console.ReadLine();
            EdadMascota = Convert.ToInt32(dato);

            Console.Write("\nDigite el Nombre del Dueño: ");
            NombreDueño = Console.ReadLine();
            Console.Write("\nDigite la edad del Dueño: ");
            dato = Console.ReadLine();
            EdadDueño = Convert.ToInt32(dato);

            DatosMascota dm = new DatosMascota(NombreMascota, EdadMascota, NombreDueño, EdadDueño);

            Console.Write("\n\nLos datos:\n");
            Console.Write("Mascota: {0} - {1}\nDueño: {2} - {3}", dm.NombreMascota, dm.EdadMascota, dm.DatosDueño.NombreDueño, dm.DatosDueño.EdadDueño);
        }
    }
}
