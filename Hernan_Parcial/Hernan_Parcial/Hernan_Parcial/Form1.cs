using Hernan_Parcial.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hernan_Parcial
{
    public partial class Form1 : Form
    {
        GstRobot gst = new GstRobot();
        //Robot robot = new Robot();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Robot robot = new Robot
            {
                Nombre = txtNombre.Text,
                Bateria = new Bateria()
                { 
                    Capacidad = Convert.ToDecimal(txtCapacidad),
                    Id = Convert.ToInt32(cmbBateria.SelectedItem)
                }
            };
     
            if(gst.AltaRobot(robot) != null)
            {
                listBox1.DataSource = null;
                listBox1.DataSource = gst.Robots;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBateria.Items.Add("Seleccionar");
            cmbBateria.Items.Add(EnumBateria.Alkalinas);
            cmbBateria.Items.Add(EnumBateria.Litio);
            cmbBateria.Items.Add(EnumBateria.Pack_Baterias);
            cmbBateria.Items.Add(EnumBateria.Recargables);
            cmbBateria.SelectedText = "Seleccionar";
            cmbCamara.Items.Add("Seleccionar");
            cmbCamara.Items.Add(EnumCamara.Un_Mega_720);
            cmbCamara.Items.Add(EnumCamara.Un_Mega_720);
            cmbCamara.Items.Add(EnumCamara.Dos_Megas);
            cmbCamara.Items.Add(EnumCamara.Tres_Megas);
            cmbCamara.Items.Add(EnumCamara.Cinco_Megas);
            cmbCamara.Items.Add(EnumCamara.Ocho_Megas);
            cmbCamara.Items.Add(EnumCamara.Doce_Megas);
            cmbCamara.Items.Add(EnumCamara.Treinta_y_Tres_Megas);
            cmbCamara.SelectedText = "Seleccionar";
            cmbTipo.Items.Add("Seleccionar");
            cmbTipo.Items.Add(EnumTipo.Robot_Explorador);
            cmbTipo.Items.Add(EnumTipo.Robot_Sonda);
            cmbTipo.Items.Add(EnumTipo.Sonda_Especial);
            cmbTipo.SelectedText = "Seleccionar";
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipo.Text)
            {
                case "Sonda_Especial":
                    lblAltitud.Visible = true; txtAltitud.Visible = true;
                    lblDesplazo.Visible = false; txtDesplazo.Visible = false; lblVelocidad.Visible = false; txtVelocidad.Visible = false;
                    lblSensorCalor.Visible = false; txtSensorCalor.Visible = false; lblSensorSismo.Visible = false; txtSensorSismo.Visible = false; lblViento.Visible = false; txtSensorViento.Visible = false;
                    txtDesplazo.Text = ""; txtVelocidad.Text = "";
                    txtSensorCalor.Text = ""; txtSensorSismo.Text = ""; txtSensorViento.Text = "";
                    break;
                case "Robot_Explorador":
                    lblAltitud.Visible = false; txtAltitud.Visible = false;
                    lblDesplazo.Visible = true; txtDesplazo.Visible = true; lblVelocidad.Visible = true; txtVelocidad.Visible = true;
                    lblSensorCalor.Visible = false; txtSensorCalor.Visible = false; lblSensorSismo.Visible = false; txtSensorSismo.Visible = false; lblViento.Visible = false; txtSensorViento.Visible = false;
                    txtAltitud.Text = "";
                    txtSensorCalor.Text = ""; txtSensorSismo.Text = ""; txtSensorViento.Text = "";
                    break;
                case "Robot_Sonda":
                    lblAltitud.Visible = false; txtAltitud.Visible = false;
                    lblDesplazo.Visible = false; txtDesplazo.Visible = false; lblVelocidad.Visible = true; txtVelocidad.Visible = false;
                    lblSensorCalor.Visible = true; txtSensorCalor.Visible = true; lblSensorSismo.Visible = true; txtSensorSismo.Visible = true; lblViento.Visible = true; txtSensorViento.Visible = true;
                    txtAltitud.Text = "";
                    txtDesplazo.Text = ""; txtVelocidad.Text = "";
                    break;
                default: break;
                //default:
                //    lblAltitud.Visible = false; txtAltitud.Visible = false;
                //    lblDesplazo.Visible = false; txtDesplazo.Visible = false; lblVelocidad.Visible = false; txtVelocidad.Visible = false;
                //    lblSensorCalor.Visible = false; txtSensorCalor.Visible = false; lblSensorSismo.Visible = false; txtSensorSismo.Visible = false; lblViento.Visible = false; txtSensorViento.Visible = false;
                //    txtAltitud.Text = "";
                //    txtDesplazo.Text = ""; txtVelocidad.Text = "";
                //    txtSensorCalor.Text = ""; txtSensorSismo.Text = ""; txtSensorViento.Text = "";
                //    break;
            }
        }
    }
}
