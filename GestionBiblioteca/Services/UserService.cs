using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBiblioteca.Model;

namespace GestionBiblioteca.Services
{
    public class UserService
    {
        private List<Usuario> usuariosRegistrados;

        public void AgregarUsuario(Usuario usuario)
        {
            if (usuariosRegistrados.Any(u => u.CorreoElectronico == usuario.CorreoElectronico))
            {
                Console.WriteLine("Error: Ya existe un usuario con este correo electrónico.");
                return;
            }
            usuariosRegistrados.Add(usuario);
            Console.WriteLine("Usuario agregado correctamente.");
        }

        // Método para actualizar los datos de un usuario existente
        public void ActualizarUsuario(int id, Usuario usuario)
        {
            Usuario usuarioExistente = usuariosRegistrados.
                FirstOrDefault(u => u.Id == id);

            if (usuarioExistente == null)
            {
                Console.WriteLine("Error: Usuario con ID" + id + " no encontrado.");
                return;
            }

            usuarioExistente.Nombre = usuario.Nombre;
            usuarioExistente.Telefono = usuario.Telefono;
            Console.WriteLine("Usuario actualizado correctamente.");
        }


        public Usuario BuscarUsuarioPorId(int id)
        {
            return usuariosRegistrados.FirstOrDefault(u => u.Id == id);
        }
    }

}
