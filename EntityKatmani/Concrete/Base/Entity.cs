using EntityKatmani.Abstract;
using System.ComponentModel.DataAnnotations;

namespace EntityKatmani.Concrete.Base
{
    public class Entity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
