using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLI.Framework.Data;

namespace WebApp.Models.WebContent {
    public class PageTemplateTheme {

        [HexColorLength]
        public String ColorPrimary { get; set; } = "4F5165";

        [HexColorLength]
        public String ColorDark { get; set; } = "474044";

        [HexColorLength]
        public String ColorLight { get; set; } = "547AA5";

        [HexColorLength]
        public String ColorRegularText { get; set; } = "293132";

        public Design.FontConfiguration FontRegularText { get; set; } = 
            new Design.FontConfiguration();

        public Design.FontConfiguration FontHeading { get; set; } = 
            new Design.FontConfiguration() {
                LineHeight = Design.LineHeights.OneHundredFifty,
                Size = 32,
                Weight = Design.FontWeights.Bold,
            };

        public Design.FontConfiguration FontSubHeading { get; set; } =
            new Design.FontConfiguration() {
                LineHeight = Design.LineHeights.OneHundredFifty,
                Size = 24,
                Weight = Design.FontWeights.Bold,
            };

        public Design.FontConfiguration FontCaptions { get; set; } =
            new Design.FontConfiguration() {
                Size = 12,
            };

        public Design.ColorPairing AlertColors { get; set; } =
            new Design.ColorPairing() {
                Foreground = "AB421C",
                Background = "FBF6EE"
            };

        public Design.ColorPairing ErrorColors { get; set; } = 
            new Design.ColorPairing() {
                Foreground = "921616",
                Background = "FDDFDF"
            };

    }
}
