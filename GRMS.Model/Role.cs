using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMS.Model
{
    [Table("Role")]
    public partial class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
