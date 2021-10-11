using System.Collections.Generic;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public interface IRepositorioSugerencias
    {
        IEnumerable<Sugerencias> GetAllSugerencias();

        Sugerencias AddSugerencias(Sugerencias sugerencias);

        Sugerencias UpdateSugerencias(Sugerencias sugerencias);

        void DeleteSugerencias(int idSugerencias);

        Sugerencias GetSugerencias(int  idSugerencias);
    }
}