using System;

namespace Establecimiento_educativo.TADS
{
    
    public class Alumno
    {
        private int dni;

        public int Dni
        {
            get{return dni;}
            set{dni=value;}
        }
        
        private string nombre;

        public string Nombre
        {
            get{ return nombre;}
            set{nombre=value;}
           
        }
        
        public virtual float Coe()
        {
            return 1;
        }
        
        public override String ToString()
        {
            return "Nombre: " + nombre + "Dni " + dni ;
        }
        
    }
    
    
}