namespace MenuPrincipal
{
    partial class ventanaAlumno
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
            this.slcNotas = new System.Windows.Forms.TabControl();
            this.slcnotasAlumno = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.slcAsistenciaAlumno = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbNomAlumno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.slcHorarioAlumno = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.slcNotas.SuspendLayout();
            this.slcnotasAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.slcAsistenciaAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.slcHorarioAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // slcNotas
            // 
            this.slcNotas.Controls.Add(this.slcnotasAlumno);
            this.slcNotas.Controls.Add(this.slcAsistenciaAlumno);
            this.slcNotas.Controls.Add(this.slcHorarioAlumno);
            this.slcNotas.Location = new System.Drawing.Point(16, 74);
            this.slcNotas.Name = "slcNotas";
            this.slcNotas.SelectedIndex = 0;
            this.slcNotas.Size = new System.Drawing.Size(927, 392);
            this.slcNotas.TabIndex = 0;
            // 
            // slcnotasAlumno
            // 
            this.slcnotasAlumno.Controls.Add(this.dataGridView1);
            this.slcnotasAlumno.Location = new System.Drawing.Point(4, 25);
            this.slcnotasAlumno.Name = "slcnotasAlumno";
            this.slcnotasAlumno.Padding = new System.Windows.Forms.Padding(3);
            this.slcnotasAlumno.Size = new System.Drawing.Size(919, 363);
            this.slcnotasAlumno.TabIndex = 0;
            this.slcnotasAlumno.Text = "Notas";
            this.slcnotasAlumno.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // slcAsistenciaAlumno
            // 
            this.slcAsistenciaAlumno.Controls.Add(this.dataGridView2);
            this.slcAsistenciaAlumno.Location = new System.Drawing.Point(4, 25);
            this.slcAsistenciaAlumno.Name = "slcAsistenciaAlumno";
            this.slcAsistenciaAlumno.Padding = new System.Windows.Forms.Padding(3);
            this.slcAsistenciaAlumno.Size = new System.Drawing.Size(919, 363);
            this.slcAsistenciaAlumno.TabIndex = 1;
            this.slcAsistenciaAlumno.Text = "Asistencia";
            this.slcAsistenciaAlumno.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(867, 323);
            this.dataGridView2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbNomAlumno
            // 
            this.cmbNomAlumno.FormattingEnabled = true;
            this.cmbNomAlumno.Location = new System.Drawing.Point(340, 35);
            this.cmbNomAlumno.Name = "cmbNomAlumno";
            this.cmbNomAlumno.Size = new System.Drawing.Size(157, 24);
            this.cmbNomAlumno.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre Alumno:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(514, 36);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 23);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // slcHorarioAlumno
            // 
            this.slcHorarioAlumno.Controls.Add(this.label21);
            this.slcHorarioAlumno.Controls.Add(this.label20);
            this.slcHorarioAlumno.Controls.Add(this.label19);
            this.slcHorarioAlumno.Controls.Add(this.label18);
            this.slcHorarioAlumno.Controls.Add(this.label17);
            this.slcHorarioAlumno.Controls.Add(this.dataGridView7);
            this.slcHorarioAlumno.Controls.Add(this.dataGridView6);
            this.slcHorarioAlumno.Controls.Add(this.dataGridView5);
            this.slcHorarioAlumno.Controls.Add(this.dataGridView4);
            this.slcHorarioAlumno.Controls.Add(this.dataGridView3);
            this.slcHorarioAlumno.Location = new System.Drawing.Point(4, 25);
            this.slcHorarioAlumno.Name = "slcHorarioAlumno";
            this.slcHorarioAlumno.Size = new System.Drawing.Size(919, 363);
            this.slcHorarioAlumno.TabIndex = 2;
            this.slcHorarioAlumno.Text = "Horario";
            this.slcHorarioAlumno.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(708, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 17);
            this.label21.TabIndex = 35;
            this.label21.Text = "Viernes";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(558, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 17);
            this.label20.TabIndex = 34;
            this.label20.Text = "Jueves";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(397, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "Miercoles";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(254, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "Martes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(98, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Lunes";
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(667, 53);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.Size = new System.Drawing.Size(148, 251);
            this.dataGridView7.TabIndex = 30;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(513, 53);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(148, 251);
            this.dataGridView6.TabIndex = 29;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(359, 53);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(148, 251);
            this.dataGridView5.TabIndex = 28;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(205, 53);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(148, 251);
            this.dataGridView4.TabIndex = 27;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(51, 53);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(148, 251);
            this.dataGridView3.TabIndex = 26;
            // 
            // ventanaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 585);
            this.Controls.Add(this.cmbNomAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.slcNotas);
            this.Name = "ventanaAlumno";
            this.Text = "ventanaAlumno";
            this.slcNotas.ResumeLayout(false);
            this.slcnotasAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.slcAsistenciaAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.slcHorarioAlumno.ResumeLayout(false);
            this.slcHorarioAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl slcNotas;
        private System.Windows.Forms.TabPage slcnotasAlumno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage slcAsistenciaAlumno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbNomAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TabPage slcHorarioAlumno;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}