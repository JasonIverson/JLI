using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent.Design {

    /// <summary>
    /// Denotes the weight of the font
    /// </summary>
    public enum FontWeights : byte {


        Normal = 0,

        Medium = 1,

        Bold = 2

    }

    public enum LineHeights : byte {

        [Display(Name = "150%")]
        OneHundredFifty = 0,

        [Display(Name = "133%")]
        OneHundredThrityThree = 1

    }

}
