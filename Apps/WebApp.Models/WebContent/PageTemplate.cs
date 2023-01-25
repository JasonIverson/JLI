using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.WebContent.Resources;

namespace WebApp.Models.WebContent {

    public class PageTemplate {

        public ImageResource? FavIcon { get; set; }

        public List<InjectedContent> EmbeddedContent { get; set; } = new List<InjectedContent>();

        public String CharSet => "utf-8";

        public String Language => "en-US";

        public String ViewPort => "width=device-width, initial-scale=1.0";

    }
}
