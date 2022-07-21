using EntityKatmani.Abstract;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EntityKatmani.Concrete.Other.RolKismi
{
    public class Rol:IdentityRole
    {
        public Rol(): base()
        {
        }
        public Rol(string rolName) : base(rolName)
        {
        }
    }
}
