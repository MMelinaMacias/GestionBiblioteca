using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBiblioteca.Enums;

namespace GestionBiblioteca.Model
{
    public class Prestamo
    {
        public string Id { get; set; }
        public Usuario Usuario { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public EstadoPrestamo Estado { get; set; }


        public Prestamo(Usuario usuario, Libro libro, DateTime fechaPrestamo,
            DateTime fechaDevolucion, EstadoPrestamo estado)
        {
            Usuario = usuario;
            Libro = libro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Usuario: {Usuario.Nombre}, Libro: {Libro.Titulo}, Fecha de Préstamo: {FechaPrestamo.ToShortDateString()}, " +
                   $"Fecha de Devolución: {FechaDevolucion.ToShortDateString()}, Estado: {Estado}";
        }
        }   
    }
