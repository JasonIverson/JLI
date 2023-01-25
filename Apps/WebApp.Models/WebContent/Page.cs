using JLI.Framework.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.WebContent.Resources;

namespace WebApp.Models.WebContent {
    
    public class Page {

        [Required, FormalNameLength]
        public String Name { get; set; } = "New Page";

        public Guid TemplateId { get; set; } = Guid.Empty!;

        public PageTemplate Template { get; set; } = null!;

        public PageMetadata Metadata { get; set; } = new PageMetadata();

        public List<InjectedContent> EmbeddedContent { get; set; } = new List<InjectedContent>();

    }
}
