using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Gamer:IEntity 
    {
        public Gamer(int id,string firstName,string lastName,DateTime birthYear,long identityNumber)
        {
            Id= id;
            FirstName= firstName;
            LastName= lastName;
            BirthYear= birthYear;
            IdentityNumber= identityNumber;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthYear { get; set; }
        public long IdentityNumber { get; set; }

    }
}
