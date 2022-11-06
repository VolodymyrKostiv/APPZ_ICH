using System.ComponentModel.DataAnnotations.Schema;

namespace ICH.DAL.Entities.User
{
    public class CV
    {
        [ForeignKey("UserInfo")]
        public int CVId { get; set; }
        public string Path { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
