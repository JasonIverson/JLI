using JLI.Framework.Data;
using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;
using WebApp.Models.WebContent.Resources;

namespace WebApp.Models.WebContent {
    
    public class Page : SoftDeleteModel {

        [Required, FormalNameLength]
        public String Name { get; set; } = "New Page";

        public Guid TemplateId { get; set; } = Guid.Empty!;

        public PageTemplate Template { get; set; } = null!;

        public PageMetadata Metadata { get; set; } = new PageMetadata();

        public InjectedContentList InjectedContent { get; set; } = new InjectedContentList();

    }
}
