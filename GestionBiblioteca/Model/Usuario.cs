using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Model
{
    public class Usuario
    {
     
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }

        public Usuario(string nombre, string correoElectronico, string telefono)
        {
            Nombre = nombre;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Correo Electrónico: {CorreoElectronico}, Teléfono: {Telefono}";
        }
    }
}
