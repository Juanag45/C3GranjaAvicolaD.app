using System.Collections.Generic;
using System;
using GranjaAvicolaD.app.Persistencia;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Consola
{
    class Program
    {
        private static IRepositorioUsuario _repoUsuario=new RepositorioUsuario();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddUsuario();
           // BuscarUsuario(1);
           // EliminarUsuario(2);
          // MostrarUsuarios();
        }

        private static void AddUsuario()
        {
            var usuario = new Usuario{
                Nombre="juan",
                Correo="@gmail",
                Telefono="6777775"
            };
            _repoUsuario.AddUsuario(usuario);

        }

        private static void BuscarUsuario(int idUsuario)
        {
            var usuario = _repoUsuario.GetUsuario(idUsuario);
            Console.WriteLine(usuario.Nombre);
        }

        private static void EliminarUsuario(int idUsuario)
        {
            _repoUsuario.DeleteUsuario(idUsuario);
            Console.WriteLine("Usuario Eliminado");
        }

        private static void MostrarUsuarios()
        {
            IEnumerable<Usuario> usuarios = _repoUsuario.GetAllUsuario();
            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario.Nombre + " " + usuario.Correo);
            }
        }

    }
}
