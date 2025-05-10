using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent.Resources {

    public abstract class ResourceBase : JLI.Framework.Data.Models.SoftDeleteModel {

        [Required]
        [FormalNameLength]
        public string Name { get; set; } = null!;

        public bool Disabled { get; set; }

    }
}
