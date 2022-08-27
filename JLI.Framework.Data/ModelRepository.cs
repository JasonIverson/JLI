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
    public abstract class ModelRepository<TModel> : IModelRepository<TModel>
        where TModel : Models.Model {

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
        /// <returns></returns>
        public IQueryable<TModel> AsQueryable() {
            return this.DbSet.AsQueryable();
        }

        /// <summary>
        /// Configures the underlying data store to track the <paramref name="model"/> as either an existing or new record according to the <paramref name="updateExisting"/> parameter provided.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="updateExisting"></param>
        public void TrackChanges(TModel model, bool updateExisting) {
            if (updateExisting) {
                model.UpdatedDateUtc = DateTime.UtcNow;
                this.DbSet.Update(model);
            }
            else {
                this.DbSet.Add(model);
            }            
        }

        #endregion Public Members
        
    }
}
