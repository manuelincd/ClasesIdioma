namespace ClasesIdioma.Modelos
{
    public class Clase
    {
        public int Id { get; set; }
        public int IdiomaId { get; set; }
        public virtual Idioma Idioma { get; set; } = null!;
        public string? Nivel { get; set; }
        public string? Horario { get; set; }
        public int MaestroId { get; set; }
        public virtual Maestro Maestro { get; set; } = null!;
        virtual public ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    }
}
