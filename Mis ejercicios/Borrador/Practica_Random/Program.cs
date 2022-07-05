using System;

namespace Practica_Random
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Primera primera = new Primera();
            Segunda segunda = new Segunda();

            primera.Valor = 5;
            segunda.valor = 6;
            
            Console.WriteLine("primera {0} segunda {1} ",primera.Valor,segunda.valor);
            

        }
    }
}