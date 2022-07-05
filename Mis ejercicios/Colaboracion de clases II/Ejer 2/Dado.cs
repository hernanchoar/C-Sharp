using System;

namespace Ejer_2
{
    public class Dado
    {
        //Atributos 

        private int valor;
        private static Random aleatorio;

        //Modificador de acceso
        public int Valor
        {
            set { valor = value; }
            get { return valor; }
        }


        //Consutructor
        public Dado()
        {
            aleatorio = new Random();
        }


        //Metodos

        public void Tirar()
        {
            valor = aleatorio.Next(1, 7);
        }

        public void Imprimir()
        {
            Console.WriteLine("El valor del dado es: {0} ", valor);
        }

        public int Retornar_Valor()
        {
            return valor;
        }
    }
}