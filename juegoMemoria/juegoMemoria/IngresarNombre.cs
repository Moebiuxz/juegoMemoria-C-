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
    public partial class IngresarNombre : Form
    {
        private string level;
        private int dificultad;
        private List<Jugador> records; 

        public IngresarNombre(int dificultad, string level, List<Jugador> records)
        {
            InitializeComponent();
            this.dificultad = dificultad;
            this.level = level;
            this.records = records;
        }

        private void IngresarNombre_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            records.Add(new Jugador(txtNombre.Text, level, dificultad));
            Data.escribir(records);
            this.Close();
        }
    }
}
