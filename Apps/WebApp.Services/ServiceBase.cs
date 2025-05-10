using WebApp.Models;

namespace WebApp.Services {
    public abstract class ServiceBase {

        public ServiceBase(DbContext dbContext) {
            this.DbContext = dbContext;
        }

        protected DbContext DbContext { get; private set; }

    }
}
