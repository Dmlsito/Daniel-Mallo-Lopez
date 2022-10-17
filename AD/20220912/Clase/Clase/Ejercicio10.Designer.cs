namespace Clase
{
    partial class Ejercicio10
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblLenguaje = new System.Windows.Forms.Label();
            this.btnLenguaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.comboBox1.Location = new System.Drawing.Point(143, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblLenguaje
            // 
            this.lblLenguaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenguaje.Location = new System.Drawing.Point(21, 28);
            this.lblLenguaje.Name = "lblLenguaje";
            this.lblLenguaje.Size = new System.Drawing.Size(104, 45);
            this.lblLenguaje.TabIndex = 1;
            this.lblLenguaje.Text = "Lenguaje";
            // 
            // btnLenguaje
            // 
            this.btnLenguaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLenguaje.Location = new System.Drawing.Point(12, 104);
            this.btnLenguaje.Name = "btnLenguaje";
            this.btnLenguaje.Size = new System.Drawing.Size(156, 39);
            this.btnLenguaje.TabIndex = 2;
            this.btnLenguaje.Text = "Cambiar";
            this.btnLenguaje.UseVisualStyleBackColor = true;
            this.btnLenguaje.Click += new System.EventHandler(this.btnLenguaje_Click);
            // 
            // Ejercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLenguaje);
            this.Controls.Add(this.lblLenguaje);
            this.Controls.Add(this.comboBox1);
            this.Name = "Ejercicio10";
            this.Text = "Ejercicio10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblLenguaje;
        private System.Windows.Forms.Button btnLenguaje;
    }
}