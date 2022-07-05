using System;

namespace Guerra_Cartas
{
    public class Cartas
    {
        private int valorIA;
        private int valorPlayer;
        private static Random aleatorioIA;
        private static Random aleatorioPlayer;
        public static Random next;
        public static Random next1;

        public static Random Next
        {
            get => next;
            set => next = value;
        }
        
        

        //constructor
        public Cartas()
        {
            aleatorioIA = new Random();
            aleatorioPlayer = new Random();
            next = new Random();
            next1 = new Random();
        }


        //metodos

        public void Tirar_Cartas_IA()
        {
            valorIA = aleatorioIA.Next(1,25) + next.Next(1,5);
            
        }

        public void Tirar_Cartas_Player()
        {
            valorPlayer = aleatorioPlayer.Next(1,30)+ next1.Next(1,5);
        }

        public void Imprimir_Player()
        {
            Console.WriteLine("Jugador tiro el -> [{0}]", valorPlayer);
        }

        public void Imprimir_IA()
        {
            Console.WriteLine("PC tiro el -> [{0}]", valorIA);
        }

        public int Retornar_ValorIA()
        {
            return valorIA;
        }

        public int Retornar_ValorPlayer()
        {
            return valorPlayer;
        }
    }
}