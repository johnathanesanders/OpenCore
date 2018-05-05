using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenCore.Common
{
    /// <summary>
    /// Class <c>Currency</c> models a currency using ISO 4217 specifications.
    /// </summary>
    public class Currency : IValidatableObject
    {
        
        private List<Country> __countriesInUse { get; set; }
        private int __digitsAfterDecimal { get; set; }
        private int __identifier { get; set; }
        private string __isoCode { get; set; }
        private int __isoNumeric { get; set; }
        private string __name { get; set; }

        /// <summary>
        /// This constructor is the base initializer for the class.
        /// </summary>
        public Currency()
        {

        }

        /// <summary>
        /// The <c>CountriesInUse</c> property represents a list of countries where the currency is in active use.
        /// </summary>
        public List<Country> CountriesInUse
        {
            get => __countriesInUse;
            set => __countriesInUse = value;
        }

        /// <summary>
        /// The <c>DigitsAfterDecimal</c> property represents the number of digits after the decimal when using the currency. Default is TWO (2).
        /// </summary>
        public int DigitsAfterDecimal
        {
            get => __digitsAfterDecimal;
            set => __digitsAfterDecimal = value;
        }

        /// <summary>
        /// The <c>Identifier</c> property represents the internal identifier of the currency.
        /// </summary>
        public int Identifier
        {
            get => __identifier;
            private set => __identifier = value;
        }

        /// <summary>
        /// The <c>IsoCode</c> property represents the ISO character code of the currency - including cryptocurrencies.
        /// </summary>
        public string IsoCode
        {
            get => __isoCode;
            set => __isoCode = value;
        }

        /// <summary>
        /// The <c>IsoNumeric</c> property represents the ISO numeric identifier of the currency.
        /// </summary>
        public int IsoNumeric
        {
            get => __isoNumeric;
            set => __isoNumeric = value;
        }

        /// <summary>
        /// The <c>Name</c> property represents the common name of the currency.
        /// </summary>
        public string Name
        {
            get => __name;
            set => __name = value;
        } 

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (1 > 2)
            {
                yield return new ValidationResult("Validation Result");
            }
        }
    }

}
