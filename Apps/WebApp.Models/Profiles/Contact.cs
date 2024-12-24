using JLI.Framework.Data;
using JLI.Framework.Data.Attributes.DataAnnotations;
using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Profiles {
    

    public class Contact<TContainer> : ContactInfo {

        public TContainer? Container { get; set; }

    }

    public abstract class ContactInfo : SoftDeleteModel /*, IProfileChild*/ {

        //public Guid ProfileId { get; set; }

        //public Profile? Profile { get; set; }

        [Required, FormalNameLength]
        [Display(Name = "Given Name")]
        public String GivenName { get; set; } = null!;

        [Required, FormalNameLength]
        [Display(Name = "Family Name")]
        public String FamilyName { get; set; } = null!;

        [FormalNameLength]
        public String? Title { get; set; }

        [Required, EmailLength, EmailAddressValidation(false)]
        public String Email { get; set; } = null!;

        [Required, PhoneNumberLength, PhoneNumberValidation(false)]
        [Display(Name = "Phone Number")]
        public String PhoneNumber { get; set; } = null!;

        public Guid? AddressId { get; set; }

        public Common.Address? Address { get; set; } = null;
        
    }

}
