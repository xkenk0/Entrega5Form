using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Domicilio
    {
        [Key]
        public int Id { get; set; }
        public int numero { get; set; }
        public string calle {  get; set; }
        [ForeignKey("Localidad")]
        public int localidadId { get; set; }
        public Localidad localidad { get; set; }
        [ForeignKey("Cliente")]
        public int clienteId { get; set; }
        public Cliente cliente { get; set; }
    }
}
