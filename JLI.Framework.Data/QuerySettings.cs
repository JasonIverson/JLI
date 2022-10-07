using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data {

    public class QuerySettings {

        #region Constructor(s)

        public QuerySettings(bool trackingEnabled) {
            this.TrackingEnabled = trackingEnabled;
        }

        #endregion Constructor(s)

        #region Properties

        public bool TrackingEnabled { get; set; }

        #endregion Properties

        #region Public Members

        public IList<String> NavigationProperties { get; private set; } = new List<String>();

        #endregion Public Members

        #region Utility Methods

        protected void TryAddNavigationProperty(String navigationProperty) {
            if (!this.NavigationProperties.Contains(navigationProperty))
                this.NavigationProperties.Add(navigationProperty);
        }

        #endregion Utility Methods

        #region Intended Usage by descendents (Pseudo code)

        //public class CustomerQuerySettings : QuerySettings {

        //    protected CustomerQuerySettings(bool trackingEnabled)
        //        : base(trackingEnabled) { }

        //    public CustomerQuerySettings IncludeAddress() {
        //        this.TryAddNavigationProperty(nameof(Customer.Address));
        //        return this;
        //    }

        //    public CustomerQuerySettings IncludeCreditCard() {
        //        this.TryAddNavigationProperty(nameof(Customer.CreditCard));
        //        return this;
        //    }

        //}

        //private void Foo() {
        //    CustomerQuerySettings customerQuerySettings = new CustomerQuerySettings(true)
        //        .IncludeAddress()
        //        .IncludeCreditCard();
        //}

        #endregion Instended Usage by descendents (Pseudo code)

    }

}
