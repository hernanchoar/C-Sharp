using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  throw new System.NotImplementedException();
            
          
          
          
          if (textBox1 == null && textBox2 == null && textBox3 == null && textBox4 == null)
          {
              MessageBox.Show("No ingreso todos los campos del producto que va a ingresar");
          }
          else
          {
              Producto productoNuevo = new Producto();
              Libreria libreria = new Libreria();
              
              
              productoNuevo.Codigo_de_Barras = int.Parse(textBox1.Text);
              textBox1.Text = "";
              productoNuevo.Nombre_Del_Producto = textBox2.ToString();
              textBox2.Text = "";
              productoNuevo.Descripcion = textBox3.ToString();
              textBox3.Text = "";
              productoNuevo.Precio = float.Parse(textBox4.Text);
              textBox4.Text = "";
              libreria.Ingresar_Producto(productoNuevo);

              listBox1.DataSource = libreria.Productos.ToArray();
              listBox1.DisplayMember = "ToString";
              

              MessageBox.Show("El producto se agrego correctamente");

            

          }
          
        }
    }
}