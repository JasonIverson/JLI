namespace JLI.Framework.Data.Models {

    /// <summary>
    /// Represents a base class for a model with a typed Id
    /// </summary>
    public abstract class ModelBase<TKey> : ModelBase
        where TKey : IEquatable<TKey> {

        public virtual TKey Id { get; set; } = default!;

    }
}
