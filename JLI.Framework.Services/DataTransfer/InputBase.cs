using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Services {

    /// <summary>
    /// Represents a subset (or entire set) of data properties which comprise a <typeparamref name="TModel"/> for purposes of persistance to, and reading from a repository
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public abstract class InputBase<TModel>
        where TModel : Data.Models.Model, new() {

        #region Constructor(s)

        public InputBase() {
        }

        public InputBase(TModel model)
            : base() {
            this.Populate(model);
        }

        #endregion Constructor(s)

        #region Properties

        public Guid Id { get; set; }

        public DateTime CreatedDateUtc { get; set; }

        public DateTime? UpdatedDateUtc { get; set; }

        #endregion Properties

        #region Utility Methods

        /// <summary>
        /// Populate this object's values using the <paramref name="model"/> provided as an argument.
        /// </summary>
        /// <param name="model"></param>
        public virtual void Populate(TModel model) {
            this.Id = model.Id;
            this.CreatedDateUtc = model.CreatedDateUtc;
            this.UpdatedDateUtc = model.UpdatedDateUtc;
        }

        /// <summary>
        /// Applies the changes made to the <paramref name="model"/> provided as an argument.
        /// </summary>
        /// <param name="model"></param>
        public virtual void ApplyTo(TModel model) {
            if (this.Id != Guid.Empty)
                model.Id = this.Id;
            if (this.CreatedDateUtc != DateTime.MinValue && this.CreatedDateUtc != DateTime.MaxValue)
                model.CreatedDateUtc = this.CreatedDateUtc;
            model.UpdatedDateUtc = this.UpdatedDateUtc ?? model.UpdatedDateUtc;
        }

        #endregion Utility Methods

    }
}
