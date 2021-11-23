using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace PracticaJigsaw.Models
{
    public class Rompecabezas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Cantidad de piezas")]
        public int NumPiezas { get; set; }
        [StringLength(20, MinimumLength = 2)]
        public string Marca { get; set; }
        [Required]
        [Display(Name = "Edad sugerida")]
        public string RangoEdad { get; set; }
        [StringLength(20, MinimumLength = 2)]
        public string Autor { get; set; }
        [StringLength(20, MinimumLength = 2)]
        public string Distribuidor { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Tema { get; set; }
        [StringLength(20, MinimumLength = 2)]
        public string Nombre { get; set; }
        [Required]
        public string Medidas { get; set; }
        [Required]
        [Column(TypeName = "decimal(5,2)")]
        [DataType(DataType.Currency)]
        public double Precio { get; set; }
    }
}
