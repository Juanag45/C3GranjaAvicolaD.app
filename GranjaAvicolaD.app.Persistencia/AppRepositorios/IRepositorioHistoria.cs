using System.Collections.Generic;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<Historia> GetAllHistoria();

        Historia AddHistoria(Historia historia);

        Historia UpdateHistoria(Historia historia);

        void DeleteHistoria(int idHistoria);

        Historia GetHistoria(int  idHistoria);
    }
}