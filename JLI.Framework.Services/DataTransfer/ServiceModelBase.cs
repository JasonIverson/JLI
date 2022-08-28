using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Services {

    /// <summary>
    /// Represents a subset (or entire set) of data properties which comprise a <typeparamref name="TModel"/> (and also requires additional supporting data) for purposes of persistance to, and reading from, a repository.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TInput"></typeparam>
    public class ServiceModelBase<TModel, TInput, TData>
        where TModel : Data.Models.Model, new()
        where TInput : InputBase<TModel>, new()
        where TData : ServiceModelData, new() {

        #region Constructor(s)

        public ServiceModelBase() {
        }

        public ServiceModelBase(TInput input)
            : this() {
            this.Input = input;
        }

        public ServiceModelBase(TInput input, 
            TData data) 
            : this(input) {
            this.Data = data;
        }

        #endregion Constructor(s)

        #region Properties

        /// <summary>
        /// Values to be modified in order to manipulate the underlying values for this <typeparamref name="TModel"/>.
        /// </summary>
        public TInput Input { get; set; } = new TInput();

        /// <summary>
        /// Additional required to enable the modifying of values declared in <see cref="Input"/> (e.g. lookup data, enumerable options, default values, etc).
        /// </summary>
        public TData Data { get; set; } = new TData();

        #endregion Properties

    }
}
