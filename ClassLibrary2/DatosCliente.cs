using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using CapaEntidades;

namespace ClassLibrary2
{
    public class DatosCliente
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
        
        public int AgregarCliente(EntidadCliente EC)
        {
            conectar.Open();
            MySqlCommand cmd = new MySqlCommand("AgregarCliente", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@cla", EC.Clave_Cliente));
            cmd.Parameters.Add(new MySqlParameter("@nom", EC.Nombre_Cliente));
            cmd.Parameters.Add(new MySqlParameter("@tel", EC.Telefono_Cliente));
            int resultado = (int)cmd.ExecuteNonQuery();
            conectar.Close();
            return resultado;

        }

    }
}

