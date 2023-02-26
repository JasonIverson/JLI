using System.Reflection;
using JLI.Framework.Services;

namespace Microsoft.Extensions.DependencyInjection {
    public static class AssemblyExtensionMethods {

        /// <summary>
        /// Registers types decorated with a <see cref="ServiceLoaderAttribute"/> as services into the <paramref name="serviceCollection"/> for this <paramref name="assembly"/>, and optionally any referenced assemblies.
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="serviceCollection"></param>
        /// <param name="includeRefencedAssemblies"></param>
        public static void LoadServices(this Assembly assembly, IServiceCollection serviceCollection, bool includeRefencedAssemblies) {
            ServiceLoader.Load(serviceCollection, assembly, includeRefencedAssemblies);
        }

    }
}
