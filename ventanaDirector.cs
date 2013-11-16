using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace MenuPrincipal
{
    public partial class ventanaDirector : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader Dr;
        SqlDataAdapter Da;
        DataSet Ds;
        string cadena = "Data Source=(local);Initial Catalog=MantencionSoftware;Integrated Security=True";
        public ventanaDirector()
        {
            InitializeComponent();
        }

        private void slcAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection oCon = new SqlConnection(cadena);
                SqlCommand oCom = new SqlCommand();
                oCon.Open();
                oCom.Connection = oCon;
                oCom.CommandText = "insert into Profesor values ('" + txtRutProfesor.Text + "','" + txtClaveProfesor.Text + "','" + txtNombreProfesor.Text + "','" + txtEdadProfesor.Text + "','" + txtDireccionProfesor.Text + "','" + txtFonoProfesor.Text + "','" + txtEmailProfesor.Text + "','" + cmbAsignatura.Text + "')";
                ;

                if (oCom.ExecuteNonQuery() > 0 )
                {
                    MessageBox.Show("Datos Ingresados");
                }
                if((oCom.CommandText = "select RutProfesor from profesor where RutProfesor='" +txtRutProfesor.Text+"'") == txtRutProfesor.Text )
                {
                    MessageBox.Show("Problemas al ingresar datos");
                }

                oCon.Close();
                oCom.Dispose();
                oCon.Dispose();

                
            }
            catch (SqlException ex)
            {

                MessageBox.Show("El error es: " + ex.Message);
            }

                




                
           
        }
    }
}
