﻿using JLI.Framework.Data.Models;
using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Profiles {

    public class Profile : SoftDeleteModel {

        [Required, FormalNameLength]
        public String Name { get; set; } = null!;

        public List<SocialMediaAccount> SocialMediaAccounts { get; set;}
            = new List<SocialMediaAccount>();

        public Guid PrimaryContactId { get; set; }

        public Contact PrimaryContact { get; set; } = null!;

    }

}