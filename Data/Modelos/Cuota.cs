using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Cuota
    {
        [Key]
        public int Id { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaIni { get; set; }
        public float monto { get; set; }
        public int numero { get; set; }
        [ForeignKey("Venta")]
        public int ventaId { get; set; }
        public Venta venta {  get; set; }
        [ForeignKey("Cobranza")]
        public int? cobranzaId { get; set; }
        public Cobranza? cobranza { get; set; }
    }
}
