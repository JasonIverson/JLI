using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models.WebContent.Design {

    public class FontConfiguration {

        public byte Size { get; set; }

        public String Name { get; set; } = null!;

        public FontWeights Weight { get; set; } = FontWeights.Normal;

        public LineHeights LineHeight { get; set; } = LineHeights.OneHundredThrityThree;

    }

}
