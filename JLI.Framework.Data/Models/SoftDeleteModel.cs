using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data.Models {

    public abstract class SoftDeleteModel : Model {

        public DateTime? DeletedDateUtc { get; set; }

        public bool IsDeleted => this.DeletedDateUtc.HasValue;

        public virtual void Delete() {
            if (!this.IsDeleted)
                this.DeletedDateUtc = DateTime.UtcNow;
        }

    }

}
