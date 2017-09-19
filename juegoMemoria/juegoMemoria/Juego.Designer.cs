namespace juegoMemoria
{
    partial class Juego
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
            this.lblMemorizar = new System.Windows.Forms.Label();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.barraTiempo = new System.Windows.Forms.ProgressBar();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMemorizar
            // 
            this.lblMemorizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemorizar.Location = new System.Drawing.Point(25, 22);
            this.lblMemorizar.Name = "lblMemorizar";
            this.lblMemorizar.Size = new System.Drawing.Size(223, 49);
            this.lblMemorizar.TabIndex = 0;
            this.lblMemorizar.Text = "X";
            this.lblMemorizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(12, 116);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(156, 20);
            this.txtLetras.TabIndex = 2;
            this.txtLetras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLetras_KeyDown);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(197, 114);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // barraTiempo
            // 
            this.barraTiempo.Location = new System.Drawing.Point(56, 74);
            this.barraTiempo.Name = "barraTiempo";
            this.barraTiempo.Size = new System.Drawing.Size(163, 23);
            this.barraTiempo.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(86, 157);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(91, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLvl.Location = new System.Drawing.Point(235, 9);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(38, 16);
            this.lblLvl.TabIndex = 6;
            this.lblLvl.Text = "lvl. 1";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.lblLvl);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.barraTiempo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.lblMemorizar);
            this.Name = "Juego";
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.Load += new System.EventHandler(this.Juego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemorizar;
        private System.Windows.Forms.TextBox txtLetras;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ProgressBar barraTiempo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblLvl;
    }
}