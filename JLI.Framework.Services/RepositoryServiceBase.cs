﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using JLI.Framework.Data;

namespace JLI.Framework.Services {
    public abstract class RepositoryServiceBase<TModel, TQueryParameters> : ServiceBase
        where TModel : Data.Models.Model, new()
        where TQueryParameters : QuerySettings {

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

        //public async Task<TModel?> GetAsync(Guid id, TQueryParameters queryParameters) {
        //    throw new NotImplementedException();
        //    IQueryable<TModel> queryable = this.Repository.AsQueryable(queryParameters.TrackingEnabled);
        //    foreach (String include in queryParameters.GetIncludes()) {
        //        queryable = queryable.Include(include);
        //    }
        //}

        #endregion Service Methods

        #region Utility Methods

        /// <summary>
        /// Uses the <paramref name="queryParameters"/> to initialize an <see cref="IQueryable{T}"/>
        /// </summary>
        /// <param name="queryParameters"></param>
        /// <returns></returns>
        protected virtual IQueryable<TModel> InitializeQueryable(TQueryParameters queryParameters) {
            IQueryable<TModel> returnValue = this.Repository.AsQueryable(queryParameters.TrackingEnabled);
            foreach(String navigationProperty in queryParameters.NavigationProperties) {
                returnValue = returnValue.Include(navigationProperty);
            }
            return returnValue;
        }

        /// <summary>
        /// Uses the underlying repository to get a <typeparamref name="TDynamic"/> based on a <typeparamref name="TModel"/> whose values have been projected into an anonymous type
        /// </summary>
        /// <typeparam name="TDynamic"></typeparam>
        /// <param name="queryable"></param>
        /// <returns></returns>
        protected async Task<TDynamic?> Get<TDynamic>(IQueryable<TDynamic> queryable) {
            TDynamic? returnValue = await queryable.FirstOrDefaultAsync();
            return returnValue;
        }

        /// <summary>
        /// Uses the underlying repository to get an object of type <typeparamref name="TModel"/>
        /// </summary>
        /// <param name="queryable"></param>
        /// <returns></returns>
        protected async Task<TModel?> Get(IQueryable<TModel> queryable) {
            TModel? returnValue = await this.Get<TModel>(queryable);
            return returnValue;
        }

        /// <summary>
        /// Uses the underlying repository to get a <see cref="List{TDynamic}"/> whose values have been projected into an anonymous type
        /// </summary>
        /// <typeparam name="TDynamic"></typeparam>
        /// <param name="queryable"></param>
        /// <returns></returns>
        protected async Task<List<TDynamic>> List<TDynamic>(IQueryable<TDynamic> queryable) {
            List<TDynamic> returnValue = await queryable.ToListAsync();
            return returnValue;
        }

        /// <summary>
        /// Uses the underlying repository to get a <see cref="List{TModel}"/> object of type <typeparamref name="TModel"/>
        /// </summary>
        /// <param name="queryable"></param>
        /// <returns></returns>
        protected async Task<List<TModel>> List(IQueryable<TModel> queryable) {
            List<TModel> returnValue = await this.List<TModel>(queryable);
            return returnValue;
        }

        #endregion Utility Methods

    }
}
