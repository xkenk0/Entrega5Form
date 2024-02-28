using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Insumo
    {
        [Key]
        public int Id { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; }
    }
}
