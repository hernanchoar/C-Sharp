using System;

namespace Personajes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Instancio nuevos objetos de la clase SuperHeroes
            SuperHeroes Batman = new SuperHeroes();

            Console.WriteLine(Batman.GetInfoBatman());
            Console.WriteLine("Batman tiene un total de enemigos:" + Batman.GetEnemigosBatman());
            Batman.GetExtrasBatman();
            Console.WriteLine("------------------------------------------------------------");
            Villanos DoctorOctopus = new Villanos();
            Console.WriteLine("El doctor Octopus tiene una vida de:" + DoctorOctopus.GetVidaDoctorOctopus());

            Console.WriteLine(DoctorOctopus.GetPoderesEspeciales());
            DoctorOctopus.GetHabilidadVolar();
            Console.WriteLine("------------------------------------------------------------");
            Aliens aliens = new Aliens();
            Console.WriteLine("Superman tiene una vida de:" + aliens.GetVida(aliens.Vida));
            Console.WriteLine("Superman tiene una hablidad de carrera de:" +
                              aliens.GetHabilidadesCorrer(aliens.Correr));
            aliens.GetHabilidadDeVolar();
        }

        public class SuperHeroes
        {
            //Campos o parametros 

            public int Correr;
            public int Vida;
            public bool Volar;

            //Constructor 

            public SuperHeroes()
            {
                Correr = 100;
                Vida = 100;
            }

            //Metodos de accesos
            public string GetInfoBatman()
            {
                return "Batman super heroe nocturno \n" + "tiene habilidad de correr de:" + Correr +
                       "Tiene una vida de:" +
                       Vida;
            }

            public int GetEnemigosBatman()
            {
                return 10;
            }

            public void GetExtrasBatman()
            {
                SuperHeroes Batman = new SuperHeroes();
                Volar = true;

                if (Batman.Volar == true)
                {
                    Console.WriteLine("Batman tiene habilidad de volar ");
                }
            }
        }

        // Segunda clase ---> misma clase = constructor 
        public class Villanos
        {
            public int Vida;
            public int Correr;
            public bool Volar;
            public string Poderes;

            public Villanos()
            {
                Correr = 90;
                Vida = 100;
            }

            //Metodo de acceso 
            public int GetVidaDoctorOctopus()
            {
                return Vida = 100;
            }

            public string GetPoderesEspeciales()
            {
                Poderes = "El doctor octopus tiene tentaculos";
                return Poderes;
            }

            public void GetHabilidadVolar()
            {
                Volar = false;
                if (Volar == true)
                {
                    Console.WriteLine("El doctor Octopus puede volar:" + Volar);
                }
                else
                    Console.WriteLine("El doctor Octopus  puede volar:" + Volar);
            }
        }

            // Declaracion de clase 
        public class Aliens
        {
            public int Vida;
            public int Correr;
            public bool Volar;
            
            //COnstructor 
            
            public Aliens()
            {
                Vida = 1000;
                Correr = 150;
            }
            
            
            //Getter y setter 
            public int GetHabilidadesCorrer(int paraCorrer)
            {
                paraCorrer = Correr;
                return paraCorrer;
            }

            public int GetVida(int paraVida)
            {
                paraVida = Vida;
                return paraVida;
            }

            public void GetHabilidadDeVolar()
            {
                Volar = true;
                Console.WriteLine("Superman tiene la habilidad de Volar:"+Volar);

            }
            
        }
    }
}