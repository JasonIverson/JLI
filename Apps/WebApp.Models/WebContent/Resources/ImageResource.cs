using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent.Resources {
    
    public class ImageResource : FileResourceBase {

        [StringLength(128)]
        public String? AlternateText { get; set; }

    }

}
