using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan_Parcial.DAL
{
    public class SondaRobot
    {
        private int _sensorViento; private int _sensorSismo; private int _sensorCalor;
        //public SondaRobot(int sensorViento, int sensorSismo, int sensorCalor)
        //{
        //    SensorViento = sensorViento;
        //    SensorSismo = sensorSismo;
        //    SensorCalor = sensorCalor;
        //}

        public int SensorViento { get => _sensorViento; set => _sensorViento = value; }
        public int SensorSismo { get => _sensorSismo; set => _sensorSismo = value; }
        public int SensorCalor { get => _sensorCalor; set => _sensorCalor = value; }
    }
}
