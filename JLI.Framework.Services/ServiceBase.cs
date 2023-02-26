namespace JLI.Framework.Services {

    /// <summary>
    /// Base class for Services
    /// </summary>
    public abstract class ServiceBase {

        #region Properties

        protected IServiceProvider ServiceProvider { get; private set; }

        #endregion Properties

        #region Constructor(s)

        protected ServiceBase(IServiceProvider serviceProvider) {
            this.ServiceProvider = serviceProvider;
        }

        #endregion Constructor(s)

    }
}
