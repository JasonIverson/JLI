using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent {
    public class PageMetadata : Model {

        [Required, StringLength(128)]
        public String Title { get; set; } = null!;

        [Required, StringLength(256)]
        public String Description { get; set; } = null!;

        [Required, StringLength(512)]
        public String Keywords { get; set; } = null!;

    }
}
