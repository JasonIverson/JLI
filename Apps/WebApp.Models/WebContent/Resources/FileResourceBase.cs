using JLI.Framework.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models.WebContent.Resources {
    
    public abstract class FileResourceBase : ResourceBase {

        [Required, UrlLength]
        public String Url { get; set; } = null!;

    }

}
