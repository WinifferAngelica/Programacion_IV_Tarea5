namespace WinFormsClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEstudiantes = new DataGridView();
            btnCargar = new Button();
            textBoxNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerNac = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBoxLugar = new TextBox();
            textBoxCasa = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBoxSangre = new TextBox();
            textBoxVarita = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dateTimePickerIng = new DateTimePicker();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(12, 341);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.Size = new Size(1074, 514);
            dgvEstudiantes.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(12, 306);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(156, 29);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar Estudiantes";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(174, 53);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(250, 27);
            textBoxNombre.TabIndex = 2;
            textBoxNombre.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 99);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 4;
            label2.Text = "Fecha de nacimiento";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 60);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Casa";
            // 
            // dateTimePickerNac
            // 
            dateTimePickerNac.Location = new Point(174, 94);
            dateTimePickerNac.Name = "dateTimePickerNac";
            dateTimePickerNac.Size = new Size(250, 27);
            dateTimePickerNac.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 171);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha de Ingreso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 137);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 8;
            label5.Text = "Lugar de nacimiento";
            // 
            // textBoxLugar
            // 
            textBoxLugar.Location = new Point(174, 127);
            textBoxLugar.Name = "textBoxLugar";
            textBoxLugar.Size = new Size(250, 27);
            textBoxLugar.TabIndex = 9;
            // 
            // textBoxCasa
            // 
            textBoxCasa.Location = new Point(613, 53);
            textBoxCasa.Name = "textBoxCasa";
            textBoxCasa.Size = new Size(250, 27);
            textBoxCasa.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(444, 137);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 11;
            label6.Text = "Tipo de Sangre Mágica";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(444, 101);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 12;
            label7.Text = "Varita Mágica";
            // 
            // textBoxSangre
            // 
            textBoxSangre.Location = new Point(613, 134);
            textBoxSangre.Name = "textBoxSangre";
            textBoxSangre.Size = new Size(250, 27);
            textBoxSangre.TabIndex = 13;
            // 
            // textBoxVarita
            // 
            textBoxVarita.Location = new Point(613, 94);
            textBoxVarita.Name = "textBoxVarita";
            textBoxVarita.Size = new Size(250, 27);
            textBoxVarita.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Brown;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(202, 27);
            label8.TabIndex = 15;
            label8.Text = "Crear Estudiante";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Brown;
            label9.Location = new Point(12, 260);
            label9.Name = "label9";
            label9.Size = new Size(213, 27);
            label9.TabIndex = 16;
            label9.Text = "Listar Estudiantes";
            // 
            // dateTimePickerIng
            // 
            dateTimePickerIng.Location = new Point(174, 166);
            dateTimePickerIng.Name = "dateTimePickerIng";
            dateTimePickerIng.Size = new Size(250, 27);
            dateTimePickerIng.TabIndex = 17;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 207);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(156, 29);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_ClickAsync;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 856);
            Controls.Add(btnAgregar);
            Controls.Add(dateTimePickerIng);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBoxVarita);
            Controls.Add(textBoxSangre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxCasa);
            Controls.Add(textBoxLugar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePickerNac);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNombre);
            Controls.Add(btnCargar);
            Controls.Add(dgvEstudiantes);
            Name = "Form1";
            Text = "Colegio Hogwarts de Magica y Hechiceria";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstudiantes;
        private Button btnCargar;
        private TextBox textBoxNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerNac;
        private Label label4;
        private Label label5;
        private TextBox textBoxLugar;
        private TextBox textBoxCasa;
        private Label label6;
        private Label label7;
        private TextBox textBoxSangre;
        private TextBox textBoxVarita;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePickerIng;
        private Button btnAgregar;
    }
}
