
using System.Collections.Generic;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public interface IRepositorioInicioSesion
    {
        IEnumerable<DatosInicioSesion> GetAllDatosInicioSesion();

        DatosInicioSesion AddDatosInicioSesion(DatosInicioSesion datosInicioSesion);

        DatosInicioSesion UpdateDatosInicioSesion(DatosInicioSesion datosInicioSesion);

        void DeleteDatosInicioSesion(int idDatosInicioSesion);

        DatosInicioSesion GetDatosInicioSesion(int  idDatosInicioSesion);


    }
}