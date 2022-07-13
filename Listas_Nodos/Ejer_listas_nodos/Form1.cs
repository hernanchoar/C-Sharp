using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer_listas_nodos
{
    public partial class Form1 : Form
    {
        Alumno alum = new Alumno();
        Instituto inst = new Instituto();
        private const int paga500 = 500;
        private const int paga600 = 600;

        public int RecaudacionParcial { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga alumnos en inst.Alumnos
        /// Guarda en archivo cada aluno en formato Nombre,Legajo,DNI (archivo texto)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                int cuota = 0;

                if (checkBox1.Checked == true) //Cuota de $500
                {
                    checkBox2.Checked = false;
                    cuota = paga500;
                }
                else if (checkBox2.Checked == true) //Cuota de $600
                {
                    checkBox1.Checked = false;
                    cuota = paga600;
                }
                else
                {
                    throw new ArgumentException("Debe seleccionar el tirpo de cuota");
                }
                alum.Nombre = txtnom.Text;
                alum.Legajo = Convert.ToInt32(txtlegajo.Text);
                alum.DNI = Convert.ToInt32(txtdni.Text);

                inst.AgregarAlumno(alum);
                listBox1.Items.Add("Nombre " + alum.Nombre + " Legajo " + alum.Legajo + " DNI " + alum.DNI);
                listBox2.Items.Add(cuota.ToString());
                RecaudacionParcial = inst.AumentarRecaudacion(cuota);
                txtcantalum.Text = inst.Alumnos.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            txttotal.Text = RecaudacionParcial.ToString();
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            var alum = inst.Alumnos[listBox1.SelectedIndex];
            inst.Alumnos.Remove(alum);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            
            //  inst.Eliminar_Alumno(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(inst.Alumnos.Count.ToString());
            //PORQUE MUESTRA SOLO EL ULTIMO VARIAS VECES
            alumnoBindingSource.DataSource = inst.Alumnos;
            
            //Reducir valor RecaudacionParcial, Valor Contador de Alumnos, Valor de Total.
            
        }
    }
}