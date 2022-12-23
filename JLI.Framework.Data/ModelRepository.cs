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
    public class ModelRepository<TModel> : IModelRepository<TModel>
        where TModel : Models.Model, new() {

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
        /// Allows to query for a the <typeparamref name="TModel"/>
        /// </summary>
        /// <param name="trackingEnabled"></param>
        /// <returns></returns>
        public IQueryable<TModel> AsQueryable(bool trackingEnabled) {
            IQueryable<TModel> returnValue = this.DbSet.AsQueryable();
            if (!trackingEnabled)
                returnValue = returnValue.AsNoTracking();
            return returnValue;
        }

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
