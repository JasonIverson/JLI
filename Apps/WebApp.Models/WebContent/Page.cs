using JLI.Framework.Data;
using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;
using WebApp.Models.Profiles;
using WebApp.Models.WebContent.Resources;
using WebApp.Models.WebContent.Sections;

namespace WebApp.Models.WebContent {
    
    public class Page : SoftDeleteModel /*, IProfileChild*/ {

        [Required, FormalNameLength]
        public String Name { get; set; } = "New Page";

        public PageTypes Type { get; set; } = PageTypes.Custom;

        public PageMetadata Metadata { get; set; } = new();

        public InjectedContentList InjectedContent { get; set; } = new();

        // public List<SectionBase> Body { get; set; } = new();

        protected override void InitliazeIds() {
            this.Metadata.Id = this.Id;
        }


    }
}
