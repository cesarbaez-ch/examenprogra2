using System;

class Program
{
    static void Main()
    {
        Libro l1 = new Libro("L01", "Cien años de soledad", "G. García Márquez", 1967);
        Libro l2 = new Libro("L02", "Don Quijote", "M. Cervantes", 1605);
        Libro l3 = new Libro("L03", "El Resplandor", "S. King", 1977);

        l1.Prestar();
        l2.Prestar();
        l2.Devolver();

        Console.WriteLine("\n--- ESTADO ACTUAL ---");
        l1.MostrarInformacion();
        l2.MostrarInformacion();
        l3.MostrarInformacion();

        l1.ObtenerEstadisticas();

        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }
}