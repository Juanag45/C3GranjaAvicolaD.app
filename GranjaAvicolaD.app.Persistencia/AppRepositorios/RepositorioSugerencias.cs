using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public class RepositorioSugerencias:IRepositorioSugerencias
    {
         private readonly AppContext _appContext =new AppContext();
      

        Sugerencias IRepositorioSugerencias.AddSugerencias(Sugerencias sugerencias)
        {
            var sugerenciasAdicionado=_appContext.Sugerencia.Add(sugerencias);
            _appContext.SaveChanges();
            return sugerenciasAdicionado.Entity;
        }

        void IRepositorioSugerencias.DeleteSugerencias(int idSugerencias)
        {
            var sugerenciasEncontrado=_appContext.Sugerencia.FirstOrDefault(d=>d.Id==idSugerencias);
            if (sugerenciasEncontrado==null)
                return;
            _appContext.Sugerencia.Remove(sugerenciasEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Sugerencias> IRepositorioSugerencias.GetAllSugerencias()
        {
            return _appContext.Sugerencia;

        }

        Sugerencias IRepositorioSugerencias.GetSugerencias(int  idSugerencias)
        {
            return _appContext.Sugerencia.FirstOrDefault(d=>d.Id==idSugerencias);
            
        }

        Sugerencias IRepositorioSugerencias.UpdateSugerencias(Sugerencias sugerencias)
        {
            var sugerenciasEncontrado=_appContext.Sugerencia.FirstOrDefault(d=> d.Id==sugerencias.Id);
            if (sugerenciasEncontrado!=null)
            {
                sugerenciasEncontrado.Descripcion=sugerencias.Descripcion;
                sugerenciasEncontrado.Usuario=sugerencias.Usuario;
                _appContext.SaveChanges();
            }
            return sugerenciasEncontrado;
        }
    }
}