using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan_Parcial
{
    class Camara
    {
        private int _alcance;
        private int _zoom;
        private int _megapx;
        private int _consumo = 10;

        //public Camara(int alcance, int zoom, int megapx, int consumo)
        //{
        //    Alcance = alcance;
        //    Zoom = zoom;
        //    Megapx = megapx;
        //    Consumo = consumo;
        //}

        public int Alcance { get => _alcance; set => _alcance = value; }
        public int Zoom { get => _zoom; set => _zoom = value; }
        public int Megapx { get => _megapx; set => _megapx = value; }
        public int Consumo { get => _consumo; set => _consumo = value; }
    }
}
