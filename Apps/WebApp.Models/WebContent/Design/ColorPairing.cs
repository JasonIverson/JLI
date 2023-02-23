using JLI.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models.WebContent.Design {
    public class ColorPairing {

        [HexColorLength]
        public string Background { get; set; } = null!;

        [HexColorLength]
        public string Foreground { get; set; } = null!;

    }
}
