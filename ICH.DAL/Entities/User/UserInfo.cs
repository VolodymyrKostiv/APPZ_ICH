using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICH.DAL.Entities.User
{
    public class UserInfo
    {
        [ForeignKey("User")]
        public int UserInfoId { get; set; }
        [MaxLength(50)]
        public string JobTitle { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }    

        public virtual User User { get; set; }
        public virtual CV CV { get; set; }
    }
}
