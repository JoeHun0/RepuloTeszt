using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class JaratKezelo
    {
        public List<Jarat> lista = new List<Jarat>();
        public void UjJarat(String JaratSzam, String HonnanRepter, String Hovarepter, DateTime Indulas)
        {
            Jarat j = new Jarat(JaratSzam, HonnanRepter, Hovarepter, Indulas);
            lista.Add(j);
        }
        public void Keses(string jaratSzam, int keses)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].JaratSzam.Equals(jaratSzam))
                {
                    lista[i].Keses = keses;
                }
            }
        }
        public DateTime MikorIndul(string jaratSzam)
        {
            return DateTime.Now;
        }
        public List<string> JaratokRepuloterrol(string repter)
        {
            List<string> vissza = new List<string>();
            return vissza;
        }
    }





    public class Jarat
    {
        public Jarat(string jaratSzam, string honnanRepter, string hovarepter, DateTime indulas)
        {
            JaratSzam = jaratSzam;
            HonnanRepter = honnanRepter;
            Hovarepter = hovarepter;
            Indulas = indulas;
        }

        public String JaratSzam { get; set; }
        public String HonnanRepter { get; set; }
        public String Hovarepter { get; set; }
        public DateTime Indulas { get; set; }
        public int Keses { get; set; }
    }
    class NegatvKesesExcepton : Exception
    {


        public NegatvKesesExcepton(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }

    }
}
