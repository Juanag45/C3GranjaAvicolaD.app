using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public class RepositorioHistoria:IRepositorioHistoria
    {
        private readonly AppContext _appContext =new AppContext();
      

        Historia IRepositorioHistoria.AddHistoria(Historia historia)
        {
            var historiaAdicionado=_appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionado.Entity;
        }

        void IRepositorioHistoria.DeleteHistoria(int idHistoria)
        {
            var historiaEncontrado=_appContext.Historias.Find(idHistoria);
            if (historiaEncontrado==null)
                return;
            _appContext.Historias.Remove(historiaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Historia> IRepositorioHistoria.GetAllHistoria()
        {
            return _appContext.Historias;

        }

        Historia IRepositorioHistoria.GetHistoria(int  idHistoria)
        {
            return _appContext.Historias.Find(idHistoria);
            
        }

        Historia IRepositorioHistoria.UpdateHistoria(Historia historia)
        {
            var historiaEncontrado=_appContext.Historias.FirstOrDefault(d=> d.Id==historia.Id);
            if (historiaEncontrado!=null)
            {
                historiaEncontrado.Temperatura=historia.Temperatura;
                historiaEncontrado.NivelAgua=historia.NivelAgua;
                historiaEncontrado.CantidadAlimento=historia.CantidadAlimento;
                historiaEncontrado.GallinasEnfermasPorCuarentena=historia.GallinasEnfermasPorCuarentena;
                historiaEncontrado.Galpon=historia.Galpon;
                historiaEncontrado.Usuario=historia.Usuario;
                _appContext.SaveChanges();
            }
            return historiaEncontrado;
        }
    }
}