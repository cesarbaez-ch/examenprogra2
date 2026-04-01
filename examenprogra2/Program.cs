using System;

public class Libro
{
    private readonly string _codigo;
    private string _titulo;
    private string _autor;
    private int _anioPublicacion;
    private bool _estaPrestado;
    private int _contadorPrestamos;

    public string Codigo => _codigo;
    public string Titulo { get => _titulo; set => _titulo = value; }
    public string Autor { get => _autor; set => _autor = value; }
    public int AnioPublicacion { get => _anioPublicacion; set => _anioPublicacion = value; }
    public string Estado => _estaPrestado ? "Prestado" : "Disponible";

    public Libro(string codigo, string titulo, string autor, int anio)
    {
        _codigo = codigo;
        _titulo = titulo;
        _autor = autor;
        _anioPublicacion = anio;
        _estaPrestado = false;
        _contadorPrestamos = 0;
    }

    public void Prestar()
    {
        if (!_estaPrestado)
        {
            _estaPrestado = true;
            _contadorPrestamos++;
            Console.WriteLine($"Libro {_titulo} prestado.");
        }
        else
        {
            Console.WriteLine("No disponible.");
        }
    }

    public void Devolver()
    {
        _estaPrestado = false;
        Console.WriteLine($"Libro {_titulo} devuelto.");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"{_codigo} | {_titulo} | {_autor} | {Estado}");
    }

    public void ObtenerEstadisticas()
    {
        Console.WriteLine($"Préstamos de '{_titulo}': {_contadorPrestamos}");
    }

    ~Libro()
    {
        Console.WriteLine($"Objeto {_codigo} eliminado.");
    }
}

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

        l1.MostrarInformacion();
        l2.MostrarInformacion();
        l3.MostrarInformacion();

        l1.ObtenerEstadisticas();

        Console.ReadKey();
    }
}