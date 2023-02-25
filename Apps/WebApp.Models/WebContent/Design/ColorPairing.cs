using JLI.Framework.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models.WebContent.Design {
    public class ColorPairing {

        [Required, HexColorLength, HexColorValidation(false)]
        public string Background { get; set; } = null!;

        [Required, HexColorLength, HexColorValidation(false)]
        public string Foreground { get; set; } = null!;

    }
}
