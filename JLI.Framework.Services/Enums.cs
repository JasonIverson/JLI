using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Services {
    
    /// <summary>
    /// Used to determine the manner in which services are added to a <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/>
    /// </summary>
    public enum ServiceLifetimes :
        byte {

        /// <summary>
        /// Service should be registered as Scoped
        /// </summary>
        Scoped = 0,

        /// <summary>
        /// Service should be registered as Singleton
        /// </summary>
        Singleton = 1,

        /// <summary>
        /// Service should be registered as Transient
        /// </summary>
        Transient = 2

    }

}
