using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBiblioteca.Model;

namespace GestionBiblioteca.Services
{
    public class LibroService
    {
        private List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro nuevoLibro)
        {
            if (libros.Any(l => l.ISBN == nuevoLibro.ISBN))
            {
                Console.WriteLine("Error: Ya existe un libro con este ISBN.");
                return;
            }
            libros.Add(nuevoLibro);
            Console.WriteLine("Libro agregado correctamente.");
        }

        public void ActualizarLibro(string isbn, Libro libro)
        {
            // Buscar el libro por ISBN
            Libro libroExistente = libros.FirstOrDefault(l => l.ISBN == isbn);

            if (libroExistente == null)
            {
                Console.WriteLine("Error: Libro no encontrado.");
                return;
            }

            // Actualizar los datos del libro
            libroExistente.Titulo = libro.Titulo;
            libroExistente.Autor = libro.Autor;
            libroExistente.AnioPublicacion = libro.AnioPublicacion;

            Console.WriteLine("Libro con ISBN " + isbn + " actualizado correctamente.");
        }

        public void BuscarPorTitulo(string titulo)
        {
            var resultados = libros.Where(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();

            if (resultados.Count == 0)
            {
                Console.WriteLine("No se encontraron libros con ese título.");
                return;
            }
            Console.WriteLine("Resultados de la búsqueda por título:");
            foreach (var libro in resultados)
            {
                Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AnioPublicacion.Year}, ISBN: {libro.ISBN}");
            }
        }

        public void BuscarPorAutor(string autorBusqueda)
        {
            var resultados = libros.Where(l => l.Autor.Contains(autorBusqueda, StringComparison.OrdinalIgnoreCase)).ToList();

            if (resultados.Count == 0)
            {
                Console.WriteLine("No se encontraron libros de ese autor.");
                return;
            }
            Console.WriteLine("Resultados de la búsqueda por autor:");
            foreach (var libro in resultados)
            {
                Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AnioPublicacion.Year}, ISBN: {libro.ISBN}");
            }
        }

        public Libro BuscarLibroPorId(string ISBN)
        {
            // Buscar el libro con el ID especificado
            return libros.FirstOrDefault(libro => libro.ISBN == ISBN);
        }
    }
}
