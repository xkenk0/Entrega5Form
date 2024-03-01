namespace Entrega5Form
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewButtonColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            listBox2 = new ListBox();
            button5 = new Button();
            listBox1 = new ListBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 18);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 18);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de vencimiento:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 56);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 132);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 4;
            label5.Text = "Condicion de pago:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 132);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 5;
            label6.Text = "Cantidad de cuotas:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(362, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 24);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 9;
            label7.Text = "Codigo de producto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(395, 24);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 10;
            label8.Text = "Cantidad:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 21);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(103, 23);
            textBox4.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Cantidad, Precio, Subtotal, Accion });
            dataGridView1.Location = new Point(8, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 148);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // Accion
            // 
            Accion.HeaderText = "Accion";
            Accion.Name = "Accion";
            Accion.Resizable = DataGridViewTriState.True;
            Accion.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            button1.Location = new Point(464, 470);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(557, 470);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(138, 83);
            button3.Name = "button3";
            button3.Size = new Size(61, 25);
            button3.TabIndex = 16;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 23);
            textBox1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(12, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 257);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(459, 21);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(69, 23);
            numericUpDown2.TabIndex = 23;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(267, 21);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(111, 64);
            listBox2.TabIndex = 22;
            // 
            // button5
            // 
            button5.Location = new Point(557, 21);
            button5.Name = "button5";
            button5.Size = new Size(64, 23);
            button5.TabIndex = 21;
            button5.Text = "Agregar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(317, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(331, 64);
            listBox1.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(91, 18);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(470, 18);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(90, 56);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 25;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(29, 159);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(72, 23);
            numericUpDown1.TabIndex = 26;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 505);
            Controls.Add(numericUpDown1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button button5;
        private ListBox listBox1;
        private Label label9;
        private Label label10;
        private Label label11;
        private ListBox listBox2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn Accion;
    }
}