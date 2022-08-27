using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace JLI.Framework.Data.Models.Accounts {

    public class User : Model {

        public override Guid Id {
            get => base.Id;
            set {
                base.Id = value;
                this.IdentityUserId = base.Id;
            }
        }

        public Guid IdentityUserId { get; set; }

        public IdentityUser<Guid> Account { get; set; }

        [StringLength(64)]
        [Required]
        public String DisplayName { get; set; }

        [StringLength(32)]
        [Required]
        public String FirstName { get; set; }

        [StringLength(32)]
        [Required]
        public String LastName { get; set; }

    }
}
