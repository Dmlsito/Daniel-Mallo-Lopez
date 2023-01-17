namespace WinFormsEx
{
    partial class FParte1
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
            this.components = new System.ComponentModel.Container();
            this.labelNumero = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonIncrementar = new System.Windows.Forms.Button();
            this.buttonDecrementar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(345, 151);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(0, 13);
            this.labelNumero.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonIncrementar
            // 
            this.buttonIncrementar.Location = new System.Drawing.Point(181, 235);
            this.buttonIncrementar.Name = "buttonIncrementar";
            this.buttonIncrementar.Size = new System.Drawing.Size(162, 50);
            this.buttonIncrementar.TabIndex = 1;
            this.buttonIncrementar.Text = "Incrementar";
            this.buttonIncrementar.UseVisualStyleBackColor = true;
            this.buttonIncrementar.Click += new System.EventHandler(this.buttonIncrementar_Click);
            // 
            // buttonDecrementar
            // 
            this.buttonDecrementar.Location = new System.Drawing.Point(425, 235);
            this.buttonDecrementar.Name = "buttonDecrementar";
            this.buttonDecrementar.Size = new System.Drawing.Size(146, 50);
            this.buttonDecrementar.TabIndex = 2;
            this.buttonDecrementar.Text = "Decrementar";
            this.buttonDecrementar.UseVisualStyleBackColor = true;
            this.buttonDecrementar.Click += new System.EventHandler(this.buttonDecrementar_Click);
            // 
            // FParte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDecrementar);
            this.Controls.Add(this.buttonIncrementar);
            this.Controls.Add(this.labelNumero);
            this.Name = "FParte1";
            this.Text = "FParte1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonIncrementar;
        private System.Windows.Forms.Button buttonDecrementar;
    }
}