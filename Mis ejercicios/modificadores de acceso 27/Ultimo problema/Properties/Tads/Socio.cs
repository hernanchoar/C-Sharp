using System;
using System.Reflection;

namespace Ultimo_problema
{
    public class Socio
    {
        /*
      Plantear una clase Club y otra clase Socio.
      
      La clase Socio
       debe tener los siguientes atributos 
      privados: nombre y la antigüedad en el club (en años) Definir dos propiedades para poder acceder al
      nombre y la antigüedad del socio(no permitir cargar un valor negativo en la antigüedad).
      
      
      */

        //Atributos
        private string nombre;
        private int antiguedad;

        //Modificadores de acceso
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        //Modificadores de aceso
        public int Antiguedad
        {
            set
            {
                if (value >= 0)
                {
                    antiguedad = value;
                }
                else
                {
                    Console.WriteLine("La antiguedad no puede ser un numero negativo");
                }
            }

            get { return antiguedad; }
        }
    }
}