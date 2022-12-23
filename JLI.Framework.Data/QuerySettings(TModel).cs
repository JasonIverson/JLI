using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {
    public class QuerySettings<TModel>
        where TModel : Models.Model, new() {

        #region Constructor(s)

        public QuerySettings(bool trackingEnabled, IQueryable<TModel> baseQuery) {
            this.TrackingEnabled = trackingEnabled;
            this.Query = baseQuery;
        }

        #endregion Constructor(s)

        #region Properties

        public bool TrackingEnabled { get; private set; }

        public IQueryable<TModel> Query { get; protected set; }

        #endregion Properties

        #region Common Filters

        public QuerySettings<TModel> FilterById(Guid id) {
            this.Query = this.Query.Where(x => x.Id == id);
            return this;
        }

        public QuerySettings<TModel> FilterByIds(IEnumerable<Guid> ids) {
            this.Query = this.Query.Where(x => ids.Contains(x.Id));
            return this;
        }

        #endregion Common Filters

    }

    //public class Role : Models.SoftDeleteModel {

    //    public String Name { get; set; } = null!;

    //}

    //public class Address : Models.SoftDeleteModel {

    //    public String Line1 { get; set; } = null!;

    //    public String? Line2 { get; set; }

    //    public String City { get; set; } = null!;

    //    public String State { get; set; } = null!;

    //    public String PostalCode { get; set; } = null!;

    //}

    //public class Customer : Models.SoftDeleteModel {

    //    public Guid? AddressId { get; set; }

    //    public Address? Address { get; set; }

    //    public List<Role> Roles { get; set; } = new List<Role>();

    //}

    //public class CustomerQuerySettings : QuerySettings<Customer> {
    //    public CustomerQuerySettings(bool trackingEnabled, IQueryable<Customer> query) : base(trackingEnabled, query) {
    //    }

    //    public CustomerQuerySettings IncludeAddress() {
    //        this.Query = this.Query
    //            .Include(x => x.Address);
    //        return this;
    //    }

    //    public CustomerQuerySettings IncludeRoles() {
    //        this.Query = this.Query
    //            .Include(x => x.Roles.Where(y => !y.IsDeleted));
    //        return this;
    //    }

    //}


}
