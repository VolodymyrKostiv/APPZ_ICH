using ICH.DAL.Entities.General;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICH.DAL.Entities.User
{
    public class UserInfo
    {
        public int UserInfoId { get; set; }
        public string? Description { get; set; }    
        public Location? Location { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
