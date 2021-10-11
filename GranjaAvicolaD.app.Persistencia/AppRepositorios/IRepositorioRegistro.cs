using System.Collections.Generic;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public interface IRepositorioRegistro
    {
        IEnumerable<Registro> GetAllRegistro();

        Registro AddRegistro(Registro registro);

        Registro UpdateRegistro(Registro registro);

        void DeleteRegistro(int idRegistro);

        Registro GetRegistro(int  idRegistro);
    }
}