using System.ComponentModel.DataAnnotations;

namespace ClasesIdioma.Modelos
{
    public class Idioma
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del idioma es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }
        public virtual ICollection<Clase> Clases { get; set; } = new List<Clase>();
        public virtual ICollection<Maestro> Maestros { get; set; } = new List<Maestro>();
    }
}
