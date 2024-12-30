using JLI.Framework.Data;
using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;
using WebApp.Models.WebContent.Resources;

namespace WebApp.Models.WebContent {

    public class Page : SoftDeleteModel /*, IProfileChild*/ {

        [Required, FormalNameLength]
        public String Name { get; set; } = "New Page";

        public PageTypes Type { get; set; } = PageTypes.Custom;

        public PageMetadata Metadata { get; set; } = new();

        public PageTemplate Template { get; set; } = new();

        public InjectedContentList InjectedContent { get; set; } = new();

        // public List<SectionBase> Body { get; set; } = new();

        public override void InitliazeSingleEntityIds() {
            base.InitliazeSingleEntityIds();
            this.Metadata.Id = this.Id;
        }


    }
}
