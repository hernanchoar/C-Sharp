using System;

namespace Ultimo_problema
{
    public class Club
    {
        /*
        Plantear una clase Club y otra clase Socio.
        
               
         La clase Club
        debe tener como atributos 3 objetos de la clase Socio. Definir una responsabilidad para imprimir el nombre 
        del socio con mayor antigüedad en el club.
        */


        private Socio socio1, socio2, socio3;

        public Club()
        {
            socio1 = new Socio();
            socio1.Nombre = "Hernan";
            socio1.Antiguedad = 0;
            socio2 = new Socio();
            socio2.Nombre = "Jose";
            socio2.Antiguedad = 1;
            socio3 = new Socio();
            socio3.Nombre = "Oscar";
            socio3.Antiguedad = 2;

        }


        public void Imprimir_Antiguedad()
        {
            if (socio1.Antiguedad > socio2.Antiguedad && socio1.Antiguedad > socio3.Antiguedad)
            {
                Console.WriteLine("El socio con mayor antiguedad es {0} con una antiguedad de {1}", socio1.Nombre,
                    socio1.Antiguedad);
            }
            else if (socio2.Antiguedad > socio1.Antiguedad && socio2.Antiguedad > socio3.Antiguedad)
            {
                Console.WriteLine("El socio con mayor antiguedad es {0} con una antiguedad de {1}", socio2.Nombre,
                    socio2.Antiguedad);
            }
            else
            {
                Console.WriteLine("El socio con mayor antiguedad es {0} con una antiguedad de {1}", socio3.Nombre,
                    socio3.Antiguedad);
            }
        }

        public void Definir_Antiguedad_y_Nombre()
        {
            string linea;
            int entrada;
            Console.WriteLine("Ingrese el nombre del Socio 1");
            linea = Convert.ToString(Console.ReadLine());
            socio1.Nombre = linea;
            Console.WriteLine("Ingrese el nombre del Socio 2");
            linea = Convert.ToString(Console.ReadLine());
            socio2.Nombre = linea;
            Console.WriteLine("Ingrese el nombre del Socio 3");
            linea = Convert.ToString(Console.ReadLine());
            socio3.Nombre = linea;

            Console.WriteLine("Ingrese la antiguedad del Socio 1");
            entrada = Convert.ToInt16(Console.ReadLine());
            socio1.Antiguedad = entrada;
            Console.WriteLine("Ingrese la antiguedad del Socio 2");
            entrada = Convert.ToInt16(Console.ReadLine());
            socio2.Antiguedad = entrada;
            Console.WriteLine("Ingrese la antiguedad del Socio 3");
            entrada = Convert.ToInt16(Console.ReadLine());
            socio3.Antiguedad = entrada;
        }
    }
}