using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  throw new System.NotImplementedException();

          Sumar suma = new Sumar();

          suma.Valor1 = int.Parse(textBox1.Text);

          suma.Valor2 = int.Parse(textBox2.Text);
          suma.Hacer_Sumar(suma.Valor1,suma.Valor2);
          textBox3.Text = suma.Resultado.ToString();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();

            Restar resta = new Restar();

            resta.Valor1 = int.Parse(textBox1.Text);
            resta.Valor2 = int.Parse(textBox2.Text);
            resta.Hacer_Restar(resta.Valor1, resta.Valor2);
            textBox3.Text = resta.Resultado.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // throw new System.NotImplementedException();

           Application.Exit();
        }
    }
}