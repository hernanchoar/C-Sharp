using System.ComponentModel;

namespace Establecimiento_educativo
{
    partial class INSCRIPCION
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texbox_nombre = new System.Windows.Forms.TextBox();
            this.texbox_dni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tipos_curso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.precio_cursotb = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha_inicio_cursodtpicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.lstnombrealumnosinscrip = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.nombre_cursotb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inscribir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(741, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(506, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre y Apellido";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(506, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI";
            // 
            // texbox_nombre
            // 
            this.texbox_nombre.Location = new System.Drawing.Point(619, 17);
            this.texbox_nombre.Name = "texbox_nombre";
            this.texbox_nombre.Size = new System.Drawing.Size(221, 20);
            this.texbox_nombre.TabIndex = 10;
            // 
            // texbox_dni
            // 
            this.texbox_dni.Location = new System.Drawing.Point(619, 61);
            this.texbox_dni.Name = "texbox_dni";
            this.texbox_dni.Size = new System.Drawing.Size(221, 20);
            this.texbox_dni.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(64, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cursos Disponibles ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(506, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tipo de Beca";
            // 
            // cmb_tipos_curso
            // 
            this.cmb_tipos_curso.FormattingEnabled = true;
            this.cmb_tipos_curso.Location = new System.Drawing.Point(184, 16);
            this.cmb_tipos_curso.Name = "cmb_tipos_curso";
            this.cmb_tipos_curso.Size = new System.Drawing.Size(221, 21);
            this.cmb_tipos_curso.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(64, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // precio_cursotb
            // 
            this.precio_cursotb.Location = new System.Drawing.Point(184, 61);
            this.precio_cursotb.Name = "precio_cursotb";
            this.precio_cursotb.Size = new System.Drawing.Size(221, 20);
            this.precio_cursotb.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(506, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 108);
            this.listBox1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(64, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Listas de cursos inscriptos";
            // 
            // fecha_inicio_cursodtpicker1
            // 
            this.fecha_inicio_cursodtpicker1.Location = new System.Drawing.Point(184, 145);
            this.fecha_inicio_cursodtpicker1.Name = "fecha_inicio_cursodtpicker1";
            this.fecha_inicio_cursodtpicker1.Size = new System.Drawing.Size(221, 20);
            this.fecha_inicio_cursodtpicker1.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(752, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 31);
            this.button3.TabIndex = 28;
            this.button3.Text = "Agregar Alumno";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstnombrealumnosinscrip
            // 
            this.lstnombrealumnosinscrip.FormattingEnabled = true;
            this.lstnombrealumnosinscrip.Location = new System.Drawing.Point(69, 246);
            this.lstnombrealumnosinscrip.Name = "lstnombrealumnosinscrip";
            this.lstnombrealumnosinscrip.Size = new System.Drawing.Size(351, 108);
            this.lstnombrealumnosinscrip.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(506, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Alumnos Ingresados";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(64, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 25);
            this.button5.TabIndex = 32;
            this.button5.Text = "Calcular parcial";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(64, 466);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 25);
            this.button6.TabIndex = 33;
            this.button6.Text = "Calcular TT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 508);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 423);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(64, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Recaudacion por curso ";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(64, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Recacudacion TT";
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(619, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 27);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Paga completo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(714, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 27);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Paga Mitad";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(795, 94);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 27);
            this.radioButton3.TabIndex = 41;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Paga 80%";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(315, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 33);
            this.button7.TabIndex = 42;
            this.button7.Text = "Dar de alta curso";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnagregar_curso);
            // 
            // nombre_cursotb
            // 
            this.nombre_cursotb.Location = new System.Drawing.Point(184, 105);
            this.nombre_cursotb.Name = "nombre_cursotb";
            this.nombre_cursotb.Size = new System.Drawing.Size(221, 20);
            this.nombre_cursotb.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(64, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 24);
            this.label10.TabIndex = 44;
            this.label10.Text = "Tipo de curso";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(64, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Fecha de inscripcion";
            // 
            // INSCRIPCION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 548);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nombre_cursotb);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstnombrealumnosinscrip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fecha_inicio_cursodtpicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.precio_cursotb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_tipos_curso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texbox_dni);
            this.Controls.Add(this.texbox_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "INSCRIPCION";
            this.Text = "INSCRIPCION";
            this.Load += new System.EventHandler(this.Carga);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.TextBox nombre_cursotb;

        private System.Windows.Forms.ComboBox cmb_tipos_curso;

        private System.Windows.Forms.Button button7;

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.ListBox lstnombrealumnosinscrip;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.DateTimePicker fecha_inicio_cursodtpicker1;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.TextBox precio_cursotb;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox texbox_nombre;
        private System.Windows.Forms.TextBox texbox_dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}