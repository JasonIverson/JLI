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
        public String FirstName { get; set; } = String.Empty;

        [Required]
        [FormalNameLength]
        public String LastName { get; set; } = String.Empty;

    }
}
