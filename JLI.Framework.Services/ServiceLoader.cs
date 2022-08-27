using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace JLI.Framework.Services {

    /// <summary>
    /// Utility class which registers services in a <see cref="IServiceCollection"/>
    /// </summary>
    public static class ServiceLoader {

        /// <summary>
        /// Registers types decorated with a <see cref="ServiceLoaderAttribute"/> as services into the <paramref name="serviceCollection"/> for this <paramref name="assembly"/>, and optionally any referenced assemblies.
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="assembly"></param>
        /// <param name="includeRefencedAssemblies"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void Load(IServiceCollection serviceCollection, Assembly assembly, bool includeRefencedAssemblies) {
            List<Type> allTypes = assembly.GetTypes()
                .Where(x => x.IsDefined(typeof(ServiceLoaderAttribute)))
                .ToList();
            if (includeRefencedAssemblies) {
                List<Type> referencedTypes = assembly.GetReferencedAssemblies()
                    .SelectMany(x => Assembly.Load(x).GetTypes())
                    .Where(x => x.IsDefined(typeof(ServiceLoaderAttribute)))
                    .ToList();
                allTypes.AddRange(referencedTypes);
            }

            foreach (Type implementationType in allTypes) {
                ServiceLoaderAttribute? serviceLoaderAttribute = implementationType.GetCustomAttribute<ServiceLoaderAttribute>();
                if (serviceLoaderAttribute != null) {
                    Type serviceType = serviceLoaderAttribute.ImplementingInterface ?? implementationType;
                    switch (serviceLoaderAttribute.Lifetime) {
                        case ServiceLifetimes.Scoped:
                            serviceCollection.AddScoped(serviceType, implementationType);
                            break;
                        case ServiceLifetimes.Singleton:
                            serviceCollection.AddSingleton(serviceType, implementationType);
                            break;
                        case ServiceLifetimes.Transient:
                            serviceCollection.AddTransient(serviceType, implementationType);
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }                
            }
        }

    }
}
