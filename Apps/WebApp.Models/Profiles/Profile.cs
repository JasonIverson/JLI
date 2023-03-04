using JLI.Framework.Data.Models;
using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Profiles {

    public class Profile : SoftDeleteModel {

        [Required, FormalNameLength]
        public String Name { get; set; } = null!;

        [Display(Name = "Social Media Accounts")]
        public List<SocialMediaAccount> SocialMediaAccounts { get; set; } = new();

        public Guid PrimaryContactId { get; set; }

        [Display(Name = "Primary Contact")]
        public Contact PrimaryContact { get; set; } = null!;

    }

}
