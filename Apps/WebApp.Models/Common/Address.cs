using JLI.Framework.Data;
using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Common {

    public class Address : SoftDeleteModel {

        [AddressLineLength, Required]
        [Display(Name = "Line 1")]
        public String Line1 { get; set; } = null!;

        [AddressLineLength]
        [Display(Name = "Line 2")]
        public String? Line2 { get; set; }

        [AddressCityLength, Required]
        public String City { get; set; } = null!;

        [AddressStateLength, Required]
        public String State { get; set; } = null!;

        [AddressPostalCodeLength, Required]
        [Display(Name = "Postal Code")]
        public String PostalCode { get; set; } = null!;

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

    }

}
