using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApp.Models.WebContent {
    public class PageTemplateMetadata {

        [Display(Name = "Character Set")]
        public String CharSet => "utf-8";

        [Display(Name = "Language")]
        public String Language => "en-US";

        public String Viewport => "width=device-width, initial-scale=1.0";

    }
}
