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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker2 = new DateTimePicker();
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
            // textBox1
            // 
            textBox1.Location = new Point(174, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 2;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(174, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
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
            // textBox2
            // 
            textBox2.Location = new Point(174, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(613, 53);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 10;
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
            // textBox4
            // 
            textBox4.Location = new Point(613, 134);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(613, 94);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 27);
            textBox5.TabIndex = 14;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(174, 166);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 856);
            Controls.Add(dateTimePicker2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker2;
    }
}
