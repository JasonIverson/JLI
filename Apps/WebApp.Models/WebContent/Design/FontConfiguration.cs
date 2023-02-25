using JLI.Framework.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models.WebContent.Design {

    public class FontConfiguration {

        [Range(6, 128)]
        public byte Size { get; set; } = 16;

        [Required, FormalNameLength]
        public String Name { get; set; } = "Roboto";

        public FontWeights Weight { get; set; } = FontWeights.Normal;

        public LineHeights LineHeight { get; set; } = LineHeights.OneHundredThrityThree;

    }

}
