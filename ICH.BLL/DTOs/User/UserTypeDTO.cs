using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICH.BLL.DTOs.User
{
    public class UserTypeDTO
    {
        public int UserTypeId { get; set; }
        public string Title { get; set; }
        public ICollection<UserDTO> Users { get; set; }
    }
}
