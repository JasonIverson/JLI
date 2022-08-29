using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JLI.Framework.Data {

    /// <summary>
    /// An abstraction of a repository for the <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public interface IModelRepository<TModel>
        where TModel : Models.Model {

        /// <summary>
        /// Allows to query for a the <typeparamref name="TModel"/>
        /// </summary>
        /// <param name="trackingEnabled"></param>
        /// <returns></returns>
        IQueryable<TModel> AsQueryable(bool trackingEnabled);

        /// <summary>
        /// Configures the underlying data store to track the <paramref name="model"/> according to the <paramref name="changeTrackingType"/> parameter provided.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="changeTrackingType"></param>
        void TrackChanges(TModel model, ChangeTrackingTypes changeTrackingType);

        /// <summary>
        /// Saves changes in the underlying data store.
        /// </summary>
        /// <returns></returns>
        int SaveChanges();

        /// <summary>
        /// Saves changes in the underlying data store.
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesAsync();

    }
}
