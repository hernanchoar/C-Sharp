using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejer_2
{
    public class Numeros
    {
        //Confeccionar una clase que permita ingresar tres valores
        //por teclado. Luego mostrar el mayor y el menor.

       
      

        //Metodos


        public void Inicializar()
        {
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
        }
        public void Obtener_Mayor(int mnum1,int mnum2,int mnum3)
        {
            

            if (mnum1 > mnum2 && mnum1 > mnum3)
            {
                Console.WriteLine("El numero 1 es el mayor ");
            }
            else if (mnum2 > mnum1 && mnum2 > mnum3)
            {
                Console.WriteLine("El numero 2 es el mayor ");
            }
            else
            {
                Console.WriteLine("El numero mayor es el 3");
            }
            
        }

        public void Obtener_Menor(int mnum1,int mnum2,int mnum3)
        {
            if (mnum1 < mnum2 && mnum1 < mnum3)
            {
                Console.WriteLine("El numero 1 es el menor ");
            }
            else if (mnum2 < mnum1 && mnum2 < mnum3)
            {
                Console.WriteLine("El numero 2 es el menor ");
            }
            else
            {
                Console.WriteLine("El numero menor es el 3");
            }
            
        }
        
    }
}