using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenCore.Common
{
    /// <summary>Class <c>Address</c> models a physical street address.
    /// </summary>
    public class Address : IValidatableObject
    {
        
        private string __city { get; set; }
        private Country __country { get; set; }
        private int __identifier { get; set; }
        private double? __latitude { get; set; }
        private double? __longitude { get; set; }
        private string __postalCode { get; set; }
        private Subdivision __subdivision { get; set; }
        private string __streetAddress { get; set; }
        private string __streetAddressAdditional { get; set; }
        private OpenCore.Common.TimeZone __timeZone { get; set; }
        private string __unLocode { get; set; }

        /// <summary>
        /// This constructor is the base initializer for the class.
        /// </summary>
        public Address()
        {
            
        }

        /// <summary>
        /// <value>The name of the <c>City</c>.</value>
        /// </summary>
        public string City
        {
            get => __city;
            set => __city = value;
        }

        /// <summary>
        /// <value>The properties of the <c>Country</c></value>
        /// </summary>
        public Country Country
        {
            get => __country;
            set => __country = value;
        }

        /// <summary>
        /// <value>The internal <c>Identifier</c> of the address.</value>
        /// </summary>
        public int Identifier
        {
            get => __identifier;
            private set => __identifier = value;
        }

        /// <summary>
        /// <value>The <c>Latitude</c> property represents the geographic coordinate that specifies the north-south position of the address.
        /// <remark>If City, Country, PostalCode, Subdivision, and StreetAddress are not provided, then Latitude and Longitude are required.</remark>
        /// </value>
        /// </summary>
        public double Latitude
        {
            get => __latitude.GetValueOrDefault(0);
            set => __latitude = value;
        }

        /// <summary>
        /// <value>The <c>Longitude</c> property represents the geographic coordinate that specifies the east-west position of the address.
        /// <remark>If City, Country, PostalCode, Subdivision, and StreetAddress are not provided, then Latitude and Longitude are required.</remark>
        /// </value>
        /// </summary>
        public double Longitude
        {
            get => __longitude.GetValueOrDefault(0);
            set => __longitude = value;
        }

        /// <summary>
        /// <value>The <c>PostalCode</c> of the address.</value>
        /// </summary>
        public string PostalCode
        {
            get => __postalCode;
            set => __postalCode = value;
        }

        /// <summary>
        /// <value>The properties of the <c>Subdivision</c>.</value>
        /// </summary>
        public Subdivision Subdivision
        {
            get => __subdivision;
            set => __subdivision = value;
        }

        /// <summary>
        /// <value>The <c>StreetAddress</c> property represents the number and street name of the address.</value>
        /// </summary>
        public string StreetAddress
        {
            get => __streetAddress;
            set => __streetAddress = value;
        }

        /// <summary>
        /// <value>The <c>StreetAddressAdditional</c> property represents street location information in addition to <c>StreetAddress</c>.</value>
        /// </summary>
        public string StreetAddressAdditional
        {
            get => __streetAddressAdditional;
            set => __streetAddressAdditional = value;
        }

        /// <summary>
        /// <value>The properties of the <c>TimeZone</c>.</value>
        /// </summary>
        public OpenCore.Common.TimeZone TimeZone
        {
            get => __timeZone;
            set => __timeZone = value;
        }

        ///
        /// <summary>The <c>UnLocode</c> property represents the official UN LOCODE value of the address
        /// </summary>
        public string UnLocode
        {
            get => __unLocode;
            set => __unLocode = value;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            if (String.IsNullOrWhiteSpace(__city) || __country == null || String.IsNullOrWhiteSpace(__postalCode) || String.IsNullOrWhiteSpace(__streetAddress) /* || __subdivision == null*/)
            {
                if (__longitude.GetValueOrDefault(0) == 0 || __latitude.GetValueOrDefault(0) == 0)
                {
                    yield return new ValidationResult("If all of: City, Country, PostalCode, Subdivision, and StreetAddress are not provided, then Latitude and Longitude are required.");
                }
            }
           
        }
    }
}
