using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLI.Framework.Data;

namespace WebApp.Models.WebContent {
    public class PageTemplateTheme {

        [HexColorLength]
        public String ColorPrimary { get; set; } = null!;

        [HexColorLength]
        public String ColorDark { get; set; } = null!;

        [HexColorLength]
        public String ColorLight { get; set; } = null!;

        [HexColorLength]
        public String ColorRegularText { get; set; } = null!;

        public Design.ColorPairing AlertColors { get; set; } = null!;

        public Design.ColorPairing ErrorColors { get; set; } = null!;

    }
}
