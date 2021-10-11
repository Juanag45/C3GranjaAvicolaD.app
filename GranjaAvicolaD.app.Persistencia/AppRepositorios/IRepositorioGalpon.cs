using System.Collections.Generic;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public interface IRepositorioGalpon
    {
         IEnumerable<Galpon> GetAllGalpon();

        Galpon AddGalpon(Galpon galpon);

        Galpon UpdateGalpon(Galpon galpon);

        void DeleteGalpon(int idGalpon);

        Galpon GetGalpon(int  idGalpon);

        DatosInicioSesion AsignarOperario(int idGalpon,int idDatosInicioSesion);

        DatosInicioSesion AsignarVeterinario(int idGalpon,int idDatosInicioSesion);
    }
}