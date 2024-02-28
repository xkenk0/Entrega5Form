using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Localidad
    {
        [Key]
        public int Id { get; set; }
        public string nombre { get; set; }
        [ForeignKey("Provincia")]
        public int provinciaId { get; set; }
        public Provincia provincia { get; set; }
    }
}
