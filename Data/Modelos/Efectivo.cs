using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Efectivo
    {
        [Key]
        public int Id { get; set; }
        public float montoParticular { get; set; }
        [ForeignKey("Cobranza")]
        public int cobranzaId { get; set; }
        public Cobranza cobranza { get; set; }
    }
}
