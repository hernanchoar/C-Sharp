using Hernan_Parcial.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan_Parcial
{
    public class Robot:SondaEspacial
    {
        private EnumTipo tipo;
        private EnumBateria bateria;
        private EnumCamara camara;
        
        private string _nombre;
        private int _largo;
        private int _ancho; 
        private int _alto;
        private bool _alta;
        private int _peso;
        private int _costo;
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Largo { get => _largo; set => _largo = value; }
        public int Ancho { get => _ancho; set => _ancho = value; }
        public int Alto { get => _alto; set => _alto = value; }
        public bool Alta { get => _alta; set => _alta = value; }
        public int Peso { get => _peso; set => _peso = value; }
        public int Costo { get => _costo; set => _costo = value; }
        public EnumTipo Tipo
        {
            get { return tipo; }
            set
            {
                tipo = value;

            }
        }
        public EnumBateria Bateria
        {
            get { return bateria; }
            set
            {
                bateria = value;

            }
        }
        public EnumCamara Camara
        {
            get { return camara; }
            set
            {
                camara = value;

            }
        }
        
        //Metodos
        
        public override string ToString()
        {
            return Nombre.ToString() + " " + Largo.ToString() + " " + Ancho.ToString() + " " + Alto.ToString() +
                " " + Alta.ToString() + " " + Peso.ToString() + " " + Costo.ToString() + " " + Tipo.ToString() +
                " " + Bateria.ToString() + " " + Camara.ToString() + " " + AltitudMinima.ToString() + 
                " " + Desplazo.ToString() + " " + Velocidad.ToString() + " " + SensorCalor.ToString() + 
                " " + SensorSismo.ToString() + " " + SensorViento.ToString();
        }

        public int Costo_robot()
        {

            return _costo;
        }
        
        
        
        
        
        
        
        
        
    }
}
