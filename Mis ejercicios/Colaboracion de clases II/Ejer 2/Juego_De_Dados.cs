using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Ejer_2
{
    public class Juego_De_Dados
    {
        //constructor

        private Dado dado, dado1, dado2, dado3;

        public Juego_De_Dados()
        {
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();
        }


        //metodos

        public void Jugar()
        {
            dado1.Tirar();
            dado1.Imprimir();
            dado2.Tirar();
            dado2.Imprimir();
            dado3.Tirar();
            dado3.Imprimir();

            if (dado1.Retornar_Valor() == dado2.Retornar_Valor() && dado1.Retornar_Valor() == dado3.Retornar_Valor())
            {
                Console.WriteLine(" Usted Gano");
            }
            else
            {
                Console.WriteLine(" Usted perdio");
            }
        }
    }
}