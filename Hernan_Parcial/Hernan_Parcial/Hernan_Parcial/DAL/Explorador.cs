using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan_Parcial.DAL
{
    public class Explorador:SondaRobot
    {
        private int _desplazo;
        private int _velocidad;
        //public Explorador(int desplazo, int velocidad)
        //{
        //    Desplazo = desplazo;
        //    Velocidad = velocidad;
        //}

        public int Desplazo { get => _desplazo; set => _desplazo = value; }
        public int Velocidad { get => _velocidad; set => _velocidad = value; }
    }
}
