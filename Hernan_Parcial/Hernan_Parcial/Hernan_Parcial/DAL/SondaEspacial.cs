using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan_Parcial.DAL
{
    public class SondaEspacial:Explorador
    {
        private int _altitudMinima;
        //public SondaEspacial(int altitudMinima)
        //{
        //    AltitudMinima = altitudMinima;
        //}

        public int AltitudMinima { get => _altitudMinima; set => _altitudMinima = value; }
        public override string ToString()
        {
            return AltitudMinima.ToString();
        }
    }
}
