using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenP.ConexionPGADMIN
{
    public class ConexionPG
    {
        //creamos la conexion a la bd   con la ayuda de la extension NPGSQL
        NpgsqlConnection conex= new NpgsqlConnection();
        static string servidor = "localhost";
        static string bd= "CooperativaExamen";
        static string usuario="postgres";
        static string password="panas";
        static string puerto = "5432";

    
        
        String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        
        public NpgsqlConnection establecerConexion()
        {

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conectó correctamente a la Base de datos");

            }

            catch (NpgsqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos de PostgreSQL, error: " + e.ToString());

            }

            return conex;
        }



    }


}
