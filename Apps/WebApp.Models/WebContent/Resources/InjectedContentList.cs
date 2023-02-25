using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models.WebContent.Resources {

    // TODO:  Update object model so InjectedContent can reference both PageTemplate and Page
    public class InjectedContentList : List<InjectedContent> {

        public InjectedContentList() { }

        public IEnumerable<InjectedContent> Gather(ContentLocations? location, ContentTypes? contentType) {
            IQueryable<InjectedContent> query = this.AsQueryable();
            if (location.HasValue)
                query = query.Where(x => x.Location == location.Value);
            if (contentType.HasValue)
                query = query.Where(x => x.Type== contentType.Value);
            return query.AsEnumerable();
        }

    }
}
