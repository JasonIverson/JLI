namespace JLI.Framework.Data.Models {

    /// <summary>
    /// Represents a base class for a model with a Guid Id
    /// </summary>
    public abstract class Model : ModelBase<Guid> {

        #region Fields

        private static readonly Microsoft.EntityFrameworkCore.ValueGeneration.SequentialGuidValueGenerator GuidGenerator;

        #endregion Fields

        #region Constructor(s)

        static Model() {
            Model.GuidGenerator = new Microsoft.EntityFrameworkCore.ValueGeneration.SequentialGuidValueGenerator();
        }

        protected Model() {
            this.Id = Model.GuidGenerator.Next(null);
            this.InitliazeSingleEntityIds();
        }

        #endregion Constructor(s)

        protected virtual void InitliazeSingleEntityIds() { }

    }

}
