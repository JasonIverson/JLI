using JLI.Framework.Data;
using JLI.Framework.Data.Attributes.DataAnnotations;
using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Profiles {

    public class Contact : SoftDeleteModel {

        [Required, FormalNameLength]
        [Display(Name = "Given Name")]
        public string GivenName { get; set; } = null!;

        [Required, FormalNameLength]
        [Display(Name = "Family Name")]
        public string FamilyName { get; set; } = null!;

        [FormalNameLength]
        public string? Title { get; set; }

        [Required, EmailLength, EmailAddressValidation(false)]
        public string Email { get; set; } = null!;

        [PhoneNumberLength, PhoneNumberValidation(true)]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }

    }

}
