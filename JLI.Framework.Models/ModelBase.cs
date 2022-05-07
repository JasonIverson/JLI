using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Models
{
    public abstract class ModelBase
    {

        public Guid Id { get; set; }

        public DateTime CreatedDateUtc { get; set; }

        public DateTime? UpdatedDateUtc { get; set; }

    }
}
