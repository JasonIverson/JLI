using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent.Design {
    public class ColorPairing {

        [Required, HexColorLength, HexColorValidation(false)]
        public string Background { get; set; } = null!;

        [Required, HexColorLength, HexColorValidation(false)]
        public string Foreground { get; set; } = null!;

    }
}
