using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.WebContent.Resources {

    // TODO:  Update object model so InjectedContent can reference both PageTemplate and Page
    public class InjectedContent : ResourceBase {

        public ContentTypes Type { get; set; }

        public ContentLocations Location { get; set; }

        public ContentSources Source { get; set; }

        [Required, StringLength(1024)]
        public String Contents { get; set; } = null!;

        public List<Page> Pages { get; set; } = new();

    }
}
