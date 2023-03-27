namespace JLI.Framework.Data {

    /// <summary>
    /// Allows a data store to track different types of changes to a model
    /// </summary>
    public enum ModelTrackingTypes : byte {

        /// <summary>
        /// A new model should be added to the data store
        /// </summary>
        Add = 0,

        /// <summary>
        /// An existing model should be updated in the data store
        /// </summary>
        Update = 1,

        /// <summary>
        /// An existing model should be deleted from the data store
        /// </summary>
        Delete = 2,

        /// <summary>
        /// An model that is currently being tracked should no longer be tracked
        /// </summary>
        Detach = 3

    }
}
