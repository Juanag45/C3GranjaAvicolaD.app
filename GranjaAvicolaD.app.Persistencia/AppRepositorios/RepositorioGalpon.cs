using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public class RepositorioGalpon: IRepositorioGalpon
    {
        private readonly AppContext _appContext =new AppContext();
      

        Galpon IRepositorioGalpon.AddGalpon(Galpon galpon)
        {
            var galponAdicionado=_appContext.Galpones.Add(galpon);
            _appContext.SaveChanges();
            return galponAdicionado.Entity;
        }

        void IRepositorioGalpon.DeleteGalpon(int idGalpon)
        {
            var galponEncontrado=_appContext.Galpones.Find(idGalpon);
            if (galponEncontrado==null)
                return;
            _appContext.Galpones.Remove(galponEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Galpon> IRepositorioGalpon.GetAllGalpon()
        {
            return _appContext.Galpones;

        }

        Galpon IRepositorioGalpon.GetGalpon(int  idGalpon)
        {
            return _appContext.Galpones.Find(idGalpon);
            
        }

        Galpon IRepositorioGalpon.UpdateGalpon(Galpon galpon)
        {
            var galponEncontrado=_appContext.Galpones.Find(galpon.Id);
            if (galponEncontrado!=null)
            {
                galponEncontrado.NumeroGallinas=galpon.NumeroGallinas;
                galponEncontrado.Ubicacion=galpon.Ubicacion;
                galponEncontrado.Operario=galpon.Operario;
                galponEncontrado.Veterinario=galpon.Veterinario;
                _appContext.SaveChanges();
            }
            return galponEncontrado;
        }

         DatosInicioSesion IRepositorioGalpon.AsignarOperario(int idGalpon,int idDatosInicioSesion)
        {
            var GalponEncontrado = _appContext.Galpones.Find(idGalpon);
            if (GalponEncontrado != null)
            {
                var datosInicioSesionEncontrado = _appContext.DatosInicioSesiones.Where(p => p.Id == idDatosInicioSesion)
                .Include(p => p.Rol)
                .SingleOrDefault();
                if (datosInicioSesionEncontrado != null)
                {
                    GalponEncontrado.Operario = datosInicioSesionEncontrado;
                    _appContext.SaveChanges();
                }
                return datosInicioSesionEncontrado;
            }
            return null;
        }

        DatosInicioSesion IRepositorioGalpon.AsignarVeterinario(int idGalpon,int idDatosInicioSesion)
        {
            var GalponEncontrado = _appContext.Galpones.Find(idGalpon);
            if (GalponEncontrado != null)
            {
                var datosInicioSesionEncontrado = _appContext.DatosInicioSesiones.Where(p => p.Id == idDatosInicioSesion)
                .Include(p => p.Rol)
                .SingleOrDefault();
                if (datosInicioSesionEncontrado != null)
                {
                    GalponEncontrado.Veterinario = datosInicioSesionEncontrado;
                    _appContext.SaveChanges();
                }
                return datosInicioSesionEncontrado;
            }
            return null;
        }
    }
}