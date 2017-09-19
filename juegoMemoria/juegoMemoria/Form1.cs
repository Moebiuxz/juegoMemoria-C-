using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegoMemoria
{
    public partial class Form1 : Form
    {
        private int dificultad;
        private string caracteres;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            caracteres = "";
            cargarValores();
        }

        public void cargarValores()
        {
            bool validar = false;
            if (opTurista.Checked)
            {
                dificultad = 6;
            }
            else if (opNormal.Checked)
            {
                dificultad = 4;
            }
            else
            {
                dificultad = 2;
            }

            if (chkLetras.Checked)
            {
                caracteres += "abcdefghijklmnopqrstuvwxyz";
                validar = true;
            }
            if (chkNumeros.Checked)
            {
                caracteres += "0123456789";
                validar = true;
            }
            if (chkSimbolos.Checked)
            {
                caracteres += "+-*/#$%&=";
                validar = true;
            }

            if (validar)
            {
                Juego j = new Juego(dificultad, caracteres);
                j.Show();
            }
            else
            {
                MessageBox.Show(
                    "Seleccione caracteres!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Memo# v0.0.1";
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Record r = new Record();
            r.Show();
        }
    }
}
