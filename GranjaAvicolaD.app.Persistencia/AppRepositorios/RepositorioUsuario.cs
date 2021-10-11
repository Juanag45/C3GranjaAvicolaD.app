using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public class RepositorioUsuario:IRepositorioUsuario
    {
         private readonly AppContext _appContext =new AppContext();
      

        Usuario IRepositorioUsuario.AddUsuario(Usuario usuario)
        {
            var usuarioAdicionado=_appContext.Usuarios.Add(usuario);
            _appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }

        void IRepositorioUsuario.DeleteUsuario(int idUsuario)
        {
            var usuarioEncontrado=_appContext.Usuarios.FirstOrDefault(d=>d.Id==idUsuario);
            if (usuarioEncontrado==null)
                return;
            _appContext.Usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuario()
        {
            return _appContext.Usuarios;

        }

        Usuario IRepositorioUsuario.GetUsuario(int  idUsuario)
        {
            return _appContext.Usuarios.Find(idUsuario);
            
        }

        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario)
        {
            var usuarioEncontrado=_appContext.Usuarios.FirstOrDefault(d=> d.Id==usuario.Id);
            if (usuarioEncontrado!=null)
            {
                usuarioEncontrado.Nombre=usuario.Nombre;
                usuarioEncontrado.Correo=usuario.Correo;
                usuarioEncontrado.Telefono=usuario.Telefono;
                _appContext.SaveChanges();
            }
            return usuarioEncontrado;
        }
    }
}