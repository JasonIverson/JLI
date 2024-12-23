using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Profiles {

    public class SocialMediaAccount : OrderedModel /*, IProfileChild*/ {

        //public Guid ProfileId { get; set; }

        //public Profile? Profile { get; set; }

        public SocialMediaPlatforms Platform { get; set; }

        [Display(Name = "User Name")]
        public String UserName { get; set; } = null!;

    }

}
