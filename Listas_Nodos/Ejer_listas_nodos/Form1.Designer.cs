namespace Ejer_listas_nodos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtlegajo = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.txtcantalum = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblCantAlumnos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(120, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 173);
            this.listBox1.TabIndex = 0;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(28, 80);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(86, 20);
            this.txtnom.TabIndex = 1;
            // 
            // txtlegajo
            // 
            this.txtlegajo.Location = new System.Drawing.Point(28, 148);
            this.txtlegajo.Name = "txtlegajo";
            this.txtlegajo.Size = new System.Drawing.Size(86, 20);
            this.txtlegajo.TabIndex = 2;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(28, 210);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(86, 20);
            this.txtdni.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Legajo";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(28, 290);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(147, 51);
            this.btnAgregarAlumno.TabIndex = 7;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // txtcantalum
            // 
            this.txtcantalum.Location = new System.Drawing.Point(264, 317);
            this.txtcantalum.Name = "txtcantalum";
            this.txtcantalum.Size = new System.Drawing.Size(110, 20);
            this.txtcantalum.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(236, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Cuota $ 500";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(332, 260);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Cuota $ 600";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(336, 69);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(86, 173);
            this.listBox2.TabIndex = 12;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(512, 359);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(147, 51);
            this.btnTotal.TabIndex = 13;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(511, 317);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(114, 20);
            this.txttotal.TabIndex = 14;
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Location = new System.Drawing.Point(28, 368);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(147, 51);
            this.btnEliminarAlumno.TabIndex = 15;
            this.btnEliminarAlumno.Text = "Eliminar Alumno";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(512, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Monto $";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(714, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 51);
            this.button4.TabIndex = 17;
            this.button4.Text = "Listar Alumnos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblCantAlumnos
            // 
            this.lblCantAlumnos.Location = new System.Drawing.Point(261, 293);
            this.lblCantAlumnos.Name = "lblCantAlumnos";
            this.lblCantAlumnos.Size = new System.Drawing.Size(77, 21);
            this.lblCantAlumnos.TabIndex = 18;
            this.lblCantAlumnos.Text = "Cantidad Alumnos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.legajoDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.Cuota});
            this.dataGridView1.DataSource = this.alumnoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(448, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 182);
            this.dataGridView1.TabIndex = 19;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(Ejer_listas_nodos.Alumno);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // legajoDataGridViewTextBoxColumn
            // 
            this.legajoDataGridViewTextBoxColumn.DataPropertyName = "Legajo";
            this.legajoDataGridViewTextBoxColumn.HeaderText = "Legajo";
            this.legajoDataGridViewTextBoxColumn.Name = "legajoDataGridViewTextBoxColumn";
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // Cuota
            // 
            this.Cuota.DataPropertyName = "Nombre";
            this.Cuota.HeaderText = "Cuota";
            this.Cuota.Name = "Cuota";
            this.Cuota.ReadOnly = true;
            this.Cuota.ToolTipText = "Cuota que paga el alumno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(888, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCantAlumnos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtcantalum);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtlegajo);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.listBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button btnEliminarAlumno;

        private System.Windows.Forms.TextBox txttotal;

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnTotal;

        private System.Windows.Forms.TextBox txtcantalum;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtlegajo;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarAlumno;

        #endregion

        private System.Windows.Forms.Label lblCantAlumnos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
    }
}