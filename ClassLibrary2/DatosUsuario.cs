using MySql.Data.MySqlClient;
using System;
using CapaEntidades;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary2
{
    public class DatosUsuario
    {
        String conex;
        MySqlConnection conectar;
        DataSet dst;
        MySqlDataAdapter adaptador;

        //void conexion()
        //{
        //    try
        //    {
        //        conex = @"Server=db4free.net; Database=nervsystem; Uid=administrador; Pwd=e8b7e1e4; Port=3306";
        //        conectar = new MySqlConnection(conex);
        //        conectar.Open();
        //        MessageBox.Show("La conexion ha iniciado");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public DataTable DLogin()
        {
            MySqlCommand cmd = new MySqlCommand("SPLogin", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int AgregarUsuarios (EntidadUsuario EL)
        {
            conectar.Open();
            MySqlCommand cmd = new MySqlCommand("AgregarUsuario",conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@cla", EL.IdUsuario));
            cmd.Parameters.Add(new MySqlParameter("@pas", EL.Password));
            int resultado = (int)cmd.ExecuteNonQuery();
            conectar.Close();
            return resultado;

        }

    }
}
