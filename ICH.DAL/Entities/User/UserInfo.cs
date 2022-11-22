using ICH.DAL.Entities.General;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICH.DAL.Entities.User
{
    public class UserInfo
    {
        [ForeignKey("User")]
        public int UserInfoId { get; set; }
        public string? Description { get; set; }    
        public Location? Location { get; set; }
        public virtual User User { get; set; }
        public virtual CV CV { get; set; }
    }
}
