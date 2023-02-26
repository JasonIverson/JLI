using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent.Design {
    public class ColorPairing {

        [Required, HexColorLength, HexColorValidation(false)]
        public String Background { get; set; } = null!;

        [Required, HexColorLength, HexColorValidation(false)]
        public String Foreground { get; set; } = null!;

    }
}
