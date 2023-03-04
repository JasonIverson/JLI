using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent {

    public class PageTemplateTheme {

        [Required, HexColorLength]
        [Display(Name = "Color (Primary)")]
        public String ColorPrimary { get; set; } = "4F5165";
        
        [Required, HexColorLength]
        [Display(Name = "Color (Dark)")]
        public String ColorDark { get; set; } = "474044";

        [Required, HexColorLength]
        [Display(Name = "Color (Light)")]
        public String ColorLight { get; set; } = "547AA5";

        [Required, HexColorLength]
        [Display(Name = "Color (Regular Text)")]
        public String ColorRegularText { get; set; } = "293132";

        [Display(Name = "Font (Regular Text)")]
        public Design.FontConfiguration FontRegularText { get; set; } = 
            new Design.FontConfiguration();

        [Display(Name = "Font (Headings)")]
        public Design.FontConfiguration FontHeading { get; set; } = 
            new Design.FontConfiguration() {
                LineHeight = Design.LineHeights.OneHundredFifty,
                Size = 32,
                Weight = Design.FontWeights.Bold,
            };

        [Display(Name = "Font (Sub-Headings)")]
        public Design.FontConfiguration FontSubHeading { get; set; } =
            new Design.FontConfiguration() {
                LineHeight = Design.LineHeights.OneHundredFifty,
                Size = 24,
                Weight = Design.FontWeights.Bold,
            };

        [Display(Name = "Font (Caption)")]
        public Design.FontConfiguration FontCaptions { get; set; } =
            new Design.FontConfiguration() {
                Size = 12,
            };

        [Display(Name = "Alert Colors")]
        public Design.ColorPairing AlertColors { get; set; } =
            new Design.ColorPairing() {
                Foreground = "AB421C",
                Background = "FBF6EE"
            };

        [Display(Name = "Error Colors")]
        public Design.ColorPairing ErrorColors { get; set; } = 
            new Design.ColorPairing() {
                Foreground = "921616",
                Background = "FDDFDF"
            };

    }
}
