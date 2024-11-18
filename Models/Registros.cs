using System.ComponentModel.DataAnnotations;

namespace RalfyGenao_AP1_P2.Models
{
    public class Registros
    {
        [Key]
        public int RegistroId { get; set; }
        [Required(ErrorMessage = "Por Favor Completar el Campos")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Por Favor Completar el Campos")]
        public string? Descripcion { get; set; }
    }
}
