using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer1_con_listbox
{
    public partial class Form1 : Form
    {
        private List<string> lista_Comidas = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   throw new System.NotImplementedException();

            Comidas comidas = new Comidas();

            comidas.Minutas = textBox1.Text;
            comidas.Agregar_Comidas(comidas);

            listBox1.DataSource = comidas.Minutas.ToArray();
            listBox1.DisplayMember = "ToString";
        }
    }
}