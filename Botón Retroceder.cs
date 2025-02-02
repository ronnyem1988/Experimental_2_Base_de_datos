//Programación del botón retroceder de un navegador web
using System;
using System.Collections.Generic;

namespace NavegadorWeb
{
    // Clase que representa el navegador web
    public class Navegador
    {
        private Stack<string> historial; // Pila para almacenar las URLs visitadas
        private string paginaActual;     // Página actual en el navegador

        public Navegador()
        {
            historial = new Stack<string>();
            paginaActual = "about:blank"; // Página inicial
        }

        // Método para visitar una nueva página
        public void VisitarPagina(string url)
        {
            historial.Push(paginaActual); // Guardar la página actual en el historial
            paginaActual = url;           // Actualizar la página actual
            Console.WriteLine($"Navegando a: {paginaActual}");
        }

        // Método para retroceder a la página anterior
        public void Retroceder()
        {
            if (historial.Count > 0)
            {
                paginaActual = historial.Pop(); // Obtener la última página visitada
                Console.WriteLine($"Retrocediendo a: {paginaActual}");
            }
            else
            {
                Console.WriteLine("No hay páginas anteriores en el historial.");
            }
        }

        // Método para mostrar el historial de navegación
        public void MostrarHistorial()
        {
            Console.WriteLine("\nHistorial de navegación:");
            foreach (var url in historial)
            {
                Console.WriteLine(url);
            }
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            Navegador navegador = new Navegador();

            // Simulación de navegación
            navegador.VisitarPagina("https://www.outlook.com");
            navegador.VisitarPagina("https://www.facebook.com");
            navegador.VisitarPagina("https://www.instagram.com");

            // Retroceder
            navegador.Retroceder();
            navegador.Retroceder();

            // Mostrar historial
            navegador.MostrarHistorial();
        }
    }
}