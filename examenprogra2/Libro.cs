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