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
            Console.WriteLine("Mascotas y sus Dueños");
        }
    }
}
