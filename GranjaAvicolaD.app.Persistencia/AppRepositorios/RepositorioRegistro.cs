using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public class RepositorioRegistro:IRepositorioRegistro
    {
         private readonly AppContext _appContext =new AppContext();
      

        Registro IRepositorioRegistro.AddRegistro(Registro registro)
        {
            var registroAdicionado=_appContext.Registros.Add(registro);
            _appContext.SaveChanges();
            return registroAdicionado.Entity;
        }

        void IRepositorioRegistro.DeleteRegistro(int idRegistro)
        {
            var registroEncontrado=_appContext.Registros.FirstOrDefault(d=>d.Id==idRegistro);
            if (registroEncontrado==null)
                return;
            _appContext.Registros.Remove(registroEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Registro> IRepositorioRegistro.GetAllRegistro()
        {
            return _appContext.Registros;

        }

        Registro IRepositorioRegistro.GetRegistro(int  idRegistro)
        {
            return _appContext.Registros.FirstOrDefault(d=>d.Id==idRegistro);
            
        }

        Registro IRepositorioRegistro.UpdateRegistro(Registro registro)
        {
            var registroEncontrado=_appContext.Registros.FirstOrDefault(d=> d.Id==registro.Id);
            if (registroEncontrado!=null)
            {
                registroEncontrado.Fecha=registro.Fecha;
                registroEncontrado.Usuario=registro.Usuario;
                _appContext.SaveChanges();
            }
            return registroEncontrado;
        }
    }
}