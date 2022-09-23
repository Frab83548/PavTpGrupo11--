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

namespace PavTpGrupo11.Formularios
{
    public partial class Registrar_Empleado : Form
    {
        public Registrar_Empleado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    /*    private bool ValidarEmpleado(string nombreEmpleado)
        {
            bool resultado = false;
      
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);


            string consulta = "SELECT * FROM Empleados WHERE Nombre like '"+ nombreEmpleado+"'";

            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            if(tabla.Rows.Count == 1)
            {
                resultado = true;
            }

            return resultado;
        }
    */
        private void Registrar_Empleado_Load(object sender, EventArgs e)
        {

        }
    }
}
