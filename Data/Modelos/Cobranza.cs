using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Cobranza
    {
        [Key]
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public int numero { get; set; }
        public float montoTotal { get; set; }
    }
}
