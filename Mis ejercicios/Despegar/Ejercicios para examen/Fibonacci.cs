using System;
using System.Linq;

namespace Ejercicios_para_examen
{
    public class Fibonacci
    {
        public int valor1;
        public int valor2;
        public int temp;


        //metodos

        public void  Imprimir_Fibonacci()
        {
            
            int valor1 = 0;
            int valor2 = 1;
            int temp = 0;
            string fibonacci = "";
            
            Console.WriteLine(valor1);
            for (int i = 0; i < 30; i++)
            {
                temp = valor1;
                valor1 = valor2;
                valor2 = temp + valor1;
                fibonacci = Convert.ToString(valor1);
                Console.WriteLine("{0}",valor1);
               
            }
            
            char numero = '1';
            bool b = fibonacci.Contains(numero);
            
            Console.WriteLine("El numero [1] se encuenta en la cadena {0}",b);

            if (b)
            {
                int index = fibonacci.IndexOf(numero);
                if (index >= 0)
                {
                    Console.WriteLine("El numero indicado {0} se encuentra en la posicion {1}",numero,index+1);
                }
            }

            
        }
        
        
    }
}