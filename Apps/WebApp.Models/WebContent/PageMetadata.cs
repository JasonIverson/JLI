using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent {
    public class PageMetadata : Model {

        [Required, StringLength(128)]
        public string Title { get; set; } = null!;

        [Required, StringLength(256)]
        public string Description { get; set; } = null!;

        [Required, StringLength(512)]
        public string Keywords { get; set; } = null!;

    }
}
