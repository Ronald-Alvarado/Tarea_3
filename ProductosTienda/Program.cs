using System;

namespace ProductosTienda
{
    class Program
    {
        public struct Productos
        {
            public string Nombre;
            public float Precio;
            public int Cantidad;

            public Productos(String nombre, float precio, int cantidad)
            {
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }

        }
        static void Main(string[] args)
        {
            
            String dato = " ";

            String nombre;
            float precio;
            int cantidad;

            Console.WriteLine("Productos de una Tienda\n");

            Console.Write("Digite el Nombre del Producto: ");
            dato = Console.ReadLine();
            nombre = dato;
            Console.Write("\nDigite el Precio del Producto: ");
            dato = Console.ReadLine();
            precio = Convert.ToSingle(dato);
            Console.Write("\nDigite la Cantidad del Producto: ");
            dato = Console.ReadLine();
            cantidad = Convert.ToInt32(dato);

            Productos p = new Productos(nombre,precio,cantidad);

            Console.WriteLine("Los productos son:\n");
            Console.Write("Cantidad: {0} , Nombre: {1} , Precio: {2}", p.Cantidad, p.Nombre, p.Precio);
        }
    }
}
