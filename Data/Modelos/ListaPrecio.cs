using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class ListaPrecio
    {
        [Key]
        public int Id { get; set; }
        public string tipoCondicionPago { get; set; }
    }
}
