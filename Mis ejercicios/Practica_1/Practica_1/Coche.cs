using System;

namespace Practica_1
{
    public class Coche
    {

        private int id;
        private string marca;
        private string modelo;
        private int km;
        private int precio;

        
        
        //Modificadores de ACCESO
        public int ID
        {
            set{id = value;}
            get{return id;}
        }

        public string MARCA
        {
            set { marca = value; }
            get { return marca; }
            }

        public string MODELO
        {
            set { modelo = value; }
            get { return modelo; }
        }

        public int KM
        {
            set { km = value; }
            get { return km; }
        }

        public int PRECIO
        {
            set { precio = value; }
            get { return precio; }
        }

        
        
        //Constructores 
        public Coche()
        {
            

        }
        
        
        
        

        //Metodos 


        public override string ToString()
        {
            return "Marca" + marca + "Modelo" + modelo + "Con un precio de $" + precio;
        }
    }
}