
using EntityKatmani.Concrete.Other.RolKismi;
using EntityKatmani.Concrete.Other.UserKismi;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VeriErisimKatmani.Concrete.EntityFramework
{
    public class EfIdendityDbContext : IdentityDbContext<User,Rol,int>
    {
        public EfIdendityDbContext():base()
        {

        }

        public EfIdendityDbContext(DbContextOptions<EfIdendityDbContext> options) : 
            base(options)
        {

        }

        DbSet<Rol> Roller { get; set;}
        DbSet<User> Users { get; set;}
    }
}
