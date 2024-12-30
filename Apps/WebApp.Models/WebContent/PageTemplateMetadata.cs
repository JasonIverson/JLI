using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent {
    public class PageTemplateMetadata : Model {

        [Display(Name = "Character Set")]
        public String CharSet => "utf-8";

        [Display(Name = "Language")]
        public String Language => "en-US";

        public String Viewport => "width=device-width, initial-scale=1.0";

    }
}
