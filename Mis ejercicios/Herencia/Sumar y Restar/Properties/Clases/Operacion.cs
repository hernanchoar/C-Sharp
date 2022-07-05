namespace Sumar_y_Restar
{
    public class Operacion
    {
        
        //Se declara protected para que las subclases o clases hijo puedan acceder a sus metodos
        //si fuera private solo podria acceder a sus metodos 
        protected int valor1;
        protected int valor2;
        protected int resultado;


        public int Valor1
        {
            set { valor1 = value; }
            get { return valor1; }
        }

        public int Valor2
        {
            set { valor2 = value; }
            get { return valor2; }
        }

        public int Resultado
        {
            set { resultado = value; }
            get { return resultado; }
        }
        
        
        
    }
}