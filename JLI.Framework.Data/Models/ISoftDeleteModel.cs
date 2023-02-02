using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data.Models {
    
    public interface ISoftDeleteModel {

        public DateTime? DeletedDateUtc { get; set; }

        bool IsDeleted { get; }

        void Delete();

    }

}
