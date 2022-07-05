namespace Ejercicios_para_examen
{
    public class Stringcontar
    {
        
        
        
        
        
        
        public int Retornar_string(string mstring)
        {
            int contador = 0;
            foreach (var VARIABLE in mstring)
            {
                contador += 1;
            }
            return contador;
        }
    }
}