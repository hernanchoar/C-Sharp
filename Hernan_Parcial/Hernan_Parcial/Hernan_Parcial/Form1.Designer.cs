
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
            this.lblCamara = new System.Windows.Forms.Label();
            this.lblBateria = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblDimensiones = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.cmbBateria = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtDimensiones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 94);
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
            // lblCamara
            // 
            this.lblCamara.AutoSize = true;
            this.lblCamara.Location = new System.Drawing.Point(12, 148);
            this.lblCamara.Name = "lblCamara";
            this.lblCamara.Size = new System.Drawing.Size(43, 13);
            this.lblCamara.TabIndex = 5;
            this.lblCamara.Text = "Camara";
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.Location = new System.Drawing.Point(15, 189);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(40, 13);
            this.lblBateria.TabIndex = 7;
            this.lblBateria.Text = "Bateria";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(96, 257);
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
            this.listBox1.Location = new System.Drawing.Point(223, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 82);
            this.listBox1.TabIndex = 14;
            // 
            // lblDimensiones
            // 
            this.lblDimensiones.AutoSize = true;
            this.lblDimensiones.Location = new System.Drawing.Point(12, 121);
            this.lblDimensiones.Name = "lblDimensiones";
            this.lblDimensiones.Size = new System.Drawing.Size(67, 13);
            this.lblDimensiones.TabIndex = 18;
            this.lblDimensiones.Text = "Dimensiones";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(96, 70);
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
            this.cmbCamara.Location = new System.Drawing.Point(96, 148);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(121, 21);
            this.cmbCamara.TabIndex = 21;
            this.toolTip1.SetToolTip(this.cmbCamara, "Indique el tipo de CAMARA que desea colocar en el robot \r\n");
            // 
            // cmbBateria
            // 
            this.cmbBateria.FormattingEnabled = true;
            this.cmbBateria.Location = new System.Drawing.Point(96, 181);
            this.cmbBateria.Name = "cmbBateria";
            this.cmbBateria.Size = new System.Drawing.Size(121, 21);
            this.cmbBateria.TabIndex = 22;
            this.toolTip1.SetToolTip(this.cmbBateria, "\r\nIndique el tipo de BATERIA que desea colocar en el robot\r\n");
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.Location = new System.Drawing.Point(96, 120);
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.Size = new System.Drawing.Size(100, 20);
            this.txtDimensiones.TabIndex = 41;
            this.toolTip1.SetToolTip(this.txtDimensiones, "Indique el nombre que desee ponerle al robot \r\n");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "ALTA ROBOT";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(15, 215);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(94, 13);
            this.lblCapacidad.TabIndex = 43;
            this.lblCapacidad.Text = "Capacidad Bateria";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(115, 215);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidad.TabIndex = 44;
            this.toolTip1.SetToolTip(this.txtCapacidad, "Indique el nombre que desee ponerle al robot \r\n");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 342);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDimensiones);
            this.Controls.Add(this.cmbBateria);
            this.Controls.Add(this.cmbCamara);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblDimensiones);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblBateria);
            this.Controls.Add(this.lblCamara);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolTip toolTip1;

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCamara;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblDimensiones;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.ComboBox cmbBateria;
        private System.Windows.Forms.TextBox txtDimensiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCapacidad;
    }
}

