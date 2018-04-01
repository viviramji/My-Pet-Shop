using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPetShop.Models
{
    public class ModelFacade
    {
        public bool CheckAdd(string name, string owner, string sex, int type)
        {
            return new AddPetProcedure().addPet(name, owner, sex, type);
        }
        public List<string>[] SelectAllPets()
        {
            return new SelectPetsProcedure().selectPetsProcedure();
        }
    }
}
