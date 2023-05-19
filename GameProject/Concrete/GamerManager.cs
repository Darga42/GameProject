using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        UserValiditionManager _userValiditionManager;

        public GamerManager(UserValiditionManager userValiditionManager)
        {
            _userValiditionManager = userValiditionManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValiditionManager.validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" Adlı oyuncu eklendi");
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi bilgilerinizi kontrol ediniz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi");
        }
    }
}
