using System.Collections.Generic;
using System.Xml.Schema;

namespace Ejer_listas_nodos
{
    public class Instituto
    {
        private List<Alumno> alumnos = new List<Alumno>();
        private int recaudacion;
        private int paga500 = 500;
        private int paga600 = 600;
        private int cuota { get; set; }

        public int total;
        public List<Alumno> Alumnos
        {
            set { alumnos = value; }
            get{return alumnos; }
        }

        public int Recaudacion
        {
            get { return recaudacion; }
        }
        
        public int Cuota
        {
            get { return cuota; }
        }
      
        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public void Eliminar_Alumno(Alumno alumno)
        {
            alumnos.Remove(alumno);
        }

        public int AumentarRecaudacion(int valor){
            recaudacion += valor;
            return recaudacion;
        }
      
    }
}