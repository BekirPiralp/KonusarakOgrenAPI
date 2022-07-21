
using EntityKatmani.Concrete.Other.RolKismi;
using EntityKatmani.Concrete.Other.UserKismi;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace VeriErisimKatmani.Concrete.EntityFramework
{
    public class EfIdendityDbContext : IdentityDbContext
    {
        public EfIdendityDbContext():base()
        {

        }

        #region Rol kısmı
        public DbSet<Rol> Roller { get; set; }
        #endregion

        #region User kısmı
        public DbSet<User> Markalar { get; set; }
        #endregion
    }
}
