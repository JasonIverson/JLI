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

        [HexColorLength]
        public String ColorAlertBackground { get; set; } = null!;

        [HexColorLength]
        public String ColorAlertForeground { get; set; } = null!;

        [HexColorLength]
        public String ColorErrorBackground { get; set; } = null!;

        [HexColorLength]
        public String ColorErrorForeground { get; set; } = null!;

    }
}
