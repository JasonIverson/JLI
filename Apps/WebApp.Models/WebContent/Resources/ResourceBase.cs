using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLI.Framework.Data;

namespace WebApp.Models.WebContent.Resources {
    
    public abstract class ResourceBase : JLI.Framework.Data.Models.SoftDeleteModel {

        [Required]
        [FormalNameLength]
        public String Name { get; set; } = null!;

        public bool Disabled { get; set; }

    }
}
