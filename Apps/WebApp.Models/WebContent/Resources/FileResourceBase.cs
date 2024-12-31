using JLI.Framework.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent.Resources {
    
    public abstract class FileResourceBase : ResourceBase {

        [Required, UrlLength]
        public string Url { get; set; } = null!;

    }

}
