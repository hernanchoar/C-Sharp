using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Establecimiento_educativo.TADS
{
    public class Instituto
    {
        
        
       //Lista Alumnos declaracion 
        private List<Alumno> _alumnos = new List<Alumno>();
        
        public List<Alumno> Alumnos
        {
            get { return _alumnos; }
            set { _alumnos = value; }
        }
        
        // Lista cursos declaracion 
        private List<Curso> _cursos = new List<Curso>();
       
        public List<Curso> Cursos
        {
            get { return _cursos; }
            set{}
            
        }
        
        public Instituto()
        {
            if (Alumnos == null)
            {
                Alumnos = new List<Alumno>();
            }  
            if (Cursos == null)
            {
                Cursos = new List<Curso>();
            }
            
        }
        
        
        //--------------------------------Metodos----------------------------------------------//
        
        
        
        public void Ingresar_Alumno(Alumno alumno)
        {
            _alumnos.Add(alumno);   
        }
        
        public void Ingresar_Curso(Curso curso)
        {
            _cursos.Add(curso);   
        }
        
        //Dar de alta un alumno en un curso 

        

        public void Dar_De_Alta_Alumno_En_Curso(Curso curso)
        {
            
            if ( curso.Cantidad_De_Alumnos_Inscritos < curso.Capacidad_Alumnos_Maximo && curso.fecha_inscripcion_del_alumno == curso.FechaInicioCursos)
            {   
                curso.Cantidad_De_Alumnos_Inscritos++;
                List<Curso> Alumnos_Inscriptos = new List<Curso>();
                Alumnos_Inscriptos.Add(curso);
            }
            else
            {
                MessageBox.Show("El curso esta lleno o la fecha de inscripcion no coincide con la fecha de inicio del curso");
                    
            }
        }
        
        
        

        public float Recaudacion_Total()
        {
            float recaudacion_total=0;

            foreach (Curso a in this._cursos)
            {
                recaudacion_total += a.Recaudacion();
            }

            return recaudacion_total;
        }
        
        
        
    }
    
    
    
    
}