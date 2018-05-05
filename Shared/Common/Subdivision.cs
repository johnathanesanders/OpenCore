using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenCore.Common
{
    /// <summary>Class <c>Subdivision</c> models a subdivision, more commonly known as a state or province.
    /// </summary>
    public class Subdivision : IValidatableObject
    {
        private string __abbreviation { get; set; }
        private int __identifier { get; set; }
        private string __isoCode { get; set; }
        private string __name { get; set; }
        private string __nameWithDiacritics { get; set; }

        /// <summary>
        /// This constructor is the base initializer for the class.
        /// </summary>
        public Subdivision()
        {

        }

        /// <summary>
        /// The <c>Abbreviation</c> property represents the commonly accepted abbreviation of the subdivision.
        /// </summary>
        public string Abbreviation
        {
            get => __abbreviation;
            set => __abbreviation = value;
        }

        /// <summary>
        /// The <c>Identifier</c> property represents the internal identifier for the subdivision.
        /// </summary>
        public int Identifier
        {
            get => __identifier;
            private set => __identifier = value;
        }

        /// <summary>
        /// The <c>IsoCode</c> property represnts the ISO 3166-2 code for the Subdivision.
        /// </summary>
        [RegularExpression(@"^[- A-Z0-9]$", ErrorMessage = "The ISO 3166-2 code must be alphanumeric and can only contain the space and dash characters.")]
        public string IsoCode
        {
            get => __isoCode;
            set => __isoCode = value;
        }

        /// <summary>
        /// The <c>Name</c> property represents the name of the subdivision without diacritics.
        /// <example>Goteborg</example>
        /// </summary>
        public string Name
        {
            get => __name;
            set => __name = value;
        }

        /// <summary>
        /// The <c>NameWithDiacritics</c> property represents the name of the subdivison with diacritics.
        /// <example>Göteborg</example>
        /// </summary>
        public string NameWithDiacritics
        {
            get => __nameWithDiacritics;
            set => __nameWithDiacritics = value;
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
