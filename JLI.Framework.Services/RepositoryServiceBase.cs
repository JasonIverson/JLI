using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace JLI.Framework.Services {
    public abstract class RepositoryServiceBase<TModel> : ServiceBase
        where TModel : Data.Models.Model, new() {

        #region Constructor(s)

        public RepositoryServiceBase(IServiceProvider serviceProvider, Data.IModelRepository<TModel> repository)
            : base(serviceProvider) {
            this.Repository = repository;
        }

        #endregion Constructor(s)

        #region Properties

        public Data.IModelRepository<TModel> Repository { get; private set; }

        #endregion Properties

    }
}
