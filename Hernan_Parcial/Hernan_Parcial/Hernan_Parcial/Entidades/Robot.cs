using Hernan_Parcial.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan_Parcial
{
    public class Robot
    {
    //  Nombre
    //  Dimensiones
    //  Cámaras
    // Batería

        public string Nombre { get; set; }
        public string Dimensiones { get; set; }
        public decimal Consumo { get; set; }
        public List<Camara> Camaras { get; set; }
        public Bateria Bateria { get; set; }

        //Metodos

        //public override string ToString()
        //{
        //    return Nombre.ToString() + " " + Largo.ToString() + " " + Ancho.ToString() + " " + Alto.ToString() +
        //        " " + Alta.ToString() + " " + Peso.ToString() + " " + Costo.ToString() + " " + Tipo.ToString() +
        //        " " + Bateria.ToString() + " " + Camara.ToString() + " " + AltitudMinima.ToString() + 
        //        " " + Desplazo.ToString() + " " + Velocidad.ToString() + " " + SensorCalor.ToString() + 
        //        " " + SensorSismo.ToString() + " " + SensorViento.ToString();
        //}

    }
}
