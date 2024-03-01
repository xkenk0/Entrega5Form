using Microsoft.EntityFrameworkCore;
using Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public partial class Entrega5DbContext : DbContext
    {
        public Entrega5DbContext()
        {
        }

        public Entrega5DbContext(DbContextOptions<Entrega5DbContext> options) : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cobranza> Cobranza { get; set; }
        public virtual DbSet<Cuota> Cuota { get; set; }
        public virtual DbSet<Domicilio> Domicilio { get; set; }
        public virtual DbSet<Efectivo> Efectivo { get; set; }
        public virtual DbSet<Insumo> Insumo { get; set; }
        public virtual DbSet<ListaPrecio> ListaPrecio { get; set; }
        public virtual DbSet<ListaPrecioInsumo> ListaPrecioInsumo { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Tarjeta> Tarjeta {  get; set; }
        public virtual DbSet<TransferenciaBancaria> TransferenciaBancaria {  get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<VentaDetalle> VentaDetalle { get; set; }
        public virtual DbSet<TipoCondicionPago> TipoCondicionPago { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

              => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Entrega5;Username=postgres;Password=Estudiantes000");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
