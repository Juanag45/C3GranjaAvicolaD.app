namespace GranjaAvicolaD.app.Dominio
{

    public class Historia
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public float Temperatura { get; set; }
        public float NivelAgua { get; set; }
        public float CantidadAlimento { get; set; }
        public int GallinasEnfermasPorCuarentena { get; set; }
        public Galpon Galpon { get; set; }
        public Usuario Usuario { get; set; }
    }
}