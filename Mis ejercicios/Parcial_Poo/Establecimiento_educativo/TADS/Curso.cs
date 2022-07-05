using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Establecimiento_educativo.TADS
{
    public class Curso
    {
        
        //Lista nueva de alumnos inscriptos 
        
        
        private List<Alumno> Alumnos_Inscriptos = new List<Alumno>();
        
        public List<Alumno> alumnos_inscriptos
        {
            get { return Alumnos_Inscriptos; }
            set { Alumnos_Inscriptos = value; }
        }

/*
        private string tipo;

        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }
    */    
        
        //---> Nombre del curso 

         private string nombre_del_curso;

         public string Nombre_Del_Curso
         {
             get=> nombre_del_curso;
             set => nombre_del_curso = value;
         }
        
        //----> Precio del curso  
         private float precio_del_curso;
         public float Precio_Del_Curso
         {
             get => precio_del_curso; 
             set=>precio_del_curso = value;
             
         }

         private float recaudacion_Curso = 0;
         
        
         //----> Fecha de inicio de curso 
         private DateTime Fecha_Inicio_Cursos;

         public DateTime FechaInicioCursos
         {
             get => Fecha_Inicio_Cursos;
             set => Fecha_Inicio_Cursos = value;
         }


         //Fecha de inscripcion del alumno 
         private DateTime Fecha_Inscripcion_del_Alumno;

         public DateTime fecha_inscripcion_del_alumno
         {
             set => Fecha_Inscripcion_del_Alumno = DateTime.Now;
             get => Fecha_Inscripcion_del_Alumno;

         }
         
         
         //----> Cantidad de alumnos INSCRIPTOS
         
         private int cantidad_De_Alumnos_Inscritos;

         public int Cantidad_De_Alumnos_Inscritos
         {
             get => cantidad_De_Alumnos_Inscritos; 
             set => cantidad_De_Alumnos_Inscritos = value;
         }
         
         
         //--->Capacidad maxima del curso 
         
         private int capacidad_alumnos_maximo;
         public int Capacidad_Alumnos_Maximo
         {
             get => capacidad_alumnos_maximo;
             set => capacidad_alumnos_maximo = 30;
         }
         
        
            //Enum tipo de curso 
                            
            private EnumTipo tipo;

            public EnumTipo Tipo
            {
                get { return tipo; }
                set { tipo = value; }
            }
            
            
            //--------------------------------Metodos----------------------------------------------//
            
            public int Obtener_Cantidad_Alumnos_Instriptos(int cantidad_alumnos_inscritos)
            {
                Cantidad_De_Alumnos_Inscritos = cantidad_alumnos_inscritos;
                cantidad_alumnos_inscritos++;
                return cantidad_alumnos_inscritos;
            }
            
            
            // Verifica cupo para inscripciones
            
            private bool Chequea_Disponibilidad_Inscripciones(Curso curso)
            {
                bool bool_Verifica_Dispo_Capac = true;
               
                if (curso.Cantidad_De_Alumnos_Inscritos < curso.Capacidad_Alumnos_Maximo)
                {
                    bool_Verifica_Dispo_Capac = true;
                }
                else
                {
                    // return false;
                    MessageBox.Show("El curso esta lleno");
                    bool_Verifica_Dispo_Capac = false;
                }
                return bool_Verifica_Dispo_Capac;
            }

            
          
        // Verifica fecha de inscripcion valida que el alumno se inscribe al curso
        
            public bool Verifica_Fecha_Inscripcion()
            {
               // Curso curso = new Curso();
              
                bool bool_Verifica_Fecha_insc = true;

                DateTime fecha_actual = DateTime.Now;
                if (this.Fecha_Inicio_Cursos >= fecha_actual)
                {
                    return true;
                   
                }
                else
                {

                    return false;
                }
                return bool_Verifica_Fecha_insc;
               //True no se puede anotar en el curso 
                //False si se puede anotar
            }

            public bool disponibilidad()
            {
                int i;

                i = this.alumnos_inscriptos.Count;

                if (i > this.capacidad_alumnos_maximo)
                {
                    return false;
                    throw new Exception("Inscripcion fuera de fecha");
                    
                }

                return true;
            }
            
            
            public void cursoAlumnosInscriptos(Alumno alumno_inscripto)
            {
                Alumnos_Inscriptos.Add(alumno_inscripto); 
            }


            public void Cobrar_Curso(Alumno alumno)
            {
                recaudacion_Curso += precio_del_curso*alumno.Coe();
            }
            
            
            public float Recaudacion()
            {
                float r = 0;
                
                foreach (Alumno a in this.alumnos_inscriptos)
                {
                    r += a.Coe()*this.precio_del_curso;
                }

                return r;
            }
            
            public override String ToString() {
                return "Nombre del curso: " + this.Nombre_Del_Curso ;
            }

            public void inscribir(Alumno alumno)
            {
                disponibilidad();
                Verifica_Fecha_Inscripcion();
                
                this.alumnos_inscriptos.Add(alumno);
            }
           
    }
    
}