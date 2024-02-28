using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class ListaPrecioInsumo
    {
        [Key]
        public int Id { get; set; }
        public float precio {  get; set; }
        [ForeignKey("Insumo")]
        public int insumoId { get; set; }
        public Insumo insumo { get; set; }
        [ForeignKey("ListaPrecio")]
        public int listaPrecioId { get; set; }
        public ListaPrecio listaPrecio { get; set; }
    }
}
