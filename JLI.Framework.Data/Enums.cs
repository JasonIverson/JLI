namespace JLI.Framework.Data {

    /// <summary>
    /// Allows a data store to track different types of changes to an entity
    /// </summary>
    public enum EntityTrackingTypes : byte {

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
        Delete = 2,

        /// <summary>
        /// An entity that is currently being tracked should no longer be tracked
        /// </summary>
        Detach = 3

    }
}
