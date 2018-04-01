using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myPetShop.Models.DataAccess;
using MySql.Data.MySqlClient;

namespace myPetShop.Models
{
    public class AddPetProcedure
    {
        public bool addPet(string name, string owner, string sex, int type)
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { name = "_name", value = name});
            parametros.Add(new Parametro() { name = "_owner", value = owner });
            parametros.Add(new Parametro() { name = "_sex", value = sex });
            parametros.Add(new Parametro() { name = "_type", value = type.ToString() });

            MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("addPet", parametros);
            if (reader.Read())
            {
                return true;
            }
            else{
                return true;
            }
        }
    }
}
