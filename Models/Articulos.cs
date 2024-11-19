using System.ComponentModel.DataAnnotations;

namespace RalfyGenao_AP1_P2.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        [Required(ErrorMessage = "Por Favor Completar el Campos")]
        public string DiscoSSD { get; set; }
        public int Memoria { get; set; }
        

    }
}
