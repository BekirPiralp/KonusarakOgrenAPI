using Library;

namespace KonusarakOgrenWeb.Extensions
{
    public static class ConfigurationManagerExtensions
    {
        public static void CreateConnetionStrings(this ConfigurationManager manager)
        {
           ConnectionStrings.get.DefaultConnection = manager.GetConnectionString("DefaultConnection");
           ConnectionStrings.get.DataConnection = manager.GetConnectionString("DataConnection");
        }
    }
}
