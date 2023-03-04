using System.ComponentModel.DataAnnotations;
using JLI.Framework.Data.Models;
using WebApp.Models.Profiles;
using WebApp.Models.WebContent.Resources;

namespace WebApp.Models.WebContent {

    public class PageTemplate : SoftDeleteModel, IProfileChild {

        public Guid ProfileId { get; set; }

        public Profile? Profile { get; set; }

        [Display(Name = "Favorite Icon")]
        public ImageResource? FavIcon { get; set; }

        [Display(Name = "Injected Content")]
        public InjectedContentList InjectedContent { get; set; } = new();

        public PageTemplateMetadata Metadata { get; set; } = new();

        public PageTemplateTheme Theme { get; set; } = new();

        public PageTemplateHeader Header { get; set; } = new();

        public PageTemplateFooter Footer { get; set; } = new();

    }
}
