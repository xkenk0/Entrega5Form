namespace Entrega5Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_contenedor = new Panel();
            alta_venta = new Button();
            listar_ventas = new Button();
            panel_contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panel_contenedor
            // 
            panel_contenedor.Controls.Add(alta_venta);
            panel_contenedor.Controls.Add(listar_ventas);
            panel_contenedor.Dock = DockStyle.Fill;
            panel_contenedor.Location = new Point(0, 0);
            panel_contenedor.Name = "panel_contenedor";
            panel_contenedor.Size = new Size(800, 450);
            panel_contenedor.TabIndex = 1;
            // 
            // alta_venta
            // 
            alta_venta.Location = new Point(324, 125);
            alta_venta.Name = "alta_venta";
            alta_venta.Size = new Size(114, 48);
            alta_venta.TabIndex = 2;
            alta_venta.UseVisualStyleBackColor = true;
            alta_venta.Click += button1_Click;
            // 
            // listar_ventas
            // 
            listar_ventas.Location = new Point(324, 238);
            listar_ventas.Name = "listar_ventas";
            listar_ventas.Size = new Size(114, 49);
            listar_ventas.TabIndex = 0;
            listar_ventas.Text = "Listar Ventas";
            listar_ventas.UseVisualStyleBackColor = true;
            listar_ventas.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_contenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel_contenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_contenedor;
        private Button alta_venta;
        private Button listar_ventas;
    }
}
