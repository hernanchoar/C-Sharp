
namespace Hernan_Parcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.lblCamara = new System.Windows.Forms.Label();
            this.lblBateria = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.lblAlto = new System.Windows.Forms.Label();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.checkAlta = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.cmbBateria = new System.Windows.Forms.ComboBox();
            this.txtDesplazo = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.lblDesplazo = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.lblSensorSismo = new System.Windows.Forms.Label();
            this.lblSensorCalor = new System.Windows.Forms.Label();
            this.txtSensorSismo = new System.Windows.Forms.TextBox();
            this.txtSensorCalor = new System.Windows.Forms.TextBox();
            this.lblViento = new System.Windows.Forms.Label();
            this.txtSensorViento = new System.Windows.Forms.TextBox();
            this.lblAltitud = new System.Windows.Forms.Label();
            this.txtAltitud = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.btnMasCaro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMasBarato = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(61, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNombre, "Indique el nombre que desee ponerle al robot \r\n");
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(11, 123);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(34, 13);
            this.lblLargo.TabIndex = 3;
            this.lblLargo.Text = "Largo";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(61, 120);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 20);
            this.txtLargo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtLargo, "Introduzca el Largo del robot\r\n");
            // 
            // lblCamara
            // 
            this.lblCamara.AutoSize = true;
            this.lblCamara.Location = new System.Drawing.Point(11, 251);
            this.lblCamara.Name = "lblCamara";
            this.lblCamara.Size = new System.Drawing.Size(43, 13);
            this.lblCamara.TabIndex = 5;
            this.lblCamara.Text = "Camara";
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.Location = new System.Drawing.Point(11, 277);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(40, 13);
            this.lblBateria.TabIndex = 7;
            this.lblBateria.Text = "Bateria";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(11, 172);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(38, 13);
            this.lblAncho.TabIndex = 9;
            this.lblAncho.Text = "Ancho";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(61, 170);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtAncho, "Introduzca el ANCHO del robot \r\n");
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Location = new System.Drawing.Point(12, 149);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(25, 13);
            this.lblAlto.TabIndex = 11;
            this.lblAlto.Text = "Alto";
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(61, 144);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(100, 20);
            this.txtAlto.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtAlto, "Introduzca el ALTO del robot\r\n");
            // 
            // checkAlta
            // 
            this.checkAlta.AutoSize = true;
            this.checkAlta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkAlta.Location = new System.Drawing.Point(15, 300);
            this.checkAlta.Name = "checkAlta";
            this.checkAlta.Size = new System.Drawing.Size(59, 17);
            this.checkAlta.TabIndex = 12;
            this.checkAlta.Text = "Activar";
            this.checkAlta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.checkAlta, "Activa el robot que usted ha seleccionado \r\n");
            this.checkAlta.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(61, 337);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAgregar, "Crear un nuevo robot");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(223, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 95);
            this.listBox1.TabIndex = 14;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(11, 199);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 16;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(61, 196);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtPeso, "Introduzca el PESO del robot \r\n");
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(11, 225);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 18;
            this.lblCosto.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(61, 222);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtCosto, "Introduzca el COSTO del robot \r\n");
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(61, 67);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 19;
            this.toolTip1.SetToolTip(this.cmbTipo, "Indica el tipo de robot que desea crear \r\n");
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 70);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 20;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbCamara
            // 
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(60, 248);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(121, 21);
            this.cmbCamara.TabIndex = 21;
            this.toolTip1.SetToolTip(this.cmbCamara, "Indique el tipo de CAMARA que desea colocar en el robot \r\n");
            // 
            // cmbBateria
            // 
            this.cmbBateria.FormattingEnabled = true;
            this.cmbBateria.Location = new System.Drawing.Point(61, 277);
            this.cmbBateria.Name = "cmbBateria";
            this.cmbBateria.Size = new System.Drawing.Size(121, 21);
            this.cmbBateria.TabIndex = 22;
            this.toolTip1.SetToolTip(this.cmbBateria, "\r\nIndique el tipo de BATERIA que desea colocar en el robot\r\n");
            // 
            // txtDesplazo
            // 
            this.txtDesplazo.Location = new System.Drawing.Point(290, 122);
            this.txtDesplazo.Name = "txtDesplazo";
            this.txtDesplazo.Size = new System.Drawing.Size(100, 20);
            this.txtDesplazo.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txtDesplazo, "Indique el DESPLAZAMIENTO\r\n");
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(467, 121);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidad.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtVelocidad, "Indique la VELOCIDAD\r\n");
            // 
            // lblDesplazo
            // 
            this.lblDesplazo.AutoSize = true;
            this.lblDesplazo.Location = new System.Drawing.Point(214, 128);
            this.lblDesplazo.Name = "lblDesplazo";
            this.lblDesplazo.Size = new System.Drawing.Size(51, 13);
            this.lblDesplazo.TabIndex = 25;
            this.lblDesplazo.Text = "Desplazo";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(390, 125);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(54, 13);
            this.lblVelocidad.TabIndex = 26;
            this.lblVelocidad.Text = "Velocidad";
            // 
            // lblSensorSismo
            // 
            this.lblSensorSismo.AutoSize = true;
            this.lblSensorSismo.Location = new System.Drawing.Point(389, 99);
            this.lblSensorSismo.Name = "lblSensorSismo";
            this.lblSensorSismo.Size = new System.Drawing.Size(71, 13);
            this.lblSensorSismo.TabIndex = 30;
            this.lblSensorSismo.Text = "Sensor Sismo";
            // 
            // lblSensorCalor
            // 
            this.lblSensorCalor.AutoSize = true;
            this.lblSensorCalor.Location = new System.Drawing.Point(214, 102);
            this.lblSensorCalor.Name = "lblSensorCalor";
            this.lblSensorCalor.Size = new System.Drawing.Size(67, 13);
            this.lblSensorCalor.TabIndex = 29;
            this.lblSensorCalor.Text = "Sensor Calor";
            // 
            // txtSensorSismo
            // 
            this.txtSensorSismo.Location = new System.Drawing.Point(467, 95);
            this.txtSensorSismo.Name = "txtSensorSismo";
            this.txtSensorSismo.Size = new System.Drawing.Size(100, 20);
            this.txtSensorSismo.TabIndex = 28;
            this.toolTip1.SetToolTip(this.txtSensorSismo, "ndique la cantidad de sensores de SISMO");
            // 
            // txtSensorCalor
            // 
            this.txtSensorCalor.Location = new System.Drawing.Point(290, 96);
            this.txtSensorCalor.Name = "txtSensorCalor";
            this.txtSensorCalor.Size = new System.Drawing.Size(100, 20);
            this.txtSensorCalor.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txtSensorCalor, "Indique la cantidad de sensores de CALOR\r\n");
            // 
            // lblViento
            // 
            this.lblViento.AutoSize = true;
            this.lblViento.Location = new System.Drawing.Point(570, 100);
            this.lblViento.Name = "lblViento";
            this.lblViento.Size = new System.Drawing.Size(73, 13);
            this.lblViento.TabIndex = 32;
            this.lblViento.Text = "Sensor Viento";
            // 
            // txtSensorViento
            // 
            this.txtSensorViento.Location = new System.Drawing.Point(648, 96);
            this.txtSensorViento.Name = "txtSensorViento";
            this.txtSensorViento.Size = new System.Drawing.Size(100, 20);
            this.txtSensorViento.TabIndex = 31;
            this.toolTip1.SetToolTip(this.txtSensorViento, "Indique la cantidad de SENSORES de VIENTO\r\n");
            // 
            // lblAltitud
            // 
            this.lblAltitud.AutoSize = true;
            this.lblAltitud.Location = new System.Drawing.Point(214, 76);
            this.lblAltitud.Name = "lblAltitud";
            this.lblAltitud.Size = new System.Drawing.Size(72, 13);
            this.lblAltitud.TabIndex = 34;
            this.lblAltitud.Text = "Altitud Minima";
            // 
            // txtAltitud
            // 
            this.txtAltitud.Location = new System.Drawing.Point(290, 70);
            this.txtAltitud.Name = "txtAltitud";
            this.txtAltitud.Size = new System.Drawing.Size(100, 20);
            this.txtAltitud.TabIndex = 33;
            this.toolTip1.SetToolTip(this.txtAltitud, "Indique la altitud MINIMA de la sonda \r\n");
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(223, 310);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(439, 95);
            this.listBox2.TabIndex = 35;
            // 
            // btnConsumo
            // 
            this.btnConsumo.Location = new System.Drawing.Point(731, 293);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(159, 22);
            this.btnConsumo.TabIndex = 36;
            this.btnConsumo.Text = "Buscar RBT x consumo";
            this.toolTip1.SetToolTip(this.btnConsumo, "Busca el robot cuya batería se consume mas rapido en función del consumo de sus c" + "omponentes");
            this.btnConsumo.UseVisualStyleBackColor = true;
            // 
            // btnMasCaro
            // 
            this.btnMasCaro.Location = new System.Drawing.Point(731, 321);
            this.btnMasCaro.Name = "btnMasCaro";
            this.btnMasCaro.Size = new System.Drawing.Size(159, 22);
            this.btnMasCaro.TabIndex = 37;
            this.btnMasCaro.Text = "Buscar + Caro";
            this.toolTip1.SetToolTip(this.btnMasCaro, "Obtener el robot mas caro");
            this.btnMasCaro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(744, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "Modulo de busqueda";
            // 
            // btnMasBarato
            // 
            this.btnMasBarato.Location = new System.Drawing.Point(731, 349);
            this.btnMasBarato.Name = "btnMasBarato";
            this.btnMasBarato.Size = new System.Drawing.Size(159, 22);
            this.btnMasBarato.TabIndex = 39;
            this.btnMasBarato.Text = "Buscar +Barato";
            this.toolTip1.SetToolTip(this.btnMasBarato, "Obtener el robot mas barato");
            this.btnMasBarato.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(731, 383);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(159, 22);
            this.btnListar.TabIndex = 40;
            this.btnListar.Text = "Listar x Nombre";
            this.toolTip1.SetToolTip(this.btnListar, "Listar robots por nombre");
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnMasBarato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMasCaro);
            this.Controls.Add(this.btnConsumo);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblAltitud);
            this.Controls.Add(this.txtAltitud);
            this.Controls.Add(this.lblViento);
            this.Controls.Add(this.txtSensorViento);
            this.Controls.Add(this.lblSensorSismo);
            this.Controls.Add(this.lblSensorCalor);
            this.Controls.Add(this.txtSensorSismo);
            this.Controls.Add(this.txtSensorCalor);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.lblDesplazo);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.txtDesplazo);
            this.Controls.Add(this.cmbBateria);
            this.Controls.Add(this.cmbCamara);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.checkAlta);
            this.Controls.Add(this.lblAlto);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblBateria);
            this.Controls.Add(this.lblCamara);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnListar;

        private System.Windows.Forms.Button btnMasBarato;

        private System.Windows.Forms.ToolTip toolTip1;

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnConsumo;
        private System.Windows.Forms.Button btnMasCaro;
        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label lblCamara;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.CheckBox checkAlta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.ComboBox cmbBateria;
        private System.Windows.Forms.TextBox txtDesplazo;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.Label lblDesplazo;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label lblSensorSismo;
        private System.Windows.Forms.Label lblSensorCalor;
        private System.Windows.Forms.TextBox txtSensorSismo;
        private System.Windows.Forms.TextBox txtSensorCalor;
        private System.Windows.Forms.Label lblViento;
        private System.Windows.Forms.TextBox txtSensorViento;
        private System.Windows.Forms.Label lblAltitud;
        private System.Windows.Forms.TextBox txtAltitud;
    }
}

