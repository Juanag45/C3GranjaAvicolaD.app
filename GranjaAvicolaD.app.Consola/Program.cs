using System.Collections.Generic;
using System;
using GranjaAvicolaD.app.Persistencia;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Consola
{
    class Program
    {
        private static IRepositorioUsuario _repoUsuario=new RepositorioUsuario();
        private static IRepositorioGalpon _repoGalpon=new RepositorioGalpon();

        private static IRepositorioInicioSesion _repoDatosInicioSesion=new RepositorioInicioSesion();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddUsuario();
            AddGalpon();
            AddDatosInicioSesion();
           // BuscarUsuario(1);
           // EliminarUsuario(2);
          // MostrarUsuarios();
        }

        private static void AddUsuario()
        {
            var usuario = new Usuario{
                Nombre="Amor",
                Correo="@gmail",
                Telefono="105556655"
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




        private static void AddGalpon()
        {
            var galpon = new Galpon{
                NumeroGallinas=1000,
                Ubicacion="1",
            };
            _repoGalpon.AddGalpon(galpon);

        }

        // private static void BuscarUsuario(int idUsuario)
        // {
        //     var usuario = _repoUsuario.GetUsuario(idUsuario);
        //     Console.WriteLine(usuario.Nombre);
        // }

        // private static void EliminarUsuario(int idUsuario)
        // {
        //     _repoUsuario.DeleteUsuario(idUsuario);
        //     Console.WriteLine("Usuario Eliminado");
        // }

        // private static void MostrarUsuarios()
        // {
        //     IEnumerable<Usuario> usuarios = _repoUsuario.GetAllUsuario();
        //     foreach (var usuario in usuarios)
        //     {
        //         Console.WriteLine(usuario.Nombre + " " + usuario.Correo);
        //     }
        // }




        private static void AddDatosInicioSesion()
        {
            var datosInicioSesion = new DatosInicioSesion{
                UserName="Amaroo",
                Pasword="hola",
                Rol=Roles.veterinario
            };
            _repoDatosInicioSesion.AddDatosInicioSesion(datosInicioSesion);

        }

        // private static void BuscarUsuario(int idUsuario)
        // {
        //     var usuario = _repoUsuario.GetUsuario(idUsuario);
        //     Console.WriteLine(usuario.Nombre);
        // }

        // private static void EliminarUsuario(int idUsuario)
        // {
        //     _repoUsuario.DeleteUsuario(idUsuario);
        //     Console.WriteLine("Usuario Eliminado");
        // }

        // private static void MostrarUsuarios()
        // {
        //     IEnumerable<Usuario> usuarios = _repoUsuario.GetAllUsuario();
        //     foreach (var usuario in usuarios)
        //     {
        //         Console.WriteLine(usuario.Nombre + " " + usuario.Correo);
        //     }
        // }
    }
}
