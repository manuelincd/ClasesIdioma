﻿using System.ComponentModel.DataAnnotations;

namespace ClasesIdioma.Modelos
{
    public class Maestro
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El teléfono es requerido")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string? Telefono { get; set; }
        public int IdiomaId { get; set; }
        public virtual Idioma Idioma { get; set; } = null!;
        public ICollection<Clase> Clases { get; set; } = new List<Clase>();
    }
}
