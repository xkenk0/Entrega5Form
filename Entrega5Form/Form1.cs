using Data.Data;
using Data.Modelos;
using Npgsql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega5Form
{
    public partial class Form1 : Form
    {
        private Entrega5DbContext _entrega5DbContext;
        private Venta venta;
        private Cliente cliente;
        private Insumo insumo;
        private DateTime fechaIni = DateTime.UtcNow;
        private DateTime fechaFin = DateTime.UtcNow.AddDays(30);
        public Form1()
        {
            InitializeComponent();
            _entrega5DbContext = new Entrega5DbContext();
            Form1_Load(this, EventArgs.Empty);
            textBox1.TextChanged += textBox1_TextChanged;
            textBox4.TextChanged += textBox4_TextChanged;
            button1.Click += button1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var tipoCondPago = _entrega5DbContext.TipoCondicionPago.ToList();

            foreach (var tipoCondicionPago in tipoCondPago)
            {
                comboBox1.Items.Add(tipoCondicionPago.nombre);
            }

            label9.Text = Convert.ToString(fechaIni);
            label10.Text = Convert.ToString(fechaFin);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int ObtenerUltimoNumeroVenta()
        {
            var ultimaVenta = _entrega5DbContext.Venta.OrderByDescending(v => v.numeroVenta).FirstOrDefault();
            if (ultimaVenta == null)
            {
                return 0;
            }
            else
            {
                return ultimaVenta.numeroVenta;
            }
        }

        private int ObtenerUltimoIdVentaDetalle()
        {
            var ultimaVentaDetalle = _entrega5DbContext.VentaDetalle.OrderByDescending(v => v.Id).FirstOrDefault();
            if (ultimaVentaDetalle != null)
            {
                return ultimaVentaDetalle.Id;
            }
            else
            {
                return 0;
            }
        }
        private int ObtenerUltimoIdVenta()
        {
            var ultimaVenta = _entrega5DbContext.Venta.OrderByDescending(v => v.Id).FirstOrDefault();
            if (ultimaVenta != null)
            {
                return ultimaVenta.Id;
            }
            else
            {
                return 0;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Accion" && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string datoSeleccionado = listBox1.SelectedItem.ToString();
                string[] partes = datoSeleccionado.Split(' ');

                if (partes.Length >= 1)
                {
                    string cuit = partes[partes.Length - 1];
                    label11.Text = cuit;
                }
                else
                {
                    MessageBox.Show("El formato del dato seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento del ListBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Cliente> BuscarClientes(string abuscar)
        {
            List<Cliente> clientesBuscados = _entrega5DbContext.Cliente.Where(c => c.cuil.Contains(abuscar) || c.nombre.Contains(abuscar) || c.apellido.Contains(abuscar)).ToList();
            return clientesBuscados;
        }

        private List<Insumo> BuscarInsumo(string abuscar)
        {
            List<Insumo> insumosBuscados = _entrega5DbContext.Insumo.Where(i => i.nombre.Contains(abuscar)).ToList();
            return insumosBuscados;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                listBox2.Items.Clear();
            }
            else
            {
                string abuscar = textBox4.Text.Trim();
                List<Insumo> insumos = BuscarInsumo(abuscar);
                listBox2.Items.Clear();
                foreach (Insumo insumo in insumos)
                {
                    listBox2.Items.Add(insumo.Id + " " + insumo.nombre);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Clear();
            }
            else
            {
                string abuscar = textBox1.Text.Trim();
                List<Cliente> clientes = BuscarClientes(abuscar);
                listBox1.Items.Clear();
                foreach (Cliente cliente in clientes)
                {
                    listBox1.Items.Add(cliente.nombre + " " + cliente.apellido + " " + cliente.cuil);
                }
            }
        }

        private void AgregarFila(int codigo, string nombre, int cantidad, float precio, float subtotal)
        {
            string eliminar = "Eliminar";
            dataGridView1.Rows.Add(codigo, nombre, cantidad, precio, subtotal, eliminar);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.ToString != null && numericUpDown2.Value > 0 && numericUpDown2.Value != null)
            {
                string datoSeleccionado = listBox2.SelectedItem.ToString();
                string[] partes = datoSeleccionado.Split(' ');
                string id = partes[0];
                string nombre = partes[1];
                int insumoId = int.Parse(id);
                int cantidad = Convert.ToInt32(numericUpDown2.Value);
                float precioUnitario = _entrega5DbContext.ListaPrecioInsumo.FirstOrDefault(i => i.insumoId == insumoId).precio;
                float precioTotal = precioUnitario * Convert.ToInt32(numericUpDown2.Value);
                AgregarFila(insumoId, nombre, cantidad, precioTotal, precioUnitario);

            }
            else
            {
                MessageBox.Show("Error en la carga de datos para agregar un detalle de Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private float AgregarFilaABaseDeDatos(DataGridViewRow fila, Venta venta, int auxiliar)
        {
            List<object> valoresCeldas = new List<object>();
            foreach (DataGridViewCell celda in (fila.Cells))
            {
                valoresCeldas.Add(celda.Value);
            }
            VentaDetalle ventaDetalle = new VentaDetalle
            {
                Id = ObtenerUltimoIdVentaDetalle() + auxiliar, 
                cantidad = Convert.ToInt32(valoresCeldas[2]), 
                precio = Convert.ToSingle(valoresCeldas[3]),
                insumoId = Convert.ToInt32(valoresCeldas[0]),             
                insumo = _entrega5DbContext.Insumo.FirstOrDefault(i => i.Id == (Convert.ToInt32(valoresCeldas[0]))),
                ventaId = venta.Id,
            };
            _entrega5DbContext.VentaDetalle.Add(ventaDetalle);
            return Convert.ToSingle(valoresCeldas[3]);
        }

        private List<Cuota> CrearCuotas(Venta venta, int cantidadCuotas)
        {
            List<Cuota> cuotas = new List<Cuota>();
            float montoCuota = venta.importeTotal / cantidadCuotas;

            for (int i = 1; i <= cantidadCuotas; i++)
            {
                Cuota cuota = new Cuota
                {
                    fechaIni = fechaIni,
                    fechaFin = fechaFin.AddMonths(i),
                    monto = montoCuota,
                    numero = i,
                    ventaId = venta.Id,
                };
                cuotas.Add(cuota);
            }
            return cuotas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 1 && label11.Text != null && numericUpDown1.Value > 0 && comboBox1.Text != null)
            {
                Venta venta = new Venta();
                float aux = 0;
                int auxiliar = 1;
                venta.Id = ObtenerUltimoIdVenta() + 1;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow fila = dataGridView1.Rows[i];
                    aux = aux + AgregarFilaABaseDeDatos(fila, venta, auxiliar);
                    auxiliar++;
                }
                venta.cliente = _entrega5DbContext.Cliente.FirstOrDefault(c => c.cuil == label11.Text);
                venta.clienteId = _entrega5DbContext.Cliente.FirstOrDefault(c => c.cuil == label11.Text).Id;
                venta.tipoCondicionPago = comboBox1.Text;
                venta.numeroVenta = ObtenerUltimoNumeroVenta() + 1;
                venta.fechaIni = fechaIni;
                venta.fechaFin = fechaFin;
                venta.importeTotal = aux;
                List<Cuota> cuotas = CrearCuotas(venta, (int)numericUpDown1.Value);
                venta.cuotas = cuotas;
                MessageBox.Show("Cuotas creadas satisfactoriamente");
                _entrega5DbContext.Venta.Add(venta);
                _entrega5DbContext.SaveChanges();
                MessageBox.Show("Venta agregada satisfactoriamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}

