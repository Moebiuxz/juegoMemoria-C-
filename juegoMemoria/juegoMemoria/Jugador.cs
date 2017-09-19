using System;

namespace juegoMemoria
{
    [Serializable()]
    public class Jugador
    {
        private string nombre;
        private string lvl;
        private int dificultad;

        public Jugador(string nombre, string lvl, int dificultad)
        {
            this.nombre = nombre;
            this.lvl = lvl;
            this.dificultad = dificultad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Lvl
        {
            get { return lvl; }
            set { lvl = value; }
        }

        public int Dificultad
        {
            get { return dificultad; }
            set { dificultad = value; }
        }
    }
}