using System;

namespace Problema_2.Properties
{
    public class Empleado : Persona
    {
        //Plantear una segunda clase Empleado que herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) 
        //y el método para imprimir su sueldo.
        
        //Atributos de clase
        private float sueldo;

        //Modificador de acceso
        public float Sueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }
        
        
        
        //Metodos 

        
        //NEW PUBLIC sobrescribo la funcion que tenia el padre
        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo"+sueldo);
        }
        
        
        /*
        public void Imprimir_Sueldo()
        {
            Console.WriteLine("El sueldo de del empelado es {0}",sueldo);
        }
        */

    }
}