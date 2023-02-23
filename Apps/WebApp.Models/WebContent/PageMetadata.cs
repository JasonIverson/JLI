using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.WebContent.Resources;

namespace WebApp.Models.WebContent {
    public class PageMetadata {

        [Required, StringLength(128)]
        public String Title { get; set; } = null!;

        [Required, StringLength(256)]
        public String Description { get; set; } = null!;

        [Required, StringLength(512)]
        public String Keywords { get; set; } = null!;

    }
}
