using System.ComponentModel.DataAnnotations;

namespace ICH.DAL.Entities.User
{
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }
        [MaxLength(20)]
        public string Title { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
