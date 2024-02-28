using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaIni { get; set; }
        public float importeTotal { get; set; }
        public int numeroVenta { get; set; }
        public string tipoCondicionPago { get; set; }
        [ForeignKey("Cliente")]
        public int clienteId { get; set; }
        public Cliente cliente { get; set; }
    }
}
