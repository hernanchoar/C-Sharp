using System;

namespace Ejer_1
{
    public class Cliente
    {
        //atributos de clase
        private string nombre;
        private float monto;

        //Modificadores de acceso 


        public float Monto
        {
            set { monto = value; }
            get { return monto; }
        }
 
        //Constructor
        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }
        

        //Metodos

        public void Depositar(float m_monto)
        {
            monto = monto + m_monto;
        }

        public void Extraer(float m_monto)
        {
            monto = monto - m_monto;
        }

        public float Retornar_Monto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine("el cliente {0} Tiene depositado la suma de {1}", nombre, monto);
        }
    }
}