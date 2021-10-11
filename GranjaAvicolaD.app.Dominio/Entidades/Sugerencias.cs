namespace GranjaAvicolaD.app.Dominio
{
 
    public class Sugerencias
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public string Descripcion { get; set; }
    }
}