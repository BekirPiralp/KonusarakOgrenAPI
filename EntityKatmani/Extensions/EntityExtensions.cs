using EntityKatmani.Abstract;

namespace EntityKatmani.Extensions
{
    public static class EntityExtensions
    {
        public static bool isNull (this IEntity entity)
        {
            return entity == null;
        }

        public static bool isNotNull(this IEntity entity)
        {
            return entity != null;
        }

      
        public static bool isEmpity(this IEntity entity)
        {
            return isNotNull(entity) && entity.Id <= 0;
        }

        public static bool isNotEmpity(this IEntity entity)
        {
            return isNotNull(entity) && entity.Id > 0;
        }
    }
}
