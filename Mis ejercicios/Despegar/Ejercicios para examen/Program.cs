using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicios_para_examen
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            var mistring = "Hola mundo";
            int numero;
            Stringcontar cuenta = new Stringcontar();
            Console.WriteLine(cuenta.Retornar_string(mistring));
            */
            
            
           // Fibonacci fibonacci = new Fibonacci();
            
          //  fibonacci.Imprimir_Fibonacci();

          /*
          NumPrimo numPrimo = new NumPrimo();

          int numero = 5;

          if (numPrimo.Retornar_Primo(numero))
          {
              //Es primo
              Console.WriteLine("El numero es primo");
          }
          else
          {
              //No es primo
              Console.WriteLine("No es primo");
          }
       
        */

          ConvertirBinario numeros = new ConvertirBinario();
          
          numeros.Convertir();




        }
    
    }
}