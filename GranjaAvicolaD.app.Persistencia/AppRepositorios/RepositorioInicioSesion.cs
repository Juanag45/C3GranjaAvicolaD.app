using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public class RepositorioInicioSesion : IRepositorioInicioSesion
    {
        private readonly AppContext _appContext =new AppContext();
      

        DatosInicioSesion IRepositorioInicioSesion.AddDatosInicioSesion(DatosInicioSesion datosInicioSesion)
        {
            var datosInicioSesionAdicionado=_appContext.DatosInicioSesiones.Add(datosInicioSesion);
            _appContext.SaveChanges();
            return datosInicioSesionAdicionado.Entity;
        }

        void IRepositorioInicioSesion.DeleteDatosInicioSesion(int idDatosInicioSesion)
        {
            var datosInicioSesionEncontrado=_appContext.DatosInicioSesiones.Find(idDatosInicioSesion);
            if (datosInicioSesionEncontrado==null)
                return;
            _appContext.DatosInicioSesiones.Remove(datosInicioSesionEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<DatosInicioSesion> IRepositorioInicioSesion.GetAllDatosInicioSesion()
        {
            return _appContext.DatosInicioSesiones;

        }

        DatosInicioSesion IRepositorioInicioSesion.GetDatosInicioSesion(int  idDatosInicioSesion)
        {
            return _appContext.DatosInicioSesiones.Find(idDatosInicioSesion);
            
        }

        DatosInicioSesion IRepositorioInicioSesion.UpdateDatosInicioSesion(DatosInicioSesion datosInicioSesion)
        {
            var datosInicioSesionEncontrado=_appContext.DatosInicioSesiones.FirstOrDefault(d=> d.Id==datosInicioSesion.Id);
            if (datosInicioSesionEncontrado!=null)
            {
                datosInicioSesionEncontrado.UserName=datosInicioSesion.UserName;
                datosInicioSesionEncontrado.Pasword=datosInicioSesion.Pasword;
                datosInicioSesionEncontrado.Usuario=datosInicioSesion.Usuario;
                datosInicioSesionEncontrado.Rol=datosInicioSesion.Rol;
                _appContext.SaveChanges();
            }
            return datosInicioSesionEncontrado;
        }
    }
}