using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models.WebContent.Resources {
    
    public abstract class ResourceBase : JLI.Framework.Data.Models.SoftDeleteModel {

        public bool Disabled { get; set; }

    }
}
