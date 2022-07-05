namespace Ejercicios
{
    public class Operaciones
    {



        public static int contador;


        public static int Sumar(int x, int y)
        {
            contador++;
            int resultado = x + y;
            
            return resultado;
           

        }


        public static int Restar(int x, int y)
        {
            contador++;
            int resultado = x - y;
            return resultado;
           
        }
        
        public static int Multiplicar(int x, int y)
        {
            contador++;
            int resultado = x * y;
            return resultado;
            
        }
        
        
        public static int Dividir(int x, int y)
        {
            contador++;
            int resultado = x / y;
            return resultado;
            
        }
    }
}