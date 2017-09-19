using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegoMemoria
{
    public partial class Juego : Form
    {
        private string caracteres;
        private int dificultad;
        private string level;
        private string letras = "";
        private Thread h1;
        private List<Jugador> records; 

        public Juego(int dificultad, string caracteres)
        {
            records = new List<Jugador>();

            this.caracteres = caracteres;
            this.dificultad = dificultad;
            InitializeComponent();
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            if (File.Exists(Data.RUTA))
            {
                records = Data.leer();
            }
            lblResultado.Text = "";
            txtLetras.ReadOnly = true;
            btnAceptar.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            this.Text = "Memo# v0.0.1";
            hiloJuego();
            txtLetras.Focus();

        }

        public void hiloJuego()
        {
            h1 = new Thread(new ThreadStart(HiloTiempo));
            h1.Start();
        }

        public string generarLvl(int cantidad)
        {
            var random = new Random();
            return new string(Enumerable.Repeat(caracteres, cantidad)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void HiloTiempo()
        {
            barraTiempo.Value = 0;
            level = (letras.Length + 1).ToString();
            lblLvl.Text = "lvl. " + (letras.Length + 1).ToString();
            string letrasMemorizar = generarLvl(letras.Length + 1).ToUpper();
            lblMemorizar.Text = letrasMemorizar;
            letras = lblMemorizar.Text;
            int seg = 0;
            int incremento = 100/dificultad;
            if (dificultad == 6)
            {
                incremento = 17;
            }
            while (seg < dificultad)
            {
                Thread.Sleep(500);
                lblResultado.Text = "";
                barraTiempo.Increment(incremento);
                Thread.Sleep(500);
                
                seg++;
            }
            lblMemorizar.Text = "";
            txtLetras.ReadOnly = false;
            btnAceptar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (letras.ToUpper().Equals(txtLetras.Text.ToUpper()))
            {
                lblResultado.ForeColor = System.Drawing.Color.Green;
                lblResultado.Text = "Correcto";
                txtLetras.Text = "";
                txtLetras.Select();
                txtLetras.ReadOnly = true;
                btnAceptar.Enabled = false;
                
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "Incorrecto";
                MessageBox.Show(
                    "Usted ha perdido",
                    "Perdedor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );

                if (File.Exists(Data.RUTA))
                {
                    records = Data.leer();
                }
                guardarRecord();
                this.Close();
            }

            hiloJuego();
        }

        public void guardarRecord()
        {
            int cont = 0;
            Jugador menor = null;
            foreach (Jugador j in records)
            {
                if (j.Dificultad == dificultad)
                {
                    if (cont == 0)
                    {
                        menor = j;
                    }else if (Convert.ToInt32(menor.Lvl) > Convert.ToInt32(j.Lvl))
                    {
                        menor = j;
                    }
                    cont++;
                }
            }
            if (cont < 5)
            {
                IngresarNombre saveName = new IngresarNombre(dificultad, level, records);
                saveName.Show();
            }
            else
            {
                if (Convert.ToInt32(level) > Convert.ToInt32(menor.Lvl))
                {
                    records.Remove(menor);
                    IngresarNombre saveName = new IngresarNombre(dificultad, level, records);
                    saveName.Show();
                }
            }
        }

        private void txtLetras_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtLetras.ReadOnly == false && e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(this, new EventArgs());
            }
        }

        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            h1.Abort();
        }
    }
}
