using System;

namespace Practica_1
{
    public class Concesionario
    {
        
        
        
        
        //Metodos AÑADIR COCHE , MOSTRAR COCHE , VACIAR COCHES , ELIMINAR COCHES
        
        //AGREGAR COCHE
        
        /*
        private int id;
        private string marca;
        private string modelo;
        private int km;
        private int precio;
        */
        
        
        public void Aniadir_Coche(string autosNuevos)
        {

            string nuevoAuto;
            Coche coche = new Coche();
            
            Console.WriteLine("Indique el id , marca , modelo , km , precio del auto que desea agregar");
            nuevoAuto = Console.ReadLine();
        
        }

        public void mostrarCoches(string autosIngresados)
        {
            string autosEntotal="";
            Console.WriteLine("El auto ingresado es",autosEntotal);
        }
        
        
        
    }
}