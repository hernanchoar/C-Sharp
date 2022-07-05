using System;

namespace Problema_2.Properties
{
    public class Persona
    {
        //Confeccionar una clase Persona que tenga como atributos el nombre y la edad (definir las propiedades para
        //poder acceder a dichos atributos). Definir como responsabilidad un método para imprimir.
        
        //Atributos de clase
        protected string nombre;
        protected int edad;
        
        //Modificadores de acceso

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int Edad
        {
            set { edad = value; }
            get { return edad; }
        }
        

        //Metodos

        public void Imprimir()
        {
            Console.WriteLine("El nombre de la persona es {0}",nombre);
            Console.WriteLine("La edad de la persona es {0}",edad);
            
        }

    }
}