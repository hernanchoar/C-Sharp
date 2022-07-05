using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejer1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Sueldos sueldos = new Sueldos();

           // sueldos.Ingresar_Sueldos();
           
           sueldos.Imprime_Sueldos(sueldos.sueldos);
           
        }


        public class Sueldos
        {

            public Sueldos()
             {
                /*
                 sueldos[0] = 100;
                 sueldos[1] = 200;
                 sueldos[2] = 300;
                 sueldos[3] = 400;
                 sueldos[4] = 500;
                 */

                int i;
                string linea;

                sueldos = new int[5];

                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese el sueldo del operario{0}",i+1);
                    linea = Console.ReadLine();
                    sueldos [i]= Int32.Parse(linea);

                }


             }
            
            public int[] sueldos;

            //Metodos 

            
            public void Ingresar_Sueldos()
            {
                int i;
                string linea;

                //  sueldos = new int[5];
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese sueldo de los operarios {0}", i + 1);
                    linea = Console.ReadLine();
                    sueldos[i] = int.Parse(linea);
                }


                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Los sueldos de los operarios son {0}", sueldos[i]);
                }
                
            }
            

            public void Imprime_Sueldos(int [] m_sueldos)
            {
                int i;

                for (i = 0; i < sueldos.Length; i++)
                {
                    Console.WriteLine("Los sueldos ingresados fueron {0}",m_sueldos[i]);
                }
            }
        }
    }
}