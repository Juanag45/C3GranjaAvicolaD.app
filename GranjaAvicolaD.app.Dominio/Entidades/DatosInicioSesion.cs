namespace GranjaAvicolaD.app.Dominio
{
  
    public class DatosInicioSesion
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Pasword { get; set; }
        public Usuario Usuario { get; set; }
        public Roles Rol { get; set; }
    }
}