using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models.WebContent.Resources {
    
    public enum ContentLocations : byte {

        [Display(Name = "Head Tag")]
        Head = 0,

        [Display(Name = "Opening Body Tag")]
        OpeningBody = 1,

        [Display(Name = "Closing Body Tag")]
        ClosingBody = 2,

    }

    public enum ContentSources : byte {

        Url = 0,

        Text = 1,

    }

    public enum ContentTypes : byte {

        Script = 0,

        [Display(Name = "Style Sheet")]
        StyleSheet = 1,

    }

}
