using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Services {

    /// <summary>
    /// An attribute used to decorate services with in order to have them registered in a <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/> without explicitly having to register each service.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ServiceLoaderAttribute : Attribute {

        #region Constructor(s)

        public ServiceLoaderAttribute(ServiceLifetimes lifetime, Type? implementingInterface = null)
            : base() {
            this.Lifetime = lifetime;
            if (implementingInterface != null && !implementingInterface.IsInterface) {
                throw new ArgumentException($"Argument {nameof(implementingInterface)} must be an interface");
            }
        }

        #endregion Constructor(s)

        #region Properties

        /// <summary>
        /// Gets the <see cref="ServiceLifetimes"/> value used to determine how the corresponding service will be registered
        /// </summary>
        public ServiceLifetimes Lifetime { get; private set; }

        /// <summary>
        /// An interface to be used as the Service Type when registering the corresponding service
        /// </summary>
        public Type? ImplementingInterface { get; private set; }

        #endregion Properties

    }

}
