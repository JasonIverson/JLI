using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data.Models.Accounts {
    public class Organization : ModelBase {

        [StringLength(64)]
        [Required]
        public String Name { get; set; }

    }
}
