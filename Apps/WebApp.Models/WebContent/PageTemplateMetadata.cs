using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent {
    public class PageTemplateMetadata : Model {

        [Display(Name = "Character Set")]
        public string CharSet => "utf-8";

        [Display(Name = "Language")]
        public string Language => "en-US";

        public string Viewport => "width=device-width, initial-scale=1.0";

    }
}
