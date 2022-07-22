using Library;
using Microsoft.EntityFrameworkCore;
using VeriErisimKatmani.Concrete.EntityFramework;

namespace KonusarakOgrenWeb.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddContexts(this IServiceCollection collection)
        {
            collection.AddDbContext<EfDbContext>(op=> {
                op.UseSqlServer(ConnectionStrings.get.DataConnection, opt => opt.EnableRetryOnFailure(maxRetryCount: 10));
            });
            collection.AddDbContext<EfIdendityDbContext>(op => {
                op.UseSqlServer(ConnectionStrings.get.DefaultConnection, opt => opt.EnableRetryOnFailure(maxRetryCount: 10));
            });
        }
    }
}
