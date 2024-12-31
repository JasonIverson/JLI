using System;
using JLI.Framework.Core;
using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebApp.Data.Models {
    public class Account : JLI.Framework.Data.Models.Model {

        [Required]
        [FormalNameLength]
        public string Name { get; set; } = string.Empty;

        public List<WebAppUser> Users { get; set; } = new();

    }
}
