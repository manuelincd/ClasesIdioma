using System.ComponentModel.DataAnnotations;

namespace ClasesIdioma.Modelos
{
    public class Clase
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El idioma es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un idioma válido")]
        public int IdiomaId { get; set; }
        public virtual Idioma Idioma { get; set; } = null!;
        [Required(ErrorMessage = "El nivel es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nivel { get; set; }
        [Required(ErrorMessage = "El horario es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Horario { get; set; }
        [Required(ErrorMessage = "El maestro es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un maestro válido")]
        public int MaestroId { get; set; }
        public virtual Maestro Maestro { get; set; } = null!;
        virtual public ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    }
}
