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
    public abstract class RepositoryServiceBase<TModel, TQuerySettings> : ServiceBase
        where TModel : Data.Models.Model, new()
        where TQuerySettings : QuerySettings<TModel> {

        #region Constructor(s)

        public RepositoryServiceBase(IServiceProvider serviceProvider, IModelRepository<TModel> repository)
            : base(serviceProvider) {
            this.Repository = repository;
        }

        #endregion Constructor(s)

        #region Properties

        protected IModelRepository<TModel> Repository { get; private set; }

        #endregion Properties

        #region Service Methods

        public async Task<TModel?> GetAsync(Guid id, TQuerySettings querySettings) {
            IQueryable<TModel> query = querySettings.Query.Where(x => x.Id == id);
            TModel? result = await this.GetAsync(query);
            return result;
        }

        public virtual TQuerySettings GetQuerySettings(bool trackingEnabled) {
            TQuerySettings? querySettings;
            IQueryable<TModel> baseQuery = this.Repository.AsQueryable(trackingEnabled);

            Object[] parameters = new Object[] {
                trackingEnabled,
                baseQuery
            };
            querySettings = Activator.CreateInstance(typeof(TQuerySettings), parameters) as TQuerySettings;
            if (querySettings == null)
                throw new Exception($"Unable to create instance of type {typeof(TQuerySettings).FullName}");

            return querySettings;
        }

        #endregion Service Methods

        #region Utility Methods        

        /// <summary>
        /// Uses the underlying repository to get a <typeparamref name="TDynamic"/> based on a <typeparamref name="TModel"/> whose values have been projected into an anonymous type
        /// </summary>
        /// <typeparam name="TDynamic"></typeparam>
        /// <param name="queryable"></param>
        /// <returns></returns>
        protected async Task<TDynamic?> GetAsync<TDynamic>(IQueryable<TDynamic> queryable) {
            TDynamic? returnValue = await queryable.FirstOrDefaultAsync();
            return returnValue;
        }

        /// <summary>
        /// Uses the underlying repository to get an object of type <typeparamref name="TModel"/>
        /// </summary>
        /// <param name="queryable"></param>
        /// <returns></returns>
        protected async Task<TModel?> GetAsync(IQueryable<TModel> queryable) {
            TModel? returnValue = await this.GetAsync<TModel>(queryable);
            return returnValue;
        }

        /// <summary>
        /// Uses the underlying repository to get a <see cref="List{TDynamic}"/> whose values have been projected into an anonymous type
        /// </summary>
        /// <typeparam name="TDynamic"></typeparam>
        /// <param name="queryable"></param>
        /// <returns></returns>
        protected async Task<List<TDynamic>> ListAsync<TDynamic>(IQueryable<TDynamic> queryable) {
            List<TDynamic> returnValue = await queryable.ToListAsync();
            return returnValue;
        }

        /// <summary>
        /// Uses the underlying repository to get a <see cref="List{TModel}"/> object of type <typeparamref name="TModel"/>
        /// </summary>
        /// <param name="queryable"></param>
        /// <returns></returns>
        protected async Task<List<TModel>> ListAsync(IQueryable<TModel> queryable) {
            List<TModel> returnValue = await this.ListAsync<TModel>(queryable);
            return returnValue;
        }

        #endregion Utility Methods

    }
}
