using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data.Models {

    /// <summary>
    /// Represents a base class for a model with a typed Id
    /// </summary>
    public abstract class ModelBase<TKey> : ModelBase
        where TKey : IEquatable<TKey> {

        public virtual TKey Id { get; set; } = default!;

    }
}
