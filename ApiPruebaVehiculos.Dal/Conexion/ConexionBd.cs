using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ApiPruebaVehiculos;

namespace ApiPruebaVehiculos.Dal.Conexion
{
    public class ConexionBd
    {    

        private string CadenaConexion()
        {
            string conexionstr;
            conexionstr = string.Empty;
            conexionstr = conexionstr = "Data Source=SERVER-M;Initial Catalog = PRUEBAAUTOS;Persist Security Info=True;User Id=sa; Password=123456;MultipleActiveResultSets=True";
            return conexionstr ;
        }
        public DataTable GetDatos(string consulta)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlConnection oConexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                oConexion.ConnectionString = CadenaConexion();
                cmd.CommandText = consulta;
                cmd.Connection = oConexion;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                oConexion.Close();
                return dt;
            }
            catch
            {
                return dt;
            }
        }

        public bool SaveData(string consulta)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlConnection oConexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                oConexion.ConnectionString = CadenaConexion();
                cmd.CommandText = consulta;
                cmd.Connection = oConexion;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                oConexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
