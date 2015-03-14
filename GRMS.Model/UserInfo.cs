using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMS.Model
{
    [Table("UserInfo")]
    public partial class UserInfo
    {
        public int Id { get; set; }
        public string UName { get; set; }
        public string Pwd { get; set; }
    }
}
