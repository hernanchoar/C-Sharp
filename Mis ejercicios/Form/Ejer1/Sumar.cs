namespace Ejer1
{
    public class Sumar
    {
        
        //Atributos de clase
        private int valor1;
        private int valor2;
        private int resultado;

        
        
        //Modificadores de acceso
        public int Valor1
        {
            set{valor1 = value;}
            get{return valor1;}
            
        }

        public int Valor2
        {
            set{valor2 = value;}
            get { return valor2; }
        }
        
        public int Resultado
        {
            set{resultado = value;}
            get{return resultado;}
        }
        
        //Metodos

        public int Hacer_Sumar(int mvalor1 , int mvalor2)
        {
            resultado = valor1 + valor2;
            return resultado;
        }
        
        



    }
}