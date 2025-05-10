using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent.Resources {

    public class ImageResource : FileResourceBase {

        [StringLength(128)]
        [Display(Name = "Alternate Text")]
        public string? AlternateText { get; set; }

    }

}
