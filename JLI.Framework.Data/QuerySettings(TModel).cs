﻿namespace JLI.Framework.Data {
    public abstract class QuerySettings<TModel>
        where TModel : Models.Model {

        #region Constructor(s)

        internal QuerySettings(bool trackingEnabled, IQueryable<TModel> baseQuery) {
            this.TrackingEnabled = trackingEnabled;
            this.Query = baseQuery;
        }

        #endregion Constructor(s)

        #region Properties

        public bool TrackingEnabled { get; private set; }

        public IQueryable<TModel> Query { get; private set; }

        #endregion Properties

    }

    //public class Role : Models.SoftDeleteModel {

    //    public string Name { get; set; } = null!;

    //}

    //public class Address : Models.SoftDeleteModel {

    //    public string Line1 { get; set; } = null!;

    //    public string? Line2 { get; set; }

    //    public string City { get; set; } = null!;

    //    public string State { get; set; } = null!;

    //    public string PostalCode { get; set; } = null!;

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
