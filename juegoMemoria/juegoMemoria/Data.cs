using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace juegoMemoria
{
    public class Data
    {
        public const string RUTA = "records.dat";
        private static Stream flujo;
        private static BinaryFormatter bin;

        public static void escribir(List<Jugador> lista)
        {
            flujo = File.Open(RUTA, FileMode.Create);
            bin = new BinaryFormatter();
            bin.Serialize(flujo, lista);
            flujo.Close();
        }

        public static List<Jugador> leer()
        {
            List<Jugador> l = new List<Jugador>();
            flujo = File.Open(RUTA, FileMode.Open);
            bin = new BinaryFormatter();
            l = (List<Jugador>)bin.Deserialize(flujo);
            flujo.Close();
            return l;
        }
    }
}