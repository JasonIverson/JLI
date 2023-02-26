using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent.Resources {
    
    public abstract class FileResourceBase : ResourceBase {

        [Required, UrlLength]
        public String Url { get; set; } = null!;

    }

}
