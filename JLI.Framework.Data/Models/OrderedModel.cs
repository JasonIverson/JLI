using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data.Models {

    public abstract class OrderedModel : ModelBase, IOrderedModel {

        public int Order { get; set; }

    }
}
