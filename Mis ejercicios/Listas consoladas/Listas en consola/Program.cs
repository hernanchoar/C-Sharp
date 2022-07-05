using System;

namespace Listas_en_consola
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         
            //Instanciar el delegado apuntando al metodo 

            
            Del_void ElDelegado = new Del_void(Delegados.Enviar_Otromensaje);
            Del_String ElOtroDelegado = new Del_String(Delegados.Enviar_Mensaje(parametro));
            
            //Utilizacion del delegado 
            ElDelegado();
            ElOtroDelegado("Desde un string");
        }

        //Definicion del objeto delegado 
        delegate void Del_void();

        delegate string Del_String(string msj);


        public class Delegados
        {
            // declaracion del metodo 

            public static void Enviar_Mensaje(string msj)
            {
                Console.WriteLine("Hola desde el delegado con el parametro string");
               
            }


            public static void Enviar_Otromensaje()
            {
                Console.WriteLine("Hola desde el delegado del tipo VOID");
            }
        }
    }
}