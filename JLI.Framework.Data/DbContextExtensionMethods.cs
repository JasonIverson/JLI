using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using JLI.Framework.Data;

namespace Microsoft.Extensions.DependencyInjection {

    /// <summary>
    /// Registers repositories as scoped services
    /// </summary>
    public static class DbContextExtensionMethods {

        /// <summary>
        /// Finds all <see cref="EntityFrameworkCore.DbSet{TEntity}"/> properties and registers them as scoped services in the <paramref name="serviceCollection"/> using a <see cref="IModelRepository{TModel}" /> as the service, and <see cref="ModelRepository{TModel}"/> as the implementation.
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="serviceCollection"></param>
        public static void LoadRepositories(this EntityFrameworkCore.DbContext dbContext, IServiceCollection serviceCollection) {
            Type type = dbContext.GetType();
            PropertyInfo[] properties = type.GetProperties()
                .Where(x => x.PropertyType.IsGenericType && typeof(EntityFrameworkCore.DbSet<>).IsAssignableFrom(x.PropertyType.GetGenericTypeDefinition()))
                .ToArray();
            foreach (PropertyInfo propertyInfo in properties) {
                // Logic adapted from this SO answer https://stackoverflow.com/a/67530
                Type propertyType = propertyInfo.PropertyType;
                Type serviceType = typeof(IModelRepository<>).MakeGenericType(propertyType);
                Type implementationType = typeof(ModelRepository<>).MakeGenericType(propertyType);
                serviceCollection.AddScoped(serviceType, implementationType);
            }
        }

    }
}
