using JLI.Framework.Data;
using JLI.Framework.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Common {

    public class Address : SoftDeleteModel {

        /// <summary>
        /// The street address.
        /// </summary>
        [AddressLineLength, Required]
        [Display(Name = "Line 1")]
        public String Line1 { get; set; } = null!;

        /// <summary>
        /// Additional street address details, such as suite, apartment number, etc.
        /// </summary>
        [AddressLineLength]
        [Display(Name = "Line 2")]
        public String? Line2 { get; set; }

        /// <summary>
        /// The locality in which the street address is, and which is in the region. For example, Mountain View.
        /// </summary>
        [AddressLocalityLength, Required]
        public String Locality { get; set; } = null!;

        /// <summary>
        /// The region in which the locality is, and which is in the country. For example, California
        /// </summary>
        [AddressRegionLength, Required]
        public String Region { get; set; } = null!;

        /// <summary>
        /// The postal code. For example, 94043.
        /// </summary>
        [AddressPostalCodeLength, Required]
        [Display(Name = "Postal Code")]
        public String PostalCode { get; set; } = null!;

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

    }

}
