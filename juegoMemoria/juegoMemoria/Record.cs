using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegoMemoria
{
    public partial class Record : Form
    {
        private List<Jugador> records; 
        private List<Label> ranks; 
        private List<Label> ranksNormal; 
        private List<Label> ranksDificil; 
        private List<Label> nombreTurista; 
        private List<Label> nombreNormal; 
        private List<Label> nombreDificil; 
        
        public Record()
        {
            InitializeComponent();
            records = new List<Jugador>();
            ranks = new List<Label>() {rank1Turista, rank2Turista, rank3Turista, rank4Turista, rank5Turista};
            ranksNormal = new List<Label>() {rank1Normal, rank2Normal, rank3Normal, rank4Normal, rank5Normal};
            ranksDificil = new List<Label>() {rank1Dificil, rank2Dificil, rank3Dificil, rank4Dificil, rank5Dificil};
            nombreTurista = new List<Label>() {nombre1Turista, nombre2Turista, nombre3Turista, nombre4Turista, nombre5Turista};
            nombreNormal = new List<Label>() {nombre1Normal, nombre2Normal, nombre3Normal, nombre4Normal, nombre5Normal};
            nombreDificil = new List<Label>() {nombre1Dificil, nombre2Dificil, nombre3Dificil, nombre4Dificil, nombre5Dificil};
        }

        private void Record_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            if (File.Exists(Data.RUTA))
            {
                records = Data.leer();
            }

            records = records.OrderByDescending(j => j.Lvl).ToList();

            int contTurista = 0;
            int rankTurista = 1;
            int valorTurista = 0;
            int contNormal = 0;
            int rankNormal = 1;
            int valorNormal = 0;
            int contDificil = 0;
            int rankDificil = 1;
            int valorDificil = 0;
            foreach (Jugador j in records)
            {
                if (j.Dificultad == 6)
                {
                    if (contTurista == 0)
                    {
                        valorTurista = Convert.ToInt32(j.Lvl);
                        ranks[contTurista].Text = rankTurista.ToString()+".";
                        nombreTurista[contTurista].Text = j.Nombre+" [lvl. "+(j.Lvl)+"]";
                    }else if (valorTurista != Convert.ToInt32(j.Lvl))
                    {
                        rankTurista++;
                        ranks[contTurista].Text = rankTurista.ToString() + ".";
                        nombreTurista[contTurista].Text = j.Nombre + " [lvl. " + j.Lvl + "]";
                    }
                    else
                    {
                        ranks[contTurista].Text = rankTurista.ToString() + ".";
                        nombreTurista[contTurista].Text = j.Nombre + " [lvl. " + j.Lvl + "]";
                    }

                    contTurista++;
                }

                if (j.Dificultad == 4)
                {
                    if (contNormal == 0)
                    {
                        valorNormal = Convert.ToInt32(j.Lvl);
                        ranksNormal[contNormal].Text = rankNormal.ToString() + ".";
                        nombreNormal[contNormal].Text = j.Nombre + " [lvl. " + j.Lvl + "]";
                    }
                    else if (valorNormal != Convert.ToInt32(j.Lvl))
                    {
                        rankNormal++;
                        ranksNormal[contNormal].Text = rankNormal.ToString() + ".";
                        nombreNormal[contNormal].Text = j.Nombre + " [lvl. " + j.Lvl + "]";
                    }
                    else
                    {
                        ranksNormal[contNormal].Text = rankNormal.ToString() + ".";
                        nombreNormal[contNormal].Text = j.Nombre + " [lvl. " + j.Lvl + "]";
                    }

                    contNormal++;
                }

                if (j.Dificultad == 2)
                {
                    if (contDificil == 0)
                    {
                        valorDificil = Convert.ToInt32(j.Lvl);
                        ranksDificil[contDificil].Text = rankDificil.ToString() + ".";
                        nombreDificil[contDificil].Text = j.Nombre + " [lvl. " + j.Lvl + "]";
                    }
                    else if (valorDificil != Convert.ToInt32(j.Lvl))
                    {
                        rankDificil++;
                        ranksDificil[contDificil].Text = rankDificil.ToString() + ".";
                        nombreDificil[contDificil].Text = j.Nombre + " [lvl. " + j.Lvl + "]";
                    }
                    else
                    {
                        ranksDificil[contDificil].Text = rankDificil.ToString() + ".";
                        nombreDificil[contDificil].Text = j.Nombre + " [lvl. " + j.Lvl + "]";
                    }

                    contDificil++;
                }
            }
        }
    }
}
