using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class UserValiditionManager : IUserValiditionService
    {
        public bool validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "Tahir" && gamer.LastName == "Darga" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
