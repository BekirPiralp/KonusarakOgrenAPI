
using EntityKatmani.Concrete.Other.RolKismi;
using EntityKatmani.Concrete.Other.UserKismi;
using Library;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.get.DataConnection, opt => opt.EnableRetryOnFailure(maxRetryCount: 10));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
