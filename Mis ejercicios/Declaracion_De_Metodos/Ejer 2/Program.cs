using System;

namespace Ejer_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Confeccionar una clase que permita ingresar tres valores
            //por teclado. Luego mostrar el mayor y el menor.


            Numeros numeros = new Numeros();

            int num1;
            int num2;
            int num3;
            string linea;
            
            Console.WriteLine("Ingrese el primer numero");
            linea = Console.ReadLine();
            num1 = Convert.ToInt16(linea);
            Console.WriteLine("Ingrese el segundo numero");
            linea = Console.ReadLine();
            num2 = Convert.ToInt16(linea);
            Console.WriteLine("Ingrese el tercer numero");
            linea = Console.ReadLine();
            num3 = Convert.ToUInt16(linea);
            
            numeros.Obtener_Mayor(num1,num2,num3);
            numeros.Obtener_Menor(num1,num2,num3);
            
            
            
        }
    }
}