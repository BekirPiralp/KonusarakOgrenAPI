using EntityKatmani.Abstract;
using Microsoft.AspNetCore.Identity;

namespace EntityKatmani.Concrete.Other.UserKismi
{
    public class User : IdentityUser<int>,IEntity
    {
        public int MarkaId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public int YearOfBirth { get; set; }
        public bool Gender { get; set; }
    }
}
