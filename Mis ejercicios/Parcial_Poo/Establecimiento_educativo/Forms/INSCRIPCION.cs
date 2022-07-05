using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Establecimiento_educativo.TADS;

namespace Establecimiento_educativo
{
    public partial class INSCRIPCION : Form
    {
        Curso curso = new Curso();
        Alumno alumno = new Alumno();
        Instituto instituto = new Instituto();


        public INSCRIPCION()
        {
            InitializeComponent();
        }

        public void Carga(object sender, EventArgs e)
        {
            cmb_tipos_curso.Items.Add(EnumTipo.auxiliar_Contable);
            cmb_tipos_curso.Items.Add(EnumTipo.ingles);
            cmb_tipos_curso.Items.Add(EnumTipo.instalacion_AA);
            cmb_tipos_curso.Items.Add(EnumTipo.reparacion_PC);
            cmb_tipos_curso.Items.Add(EnumTipo.reparado_Celulares);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agrega alumno 
            Curso curso1 = (Curso) lstnombrealumnosinscrip.SelectedItem;
            curso1.Precio_Del_Curso = int.Parse(precio_cursotb.Text); 
            Alumno alumno = (Alumno) listBox1.SelectedItem;
            curso1.cursoAlumnosInscriptos(alumno);
            curso1.Cobrar_Curso(alumno);
            try
            {
                curso1.inscribir(alumno);
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }
            
        }

        //Agrega alumno a la lista de alumnos
        private void button3_Click(object sender, EventArgs e)
        {
            if (texbox_nombre == null && texbox_dni == null)
            {
                MessageBox.Show("No indico el nombre del alumno o el dni");
            }
            else

            {
                Alumno alumnoNuevo;
                if (radioButton1.Checked)
                {
                    alumnoNuevo = new Alumno_Paga_Completo();
                }else if (radioButton2.Checked)
                {
                    alumnoNuevo = new Alumno_Med_Beca();

                }else if (radioButton3.Checked)
                {
                    alumnoNuevo = new Alumno_ochenta_Beca();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un tipo de beca");
                    throw new Exception();
                }
                    
                alumnoNuevo.Nombre = texbox_nombre.Text;
                alumnoNuevo.Dni = int.Parse(texbox_dni.Text);
                instituto.Ingresar_Alumno(alumnoNuevo);
                listBox1.DataSource = instituto.Alumnos.ToArray();
                listBox1.DisplayMember = "ToString";

                MessageBox.Show("Se ha agregado el alumno correctamente", alumnoNuevo.Nombre + alumnoNuevo.Dni);
          
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstnombrealumnosinscrip.DataSource = null;
            listBox1.DataSource = null;
            listBox1.Items.Clear();
        }

        private void btnagregar_curso(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            Curso nuevoCurso = new Curso();

            nuevoCurso.Nombre_Del_Curso = nombre_cursotb.Text;
            nuevoCurso.Tipo = (EnumTipo)cmb_tipos_curso.SelectedItem;
            nuevoCurso.Precio_Del_Curso = float.Parse(precio_cursotb.Text);
            nuevoCurso.FechaInicioCursos = fecha_inicio_cursodtpicker1.Value;
            instituto.Ingresar_Curso(curso);
            lstnombrealumnosinscrip.DataSource = instituto.Cursos.ToArray();
            lstnombrealumnosinscrip.DisplayMember = "ToString";
        }
            
        
        private void carga_Combobox()
        {
            foreach (var tipo in Enum.GetValues(typeof(EnumTipo)))
            {
                cmb_tipos_curso.Items.Add(tipo);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Curso c = (Curso) lstnombrealumnosinscrip.SelectedItem;
            textBox2.Text = c.Recaudacion().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           textBox1.Text = instituto.Recaudacion_Total().ToString();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}