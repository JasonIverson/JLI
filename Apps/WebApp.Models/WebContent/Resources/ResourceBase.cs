using System.ComponentModel.DataAnnotations;
using JLI.Framework.Data;

namespace WebApp.Models.WebContent.Resources {
    
    public abstract class ResourceBase : JLI.Framework.Data.Models.SoftDeleteModel {

        [Required]
        [FormalNameLength]
        public String Name { get; set; } = null!;

        public bool Disabled { get; set; }

    }
}
