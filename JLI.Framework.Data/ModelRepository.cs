using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void TrackChanges(TModel model, ChangeTrackingTypes changeTrackingType) {
            switch(changeTrackingType) {
                case ChangeTrackingTypes.Add:
                    this.DbSet.Add(model);
                    break;
                case ChangeTrackingTypes.Update:
                    model.UpdatedDateUtc = DateTime.UtcNow;
                    this.DbSet.Update(model);
                    break;
                case ChangeTrackingTypes.Delete:
                    this.DbSet.Remove(model);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion Public Members

    }
}
