using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models.WebContent.Resources {

    // TODO:  Update object model so InjectedContent can reference both PageTemplate and Page
    public class InjectedContent : ResourceBase {

        public ContentTypes Type { get; set; }

        public ContentLocations Location { get; set; }

        public ContentSources Source { get; set; }

        [Required, StringLength(1024)]
        public String Contents { get; set; } = null!;

    }
}
