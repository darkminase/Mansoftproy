using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaProfesor winProfesor = new ventanaProfesor();
            winProfesor.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaAlumno winalumno = new ventanaAlumno();
            winalumno.Show();
        }

        private void directorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaDirector winDirector = new ventanaDirector();
            winDirector.Show();
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Desea Salir", "Mensaje", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Close();
            }
            
            else
            {
               
            }
 
        }
    }
}
