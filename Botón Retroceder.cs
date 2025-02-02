//Programación del botón retroceder de un navegador web
using System;
using System.Collections.Generic;
using System.Diagnostics;

// Clase que simula un navegador con funcionalidad de retroceso
class NavegadorWeb
{
    private Stack<string> historial = new Stack<string>(); // Pila para almacenar el historial de navegación
    private string paginaActual;

    public void VisitarPagina(string url)
    {
        if (paginaActual != null)
        {
            historial.Push(paginaActual); // Guardar la página actual en el historial
        }
        paginaActual = url;
        Console.WriteLine("Visitando: " + paginaActual);
    }

    public void Retroceder()
    {
        if (historial.Count > 0)
        {
            paginaActual = historial.Pop(); // Recuperar la última página visitada
            Console.WriteLine("Retrocediendo a: " + paginaActual);
        }
        else
        {
            Console.WriteLine("No hay páginas anteriores para retroceder.");
        }
    }

    public void MostrarHistorial()
    {
        Console.WriteLine("Historial de navegación:");
        foreach (var pagina in historial)
        {
            Console.WriteLine(pagina);
        }
    }
}

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        NavegadorWeb navegador = new NavegadorWeb();
        navegador.VisitarPagina("www.google.com");
        navegador.VisitarPagina("www.github.com");
        navegador.VisitarPagina("www.stackoverflow.com");

        navegador.Retroceder(); // Debería volver a github
        navegador.Retroceder(); // Debería volver a google
        navegador.Retroceder(); // No hay más páginas en el historial

        navegador.MostrarHistorial(); // Muestra el historial restante

        stopwatch.Stop();
        Console.WriteLine($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");
    }
}
