using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {

    /// <summary>
    /// Allows a data store to track different types of changes to an entity
    /// </summary>
    public enum ChangeTrackingTypes : byte {

        /// <summary>
        /// A new entity should be added to the data store
        /// </summary>
        Add = 0,

        /// <summary>
        /// An existing entity should be updated in the data store
        /// </summary>
        Update = 1,

        /// <summary>
        /// An existing entity should be deleted from the data store
        /// </summary>
        Delete = 2

    }
}
