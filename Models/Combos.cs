using System.ComponentModel.DataAnnotations;

namespace RalfyGenao_AP1_P2.Models
{
    public class Combos
    {
        [Key]
        public int ComboId { get; set; }
        [Required(ErrorMessage = "Por Favor Completar el Campos")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Por Favor Completar el Campos")]
        public string? Descripcion { get; set; }
        public string? Articulo { get; set; }
        [Required(ErrorMessage = "Por Favor llenar el Precio")]
        public decimal? Precio { get; set; }
       
        public string vendido { get; set; }
    }
}
