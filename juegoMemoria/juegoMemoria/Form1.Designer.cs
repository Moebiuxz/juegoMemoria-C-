namespace juegoMemoria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opDificil = new System.Windows.Forms.RadioButton();
            this.opNormal = new System.Windows.Forms.RadioButton();
            this.opTurista = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSimbolos = new System.Windows.Forms.CheckBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.chkLetras = new System.Windows.Forms.CheckBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(75, 147);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(122, 51);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opDificil);
            this.groupBox1.Controls.Add(this.opNormal);
            this.groupBox1.Controls.Add(this.opTurista);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dificultad";
            // 
            // opDificil
            // 
            this.opDificil.AutoSize = true;
            this.opDificil.Location = new System.Drawing.Point(7, 68);
            this.opDificil.Name = "opDificil";
            this.opDificil.Size = new System.Drawing.Size(52, 17);
            this.opDificil.TabIndex = 2;
            this.opDificil.Text = "Difícil";
            this.opDificil.UseVisualStyleBackColor = true;
            // 
            // opNormal
            // 
            this.opNormal.AutoSize = true;
            this.opNormal.Location = new System.Drawing.Point(7, 44);
            this.opNormal.Name = "opNormal";
            this.opNormal.Size = new System.Drawing.Size(58, 17);
            this.opNormal.TabIndex = 1;
            this.opNormal.Text = "Normal";
            this.opNormal.UseVisualStyleBackColor = true;
            // 
            // opTurista
            // 
            this.opTurista.AutoSize = true;
            this.opTurista.Checked = true;
            this.opTurista.Location = new System.Drawing.Point(7, 20);
            this.opTurista.Name = "opTurista";
            this.opTurista.Size = new System.Drawing.Size(57, 17);
            this.opTurista.TabIndex = 0;
            this.opTurista.TabStop = true;
            this.opTurista.Text = "Turista";
            this.opTurista.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSimbolos);
            this.groupBox2.Controls.Add(this.chkNumeros);
            this.groupBox2.Controls.Add(this.chkLetras);
            this.groupBox2.Location = new System.Drawing.Point(135, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caracteres";
            // 
            // chkSimbolos
            // 
            this.chkSimbolos.AutoSize = true;
            this.chkSimbolos.Location = new System.Drawing.Point(7, 68);
            this.chkSimbolos.Name = "chkSimbolos";
            this.chkSimbolos.Size = new System.Drawing.Size(70, 17);
            this.chkSimbolos.TabIndex = 2;
            this.chkSimbolos.Text = "Símbolos";
            this.chkSimbolos.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Location = new System.Drawing.Point(7, 44);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(68, 17);
            this.chkNumeros.TabIndex = 1;
            this.chkNumeros.Text = "Números";
            this.chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkLetras
            // 
            this.chkLetras.AutoSize = true;
            this.chkLetras.Location = new System.Drawing.Point(7, 20);
            this.chkLetras.Name = "chkLetras";
            this.chkLetras.Size = new System.Drawing.Size(55, 17);
            this.chkLetras.TabIndex = 0;
            this.chkLetras.Text = "Letras";
            this.chkLetras.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRecord.Location = new System.Drawing.Point(2, 237);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(283, 23);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Mejores puntajes";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opDificil;
        private System.Windows.Forms.RadioButton opNormal;
        private System.Windows.Forms.RadioButton opTurista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSimbolos;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox chkLetras;
        private System.Windows.Forms.Button btnRecord;
    }
}

