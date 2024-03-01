using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class VentaDetalle
    {
        [Key]
        public int Id { get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }
        [ForeignKey("Venta")]
        public int ventaId { get; set; }
        public Venta? venta { get; set; }
        [ForeignKey("Insumo")]
        public int insumoId { get; set; }
        public Insumo insumo { get; set; }
    }
}
