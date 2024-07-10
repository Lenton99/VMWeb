using System.ComponentModel.DataAnnotations.Schema;

namespace VMWeb.Components.Models
{
    [Table("T_Employee")]
    public class UserDataBase
    {
        public int Record_Id { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }
    }
}
