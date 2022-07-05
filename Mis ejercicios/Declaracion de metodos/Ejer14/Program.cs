using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejer14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //Confeccionar una clase que permita ingresar valores enteros por
            //teclado y nos muestre la tabla de multiplicar de dicho valor.
            //Finalizar el programa al ingresar el -1.

            Enteros enteros = new Enteros();

            int entrada;

            do
            {
                enteros.Obtener_tabla();
                Console.WriteLine("Presione -1 para salir");
                entrada = int.Parse(Console.ReadLine()); 
              
            } while (entrada != -1);
            
        }

        public class Enteros
        {
            public void Obtener_tabla()
            {
                int m_num;
                Console.WriteLine("Introduce un número:");
                m_num=int.Parse(Console.ReadLine());
                
                int i = 0;
               
                for( i=0; i<=10;i++)
                    {
                        Console.WriteLine(m_num+"x"+i+"="+(i*m_num));
                    }
                  }

        }
    }
}