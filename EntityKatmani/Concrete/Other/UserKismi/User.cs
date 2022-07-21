using Microsoft.AspNet.Identity.EntityFramework;

namespace EntityKatmani.Concrete.Other.UserKismi
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public int YearOfBirth { get; set; }
        public bool Gender { get; set; }
    }
}
