namespace JLI.Framework.Data.Models {

    /// <summary>
    /// Represents a base class for a model
    /// </summary>
    public abstract class ModelBase {

        public DateTime CreatedDateUtc { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedDateUtc { get; set; }

    }
}
