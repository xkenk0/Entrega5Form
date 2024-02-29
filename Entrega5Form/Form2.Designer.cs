namespace Entrega5Form
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buscador_venta = new TextBox();
            buscador_cliente = new TextBox();
            numero_venta = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 308);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buscador_venta
            // 
            buscador_venta.Location = new Point(29, 37);
            buscador_venta.Name = "buscador_venta";
            buscador_venta.Size = new Size(169, 23);
            buscador_venta.TabIndex = 1;
            buscador_venta.TextChanged += textBox1_TextChanged;
            // 
            // buscador_cliente
            // 
            buscador_cliente.Location = new Point(594, 37);
            buscador_cliente.Name = "buscador_cliente";
            buscador_cliente.Size = new Size(169, 23);
            buscador_cliente.TabIndex = 3;
            // 
            // numero_venta
            // 
            numero_venta.AutoSize = true;
            numero_venta.Location = new Point(30, 15);
            numero_venta.Name = "numero_venta";
            numero_venta.Size = new Size(99, 15);
            numero_venta.TabIndex = 4;
            numero_venta.Text = "Numero de venta";
            numero_venta.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 19);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(646, 406);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 6;
            button1.Text = "Volver al menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(516, 406);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "VENTA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(numero_venta);
            Controls.Add(buscador_cliente);
            Controls.Add(buscador_venta);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox buscador_venta;
        private TextBox buscador_cliente;
        private Label numero_venta;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}