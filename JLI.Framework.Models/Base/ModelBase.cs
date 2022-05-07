using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Models
{
    
    /// <summary>
    /// Represents a base class for a model
    /// </summary>
    public abstract class ModelBase
    {

        public DateTime CreatedDateUtc { get; set; }

        public DateTime? UpdatedDateUtc { get; set; }

    }
}
