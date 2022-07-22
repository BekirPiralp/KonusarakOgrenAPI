using System.ComponentModel.DataAnnotations;

namespace EntityKatmani.Abstract
{
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
    }
}
