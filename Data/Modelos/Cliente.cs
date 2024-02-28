using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set;}
        public string cuil {  get; set; }
    }
}
