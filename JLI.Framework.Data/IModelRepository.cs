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
        /// <returns></returns>
        IQueryable<TModel> AsQueryable();

        /// <summary>
        /// Configures the underlying data store to track the <paramref name="model"/> as either an existing or new record according to the <paramref name="updateExisting"/> parameter provided.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="updateExisting"></param>
        void TrackChanges(TModel model, bool updateExisting);

        // int SaveChanges();

        // Task<int> SaveChangesAsync();

    }
}
