using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Model
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime AnioPublicacion { get; set; }
        public string ISBN { get; set; }
        public bool Disponibilidad { get; set; }


        public Libro(string titulo, string autor, DateTime anioPublicacion, string isbn)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
            ISBN = isbn;
            Disponibilidad = true;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Año de Publicación: {AnioPublicacion.Year}, ISBN: {ISBN}, Disponibilidad: {(Disponibilidad ? "Disponible" : "No disponible")}";
        }
    }


}
