using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PavTpGrupo11.Entidades;

namespace PavTpGrupo11.Formularios
{
    public partial class frmABM_EMPLEADOS : Form
    {
        public frmABM_EMPLEADOS()
        {
            InitializeComponent();
        }

        private void frmABM_EMPLEADOS_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {


        }

        private bool ValidarEmpleado(string nombreEmpleado)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Empleados WHERE Nombre like '" + nombreEmpleado + "'";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreEm", nombreEmpleado);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Equals("")|| txtApellido.Text.Equals("")|| txtCodigoEMPLEADO.Text.Equals(""))
            {
                MessageBox.Show("Ingrese datos");
            }
            else
            {
                string nombreEmpleado = txtNombre.Text;
                string apellidoEmpleado = txtApellido.Text;
                string codigoEmpleado = txtCodigoEMPLEADO.Text;
                bool resultado = false;
                try
                {
                    resultado = ValidarEmpleado(nombreEmpleado);


                    if (resultado == true)
                    {
                        Empleado em = new Empleado();
                    }
                    else
                    {
                        MessageBox.Show("No existe");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al consultar usuario- " + ex.Message);
                }


               
            }
        }
    }
}
