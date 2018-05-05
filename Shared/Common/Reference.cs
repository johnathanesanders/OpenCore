using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenCore.Common
{
    /// <summary>
    /// Class <c>Reference</c> models referential key/value data for an object.
    /// </summary>
    public class Reference : IValidatableObject
    {
        private string __key { get; set; }
        private string __value { get; set; }

        /// <summary>
        /// This constructor is the base initializer for the class.
        /// </summary>
        public Reference()
        {

        }

        /// <summary>
        /// The <c>Key</c> property represents the key or qualifier for the reference.
        /// </summary>
        public string Key
        {
            get => __key;
            set => __key = value;
        }

        /// <summary>
        /// The <c>Value</c> property represents the value of the reference.
        /// </summary>
        public string Value
        {
            get => __value;
            set => __value = value;
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
