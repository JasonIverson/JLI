using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLI.Framework.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JLI.Framework.Data {

    /// <summary>
    /// Implementation of a repository for the <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public abstract class ModelRepository<TModel, TQuerySettings>
        where TModel : Models.Model
        where TQuerySettings : QuerySettings<TModel> {

        #region Fields

        protected readonly DbSet<TModel> DbSet;
        protected readonly DbContext DbContext;

        #endregion Fields

        #region Constructor(s)

        public ModelRepository(DbContext dbContext) {
            this.DbContext = dbContext;
            this.DbSet = dbContext.Set<TModel>();
            if (this.DbSet == null)
                throw new Exception();
        }

        #endregion Constructor(s)

        #region Public Members

        /// <summary>
        /// Configures the underlying data store to track the <paramref name="model"/> according to the <paramref name="changeTrackingType"/> parameter provided.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="changeTrackingType"></param>
        public void EntityTracking(TModel model, EntityTrackingTypes entityTrackingTypesType) {
            switch(entityTrackingTypesType) {
                case EntityTrackingTypes.Add:
                    if (model.CreatedDateUtc == DateTime.MinValue)
                        model.CreatedDateUtc = DateTime.UtcNow;
                    this.DbSet.Add(model);
                    break;
                case EntityTrackingTypes.Update:
                    model.UpdatedDateUtc = DateTime.UtcNow;
                    this.DbSet.Update(model);
                    break;
                case EntityTrackingTypes.Delete:
                    SoftDeleteModel? softDeleteModel = model as SoftDeleteModel;
                    if (softDeleteModel != null) {
                        softDeleteModel.Delete();
                        softDeleteModel.DeletedDateUtc = softDeleteModel.UpdatedDateUtc = DateTime.UtcNow;
                        this.DbSet.Update(model);
                    }
                    else {
                        this.DbSet.Remove(model);
                    }                    
                    break;
                case EntityTrackingTypes.Detach:
                    this.DbContext.Entry(model).State = EntityState.Detached;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns a single <typeparamref name="TDynamic"/> retrieved as a result of the <paramref name="query"/> provided as an argument.
        /// </summary>
        /// <typeparam name="TDynamic"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public async Task<TDynamic?> GetAsync<TDynamic>(IQueryable<TDynamic?> query) {
            TDynamic? returnValue = await query.FirstOrDefaultAsync();
            return returnValue;
        }

        /// <summary>
        /// Returns a single <typeparamref name="TModel"/> retrieved as a result of the <paramref name="querySettings"/> provided as an argument.
        /// </summary>
        /// <param name="querySettings"></param>
        /// <returns></returns>
        public async Task<TModel?> GetAsync(TQuerySettings querySettings) {
            TModel? returnValue = await this.GetAsync(querySettings.Query);
            return returnValue;
        }

        public TQuerySettings GetQuerySettings(bool trackingEnabled) {
            TQuerySettings? querySettings;
            IQueryable<TModel> internalQuery = this.DbSet.AsQueryable();
            if (trackingEnabled)
                internalQuery = internalQuery.AsNoTracking();

            Object[] parameters = new Object[] {
                trackingEnabled,
                internalQuery
            };
            querySettings = Activator.CreateInstance(typeof(TQuerySettings), parameters) as TQuerySettings;
            if (querySettings == null)
                throw new Exception($"Unable to create instance of type {typeof(TQuerySettings).FullName}");

            return querySettings;
        }

        /// <summary>
        /// Returns a List of <typeparamref name="TDynamic"/>s retrieved as a result of the <paramref name="query"/> provided as an argument.
        /// </summary>
        /// <typeparam name="TDynamic"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public async Task<List<TDynamic>> ListAsync<TDynamic>(IQueryable<TDynamic> query) {
            List<TDynamic> returnValue = await query.ToListAsync();
            return returnValue;
        }

        /// <summary>
        /// Returns a List of <typeparamref name="TModel"/>s retrieved as a result of the <paramref name="querySettings"/> provided as an argument.
        /// </summary>
        /// <param name="querySettings"></param>
        /// <returns></returns>
        public async Task<List<TModel>> ListAsync(TQuerySettings querySettions) {
            List<TModel> returnValue = await this.ListAsync(querySettions.Query);
            return returnValue;
        }

        /// <summary>
        /// Saves changes in the underlying data store.
        /// </summary>
        /// <returns></returns>
        public int SaveChanges() {
            int affectedRows = this.DbContext.SaveChanges();
            return affectedRows;
        }

        /// <summary>
        /// Saves changes in the underlying data store.
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChangesAsync() {
            int affectedRows = await this.DbContext.SaveChangesAsync();
            return affectedRows;
        }

        #endregion Public Members

    }
}
