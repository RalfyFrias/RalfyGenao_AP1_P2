using System.ComponentModel.DataAnnotations;

namespace RalfyGenao_AP1_P2.Models
{
    public class CombosDetalle
    {
        [Key]
        public int DetalleId { get; set; }

        public int ComboId { get; set; }

        public int ArticuloId { get; set; }

        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }

    }
}
