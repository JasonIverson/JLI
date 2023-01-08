using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using JLI.Framework.Data;
using System.Linq.Expressions;

namespace JLI.Framework.Services {
    public abstract class RepositoryServiceBase<TModel, TQuerySettings, TModelRepository> : ServiceBase
        where TModel : Data.Models.Model
        where TQuerySettings : QuerySettings<TModel>
        where TModelRepository : ModelRepository<TModel, TQuerySettings> {

        #region Constructor(s)

        public RepositoryServiceBase(IServiceProvider serviceProvider, TModelRepository repository)
            : base(serviceProvider) {
            this.Repository = repository;
        }

        #endregion Constructor(s)

        #region Properties

        protected TModelRepository Repository { get; private set; }

        #endregion Properties

        #region Service Methods

        public async Task<TModel?> GetAsync(Guid id, TQuerySettings querySettings) {
            IQueryable<TModel> query = querySettings.Query.Where(x => x.Id == id);
            TModel? result = await this.Repository.GetAsync(query);
            return result;
        }

        #endregion Service Methods

        #region Utility Methods        

        public TQuerySettings GetQuerySettings(bool trackingEnabled) => 
            this.Repository.GetQuerySettings(trackingEnabled);

        #endregion Utility Methods

    }
}
