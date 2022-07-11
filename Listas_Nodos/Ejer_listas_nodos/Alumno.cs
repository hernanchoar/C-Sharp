using System.Collections.Generic;

namespace Ejer_listas_nodos
{
    public class Alumno
    {
        private string nombre;
        private int legajo;
        private int dni;
        private int cuota;
        
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Legajo
        {
            set { legajo = value; }
            get { return legajo; }
        }

        public int DNI
        {
            set { dni = value; }
            get { return dni; }
        }

       
    }
}