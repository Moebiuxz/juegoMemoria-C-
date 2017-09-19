using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace click
{
    public partial class Form1 : Form
    {
        private Thread h1;
        private int cont = 0;
        private int puntaje = 0;
        private bool activo = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            cont++;
            if (cont == 1)
            {
                hiloJuego();
            }

        }

        private void marcar()
        {
            lblPuntaje.Text = puntaje.ToString();
        }

        public void hiloJuego()
        {
            h1 = new Thread(new ThreadStart(HiloTiempo));
            h1.Start();
        }

        public void HiloTiempo()
        {
            for (int i = 19; i>=0; i--)
            {
                Thread.Sleep(1000);
                lblTiempo.Text = i.ToString();
            }
            activo = false;
            btnIniciar.Enabled = false;
            btnReiniciar.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            btnReiniciar.Enabled = false;
        }

        private void btnIniciar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' && cont == 0)
            {
                btnIniciar_Click(this, new EventArgs());
            }
            else if(activo)
            {
                puntaje++;
                marcar();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            cont = 0;
            btnIniciar.Enabled = true;
            btnIniciar_Click(this, new EventArgs());
        }
    }
}
