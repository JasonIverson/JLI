using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using JLI.Framework.Data;

namespace WebApp.Data.Models {
    public class WebAppUser : IdentityUser<Guid> {

        public Guid OrganizationId { get; set; }

        public Account? Organization { get; set; }

        [Required]
        [FormalNameLength]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [FormalNameLength]
        public string LastName { get; set; } = string.Empty;

    }
}
