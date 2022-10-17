namespace Clase
{
    partial class Ejercicio7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbComedor = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtAlta = new System.Windows.Forms.DateTimePicker();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttQuitar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(361, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 550);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Edad,
            this.Alta,
            this.Comedor,
            this.Turno});
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1155, 140);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(94, 68);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(116, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(46, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alta";
            // 
            // ckbComedor
            // 
            this.ckbComedor.AutoSize = true;
            this.ckbComedor.Location = new System.Drawing.Point(115, 203);
            this.ckbComedor.Name = "ckbComedor";
            this.ckbComedor.Size = new System.Drawing.Size(15, 14);
            this.ckbComedor.TabIndex = 8;
            this.ckbComedor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(46, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Comedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Turno";
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Mediodia",
            "Tarde",
            "Noche"});
            this.cbTurno.Location = new System.Drawing.Point(115, 238);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(121, 21);
            this.cbTurno.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // dtAlta
            // 
            this.dtAlta.Location = new System.Drawing.Point(94, 156);
            this.dtAlta.Name = "dtAlta";
            this.dtAlta.Size = new System.Drawing.Size(200, 20);
            this.dtAlta.TabIndex = 13;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 222;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.Width = 222;
            // 
            // Alta
            // 
            this.Alta.HeaderText = "Alta";
            this.Alta.Name = "Alta";
            this.Alta.Width = 222;
            // 
            // Comedor
            // 
            this.Comedor.HeaderText = "Comedor";
            this.Comedor.Name = "Comedor";
            this.Comedor.Width = 222;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.Width = 222;
            // 
            // bttAgregar
            // 
            this.bttAgregar.Location = new System.Drawing.Point(94, 465);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(161, 43);
            this.bttAgregar.TabIndex = 14;
            this.bttAgregar.Text = "Agregar";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.BttAgregar_Click);
            // 
            // bttQuitar
            // 
            this.bttQuitar.Location = new System.Drawing.Point(94, 506);
            this.bttQuitar.Name = "bttQuitar";
            this.bttQuitar.Size = new System.Drawing.Size(161, 44);
            this.bttQuitar.TabIndex = 15;
            this.bttQuitar.Text = "Quitar";
            this.bttQuitar.UseVisualStyleBackColor = true;
            // 
            // Ejercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 553);
            this.Controls.Add(this.bttQuitar);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.dtAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckbComedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.panel1);
            this.Name = "Ejercicio7";
            this.Text = "Ejercicio7";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbComedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DateTimePicker dtAlta;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttQuitar;
    }
}