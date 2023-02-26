using JLI.Framework.Data.Models;
using WebApp.Models.Profiles;
using WebApp.Models.WebContent.Resources;

namespace WebApp.Models.WebContent {

    public class PageTemplate : SoftDeleteModel, IProfileChild {

        public Guid ProfileId { get; set; }

        public Profile? Profile { get; set; }

        public ImageResource? FavIcon { get; set; }

        public InjectedContentList InjectedContent { get; set; } = new InjectedContentList();

        public PageTemplateMetadata Metadata { get; set; } = new PageTemplateMetadata();

        public PageTemplateTheme Theme { get; set; } = new PageTemplateTheme();

    }
}
