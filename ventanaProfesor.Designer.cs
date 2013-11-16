namespace MenuPrincipal
{
    partial class ventanaProfesor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.slcNotas = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificarRut = new System.Windows.Forms.Button();
            this.slcAsistencia = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.slcNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.slcAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.slcNotas);
            this.tabControl1.Controls.Add(this.slcAsistencia);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // slcNotas
            // 
            this.slcNotas.Controls.Add(this.button3);
            this.slcNotas.Controls.Add(this.button2);
            this.slcNotas.Controls.Add(this.dataGridView1);
            this.slcNotas.Controls.Add(this.comboBox1);
            this.slcNotas.Controls.Add(this.label3);
            this.slcNotas.Controls.Add(this.btnVerificarRut);
            this.slcNotas.Location = new System.Drawing.Point(4, 25);
            this.slcNotas.Name = "slcNotas";
            this.slcNotas.Padding = new System.Windows.Forms.Padding(3);
            this.slcNotas.Size = new System.Drawing.Size(923, 532);
            this.slcNotas.TabIndex = 0;
            this.slcNotas.Text = "Notas ";
            this.slcNotas.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Agregar Notas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Modificar Notas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 349);
            this.dataGridView1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(294, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre Alumno:";
            // 
            // btnVerificarRut
            // 
            this.btnVerificarRut.Location = new System.Drawing.Point(468, 23);
            this.btnVerificarRut.Name = "btnVerificarRut";
            this.btnVerificarRut.Size = new System.Drawing.Size(130, 23);
            this.btnVerificarRut.TabIndex = 20;
            this.btnVerificarRut.Text = "Aceptar";
            this.btnVerificarRut.UseVisualStyleBackColor = true;
            // 
            // slcAsistencia
            // 
            this.slcAsistencia.Controls.Add(this.button5);
            this.slcAsistencia.Controls.Add(this.dataGridView2);
            this.slcAsistencia.Controls.Add(this.comboBox2);
            this.slcAsistencia.Controls.Add(this.label1);
            this.slcAsistencia.Controls.Add(this.button1);
            this.slcAsistencia.Location = new System.Drawing.Point(4, 25);
            this.slcAsistencia.Name = "slcAsistencia";
            this.slcAsistencia.Padding = new System.Windows.Forms.Padding(3);
            this.slcAsistencia.Size = new System.Drawing.Size(923, 532);
            this.slcAsistencia.TabIndex = 1;
            this.slcAsistencia.Text = "Asistencia";
            this.slcAsistencia.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 431);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Agregar Asistencia";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(894, 349);
            this.dataGridView2.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(294, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre Alumno:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(789, 598);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ventanaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 646);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Name = "ventanaProfesor";
            this.Text = "ventanaProfesor";
            this.tabControl1.ResumeLayout(false);
            this.slcNotas.ResumeLayout(false);
            this.slcNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.slcAsistencia.ResumeLayout(false);
            this.slcAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage slcNotas;
        private System.Windows.Forms.TabPage slcAsistencia;
        private System.Windows.Forms.Button btnVerificarRut;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}