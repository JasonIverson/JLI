using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data.Models {

    /// <summary>
    /// Represents a base class for a model with a Guid Id
    /// </summary>
    public abstract class Model : ModelBase<Guid> {

        #region Fields

        private static Microsoft.EntityFrameworkCore.ValueGeneration.SequentialGuidValueGenerator GuidGenerator;

        #endregion Fields

        #region Constructor(s)

        static Model() {
            Model.GuidGenerator = new Microsoft.EntityFrameworkCore.ValueGeneration.SequentialGuidValueGenerator();
        }

        protected Model() {
            this.Id = Model.GuidGenerator.Next(null);
        }

        #endregion Constructor(s)

    }

    /*
    //
    // TODO:  Hash out logic for this and implement into repository
    //
    public interface IModelWithSoftDeletion {

        public DateTime? DeletedDateUtc { get; set; }

        public void SoftDelete();

    }

    //
    // TODO:  Hash out logic for this and implement into repository
    //
    public abstract class ModelWithSoftDeletion : Model, IModelWithSoftDeletion
      {

        public DateTime? DeletedDateUtc { get; set; }

        public bool IsDeleted => this.DeletedDateUtc.HasValue;

        public virtual void SoftDelete() {
            this.DeletedDateUtc = DateTime.UtcNow;
        }

    }
    */
}
