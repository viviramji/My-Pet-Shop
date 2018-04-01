using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Threading.Tasks;
using myPetShop.Models.DataAccess;

namespace myPetShop.Models
{
    public class SelectPetsProcedure
    {
        public List<string>[] selectPetsProcedure()
        {
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>(); //PetID
            list[1] = new List<string>(); //Name
            list[2] = new List<string>(); //owner
            list[3] = new List<string>(); //nameType
            MySqlDataReader reader = ExecuteProcedure.ExecuteSPWithoutParameters("SelectAllPets");

            while (reader.Read())
            {
                list[0].Add(reader["PetID"] + "");
                list[1].Add(reader["Name"] + "");
                list[2].Add(reader["owner"] + "");
                list[3].Add(reader["nameType"] + "");
            }
            return list;
        }
    }
}
