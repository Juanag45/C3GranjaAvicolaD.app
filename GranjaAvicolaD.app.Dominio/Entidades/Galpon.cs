namespace GranjaAvicolaD.app.Dominio
{
   
    public class Galpon
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public int NumeroGallinas { get; set; }
        public string Ubicacion { get; set; }
        public DatosInicioSesion Operario { get; set; }
        public DatosInicioSesion Veterinario { get; set; }
    }
}