using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan_Parcial.DAL
{

    /// <summary>
    /// Exploradores que permiten desplazarse para los que se registra la velocidad máxima, 
    /// el consumo de enegía del desplazamiento
    /// </summary>
    public class Explorador: Robot
    {
        
        public int VelocidadMax { get; set; }
        public decimal Consumo { get; set; }

    }
}
