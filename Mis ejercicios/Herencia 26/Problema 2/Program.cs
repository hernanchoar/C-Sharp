using System;
using Problema_2.Properties;

namespace Problema_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Persona persona1 = new Persona();

            persona1.Nombre = "Juan";
            persona1.Edad = 27;
            persona1.Imprimir();
                
            Console.WriteLine("----------------------------");
            Empleado empleado1 = new Empleado();

            empleado1.Nombre = "Ana";
            empleado1.Edad = 40;
            empleado1.Sueldo = 3400;
            empleado1.Imprimir();
           
        }
    }
}