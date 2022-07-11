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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                //Cuota de 500
                var nombre = alum.Nombre;
                var legajo = alum.Legajo;
                var dni = alum.DNI;
                var cuota = inst.Paga500;

                nombre = txtnom.Text;
                legajo = Convert.ToInt32(txtlegajo.Text);
                dni = Convert.ToInt32(txtdni.Text);

                inst.AgregarAlumno(alum);
                listBox1.Items.Add("Nombre " + nombre + " Legajo " + legajo + " DNI " + dni);
                listBox2.Items.Add(cuota.ToString());
                inst.Aumentar_Recaudacion();
                txtcantalum.Text = inst.Alumnos.Count.ToString();
            }
            else if (checkBox2.Checked == true)
            {
                //Cuota de 600

                var nombre = alum.Nombre;
                var legajo = alum.Legajo;
                var dni = alum.DNI;
                var cuota = inst.Paga600;
                nombre = txtnom.Text;
                legajo = Convert.ToInt32(txtlegajo.Text);
                dni = Convert.ToInt32(txtdni.Text);

                inst.AgregarAlumno(alum);
                listBox1.Items.Add("Nombre " + nombre + " Legajo " + legajo + " DNI " + dni);
                listBox2.Items.Add(cuota);
                inst.Aumentar_Recaudacion2();
                txtcantalum.Text = inst.Alumnos.Count.ToString();
            }
            else
            {
                MessageBox.Show("Dese seleccionar el tirpo de cuota");
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var salida = inst.Obtener_Ingreso_x_Cuota(inst.Recaudacion);
            txttotal.Text = salida.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedIndex);
            //  inst.Eliminar_Alumno(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inst.Alumnos.Count.ToString());
            
        }
    }
}