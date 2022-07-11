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
        
        public int Paga500
        {
            get { return paga500; }
        }
        
        public int Paga600
        {
          get { return paga600; }
        }
        
        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public void Eliminar_Alumno(Alumno alumno)
        {
            alumnos.Remove(alumno);
        }

        public int Aumentar_Recaudacion(){
            recaudacion =recaudacion + paga500;
            return recaudacion;
        }
        
        public int Aumentar_Recaudacion2(){
            recaudacion = recaudacion + paga600;
            return recaudacion;
        }
        
        public int Obtener_Ingreso_x_Cuota(int precau)
        {
            total = total + recaudacion;
            
            return total;
        }
            
        
        
        
      
    }
}