using System;
namespace GranjaAvicolaD.app.Dominio
{
 
    public class Registro
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Usuario { get; set; }
        

    }
}