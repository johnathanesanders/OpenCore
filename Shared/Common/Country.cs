using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenCore.Common
{

    /// <summary>Class <c>Country</c> models a country.
    /// </summary>
    public class Country : IValidatableObject
    {

        private string __callingCode { get; set; }
        private int? __identifier { get; set; }
        private string __isoThreeCode { get; set; }
        private string __isoTwoCode { get; set; }
        private int? __isoNumeric { get; set; }
        private string __name { get; set; }

        /// <summary>
        /// This constructor initializes the new country with the given <c>IsoNumeric</c> and <c>Name</c> params.
        /// The <c>IsoNumeric</c> property is automatically applied as the <c>Identifier</c> property of the country.
        /// </summary>
        /// <param name="IsoNumeric"><c>IsoNumeric</c> is the ISO 3166-1 numeric code of the country.</param>
        /// <param name="Name"><c>Name</c> is the ISO 3166-1 English short name for the country.</param>
        /// <param name="CallingCode"><c>CallingCode</c> is the ITU-T E.123/E.164 international prefix code for the country.</param>
        /// <param name="IsoThreeCode"><c>IsoThreeCode</c> is the ISO 3166-1 three character code of the country.</param>
        /// <param name="IsoTwoCode"><c>IsoTwoCode</c> is the ISO 3166-1 two character code of the country.</param>
        public Country(int IsoNumeric, string Name, string CallingCode = null, string IsoThreeCode = null, string IsoTwoCode = null)
        {
            __callingCode = CallingCode;
            __identifier = IsoNumeric;
            __isoThreeCode = IsoThreeCode;
            __isoTwoCode = IsoTwoCode;
            __isoNumeric = IsoNumeric;
            __name = Name;
        }

        /// <summary>
        /// This constructor initializes the new country with the given <c>Identifier</c>, <c>IsoNumeric</c>, and <c>Name</c> params.
        /// </summary>
        /// <param name="Identifier"><c>Identifier</c> is the internal identifier of the country.</param>
        /// <param name="IsoNumeric"><c>IsoNumeric</c> is the ISO 3166-1 numeric code of the country.</param>
        /// <param name="Name"><c>Name</c> is the ISO 3166-1 English short name for the country.</param>
        /// <param name="CallingCode"><c>CallingCode</c> is the ITU-T E.123/E.164 international prefix code for the country.</param>
        /// <param name="IsoThreeCode"><c>IsoThreeCode</c> is the ISO 3166-1 three character code of the country.</param>
        /// <param name="IsoTwoCode"><c>IsoTwoCode</c> is the ISO 3166-1 two character code of the country.</param>
        public Country(int Identifier, int IsoNumeric, string Name, string CallingCode = null, string IsoThreeCode = null, string IsoTwoCode = null)
        {
            __callingCode = CallingCode;
            __identifier = Identifier;
            __isoThreeCode = IsoThreeCode;
            __isoTwoCode = IsoTwoCode;
            __isoNumeric = IsoNumeric;
            __name = Name;
        }

        /// <summary>
        /// This constructor initializes the new country with only the <c>Identifier</c> when quick constructs are required for 
        /// entities that will be referenced in a database in a later action.
        /// </summary>
        /// <param name="Identifier"><c>Identifier</c> is the internal identifier of the country.</param>
        public Country(int Identifier)
        {
            __identifier = Identifier;
        }

        /// <summary><value>The <c>CallingCode</c> property represents the ITU-T E.123/E.164 international 
        /// prefix code for the country.</value></summary>
        [RegularExpression(@"^([+]){1}([0-9 ]){1,}$", ErrorMessage = "CallingCode: The code must be prefixed with a '+' and contain at least one number. Spaces are also allowed.")]
        public string CallingCode
        {
            get => __callingCode;
            set => __callingCode = value;
            
        }

        /// <summary><value>The <c>Identifier</c> property represents the internal identifier of the country. 
        /// <remark>This identifier is not necessarily the same value as the IsoNumeric code.</remark></value></summary>
        public int Identifier
         {
            get => __identifier.GetValueOrDefault(IsoNumeric);
            private set => __identifier = value;
         }

        /// <summary><value>The <c>IsoThreeCode</c> property defines the ISO 3166-1 three character code of 
        /// the country.</value></summary>
        [RegularExpression(@"^[a-zA-Z]{3}$", ErrorMessage = "IsoThreeCode: Only three character values are allowed.")]
        public string IsoThreeCode
        {
            get => __isoThreeCode;
            set => __isoThreeCode = value;
        }

        /// <summary><value>The <c>IsoTwoCode</c> property defines the ISO 3166-1 two character
        /// code of the country.</value></summary>
        [RegularExpression(@"^[a-zA-Z]{2}$", ErrorMessage = "IsoTwoCode: Only two character values are allowed.")]
        public string IsoTwoCode
        {
            get => __isoTwoCode;
            set => __isoTwoCode = value;
        }

        /// <summary><value>The <c>IsoNumeric</c> property defines the ISO 3166-1 numeric code 
        /// of the country.</value></summary>
        [RegularExpression(@"^[0-9]{3}$", ErrorMessage = "IsoNumeric: Only three numeric values are allowed. Values less than 100 must be prefixed with zero padding.")]
        public int IsoNumeric
        {
            get => __isoNumeric.GetValueOrDefault();
            set => __isoNumeric = value;
        }

        /// <summary><value>The <c>Name</c> property defines the ISO 3166-1 English short name
        /// for the country.</value></summary>
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
