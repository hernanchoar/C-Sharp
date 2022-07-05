using System;

namespace Problema_2
{
    public class Alumno
    {
        //Plantear una clase llamada Alumno y definir como atributos su nombre y su edad.
        //En el constructor realizar la carga de datos. Definir otros dos métodos para
        //imprimir los datos ingresados y un mensaje si es mayor o no de edad (edad >=18)
        
        
        //Atributos de la clase
        private string nombre;
        private int edad;
        
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

        //Constructor 

       public Alumno()
        {
            string linea;
            Console.WriteLine("Ingrese el nombre del alumno");
            linea = Console.ReadLine();
            nombre = Convert.ToString(linea);
            Console.WriteLine("Ingrese la edad del alumno");
            linea = Console.ReadLine();
            edad = Convert.ToInt16(linea);
            
        }
        
        
        
        //Metodos

        public void Imprimir_Alumno()
        {
            Console.WriteLine("Se ingreso el alumno: {0} \n",nombre);
            Console.WriteLine("Con la edad de : {0} ",edad);
            
        }

        public void Ver_mayoria_edad(int m_edad)
        {
            if (m_edad > 18)
            {
                Console.WriteLine("El alumno es mayor de edad {0} \n",m_edad);
            }
            else
            {
                Console.WriteLine("El Alumno es menor de edad{0}",m_edad);
            }
            
        }
        
    }
}