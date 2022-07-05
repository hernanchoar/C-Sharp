using System;
using System.Net;

namespace Guerra_Cartas
{
    public class Juego_De_Cartas
    {
        //Dos objetos de cartas 
        private Cartas cartas1, cartas2;

        //Constructor de clase
        public Juego_De_Cartas()
        {
            cartas1 = new Cartas();
            cartas2 = new Cartas();
        }


        //Metodos

        public void Jugar()
        {
            int puntos_jugador = 0;
            int puntos_IA = 0;
            int contador = 0;
            int entrada;
            bool verifica = false;
            int i = 0;
            int ganador = 0;

            do
            {
                Console.WriteLine("Partida {0}", i++);
                Console.WriteLine("-----------------------------------");

                cartas1.Tirar_Cartas_Player();
                cartas1.Imprimir_Player();
                cartas1.Retornar_ValorPlayer();

                cartas2.Tirar_Cartas_IA();
                cartas2.Imprimir_IA();
                cartas2.Retornar_ValorIA();


                if (cartas1.Retornar_ValorPlayer() > cartas2.Retornar_ValorIA())
                {
                    puntos_jugador++;
                    Console.WriteLine("Punto para jugador");
                }
                else if (cartas2.Retornar_ValorIA() > cartas1.Retornar_ValorPlayer())
                {
                    puntos_IA++;
                    Console.WriteLine("Punto para PC");
                }

                if (cartas1.Retornar_ValorPlayer() == cartas2.Retornar_ValorIA())
                {
                    Console.WriteLine("!-----Guerra----¡");
                }


                Console.WriteLine("Pulse 1 para tirar de nuevo");
                entrada = Int32.Parse(Console.ReadLine());

                if (entrada != 0)
                {
                    verifica = true;
                }
            } while (i < 40);

            if (puntos_jugador > puntos_IA)
            {
                Console.WriteLine("Jugador es el ganador");
            }
            else if (puntos_IA > puntos_jugador)
            {
                Console.WriteLine("El ganador es la PC");
            }

            Console.WriteLine("Desea volver a jugar pulse 5");
            entrada = Int32.Parse(Console.ReadLine());

            if (entrada == 5)
            {
                i = 0;
            }
        }
    }
}