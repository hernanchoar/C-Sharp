namespace Problema_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Alumno alumno = new Alumno();
            
            
            alumno.Imprimir_Alumno();
            alumno.Ver_mayoria_edad(alumno.Edad);

        }
    }
}