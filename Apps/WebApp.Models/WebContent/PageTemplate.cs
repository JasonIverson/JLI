using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;
using WebApp.Models.WebContent.Resources;

namespace WebApp.Models.WebContent {

    public class PageTemplate : SoftDeleteModel {

        //[Display(Name = "Favorite Icon")]
        //public ImageResource? FavIcon { get; set; }

        [Display(Name = "Injected Content")]
        public InjectedContentList InjectedContent { get; set; } = new();

        public PageTemplateMetadata Metadata { get; set; } = new();

        //public PageTemplateTheme Theme { get; set; } = new();

        //public PageTemplateHeader Header { get; set; } = new();

        //public PageTemplateFooter Footer { get; set; } = new();

        public List<Page> Pages { get; set; } = new();

        public override void InitliazeSingleEntityIds() {
            base.InitliazeSingleEntityIds();
            this.Metadata.Id = this.Id;
        }

    }
}
