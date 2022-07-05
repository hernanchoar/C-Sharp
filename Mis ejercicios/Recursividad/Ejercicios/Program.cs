using System;
using static Ejercicios.Operaciones;

namespace Ejercicios
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            /*
            Recursividad recur = new Recursividad();

            int f = recur.Factorial(4);
            Console.WriteLine("El factorial de 4 es {0} ", f);
            
            */
            
            
            Console.WriteLine("Haremos una suma de 2 +3");
            Console.WriteLine("El resultado es {0} ",Operaciones.Sumar(2,3)+Operaciones.contador);
            
            Console.WriteLine("Haremos una Resta de 3  - 1");
            Console.WriteLine("El resultado es {0} ",Operaciones.Restar(3,1)+Operaciones.contador);
            
            Console.WriteLine("Haremos una Division de 10 / 2");
            Console.WriteLine("El resultado es {0} ",Operaciones.Dividir(10,2)+Operaciones.contador);
            
            Console.WriteLine("Haremos una Multiplicacion de 2 * 3");
            Console.WriteLine("El resultado es {0} ",Operaciones.Multiplicar(2,3)+Operaciones.contador);
            
            Console.WriteLine("La cantidad de operaciones que se hicieron fueron {0}",Operaciones.contador);
            
            
            
        }

        
        
        /*
        public class Recursividad
        {
            //Metodos 

            public int Factorial(int mx)
            {
                if (mx > 0)
                {
                   // Console.Write(mx + "");

                    int factorial;
                    factorial = 3;
                    int valor = mx * Factorial(mx - 1);


                    return valor;
                }
                else
                    return 1;
            }
        }
        
        */
        
        
        
    }
    
   
}