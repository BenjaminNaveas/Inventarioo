using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudMYSQLCsharp.Clases
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "inventarioo";
        static string usuario = "root";
        static string password = "root";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";



        public MySqlConnection establecerConexion()
        {

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                //MessageBox.Show("Se conecto a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Se conecto a la base de datos, error:" + ex.ToString());
            }
            return conex;

        }

        public void cerrarConexion()
        {
            conex.Close();

        }
    }
}
