using JLI.Framework.Data.Models;
using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Profiles {

    public class Profile : SoftDeleteModel {

        [Required, FormalNameLength]
        public string Name { get; set; } = null!;

        [Display(Name = "Social Media Accounts")]
        public List<SocialMediaAccount> SocialMediaAccounts { get; set; } = new();

        public Contact PrimaryContact { get; set; } = new();

    }

}
