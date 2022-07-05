using System;

namespace Sumar_y_Restar
{
    internal class Prueba
    {
        public static void Main(string[] args)
        {
            Suma suma = new Suma();
            Console.WriteLine("\n");
            Console.WriteLine(" Haremos una suma");
            suma.Valor1 = 7;
            suma.Valor2 = 3;
            suma.Sumar();
            Console.WriteLine("El resultado es {0}", suma.Resultado);
            Console.WriteLine("---------------------");
            Console.WriteLine("Haremos una resta");
            Resta resta = new Resta();
            resta.Valor1 = 5;
            resta.Valor2 = 2;
            resta.Restar();
            Console.WriteLine("El resultado de la resta es {0}", resta.Resultado);
        }
    }
}