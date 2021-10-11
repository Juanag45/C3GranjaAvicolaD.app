using System.Collections.Generic;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuario> GetAllUsuario();

        Usuario AddUsuario(Usuario usuario);

        Usuario UpdateUsuario(Usuario usuario);

        void DeleteUsuario(int idUsuario);

        Usuario GetUsuario(int  idUsuario);
    }
}