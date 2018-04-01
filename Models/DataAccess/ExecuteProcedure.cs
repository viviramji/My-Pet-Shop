using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace myPetShop.Models.DataAccess
{
    public class ExecuteProcedure
    {
        static string ConnStr = "server=204.93.216.11;user=ivanbano_grupo7;database=ivanbano_grupo7;port=3306;password=grupo7";
        static MySqlConnection conn = null;

        static public MySqlDataReader executeStoreProcedure(string nombre, List<Parametro> parametros)
        {
            conn = new MySqlConnection(ConnStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(nombre, conn); //nombre del procedure y connection !!
            cmd.CommandType = System.Data.CommandType.StoredProcedure; //tipo de comando a ejecutar ¡un SP!
            foreach (Parametro p in parametros)
            {
                cmd.Parameters.AddWithValue("@"+ p.name, p.value);
            }
            return cmd.ExecuteReader();
        }

        static public MySqlDataReader ExecuteSPWithoutParameters(string name)
        {
            conn = new MySqlConnection(ConnStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(name, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            return cmd.ExecuteReader();
        }

    }
}
