using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenCore.Common
{
    /// <summary>
    /// Class <c>TimeZone</c> models the complexities of a time zone.
    /// </summary>
    public class TimeZone : IValidatableObject
    {
        
        private string __abbreviation { get; set; }
        private string __canonical { get; set; }
        private int __identifier { get; set; }
        private string __militaryTimeZone { get; set; }
        private string __name { get; set; }
        private bool __observesDaylightSaving { get; set; }
        private float __utcOffset { get; set; }

        /// <summary>
        /// This constructor is the base initializer for the class.
        /// </summary>
        public TimeZone()
        {

        }

        /// <summary>
        /// <value>The <c>Abbreviation</c> property represents the common abbreviation for the time zone, if applicable.</value>
        /// </summary>
        public string Abbreviation
        {
            get => __abbreviation;
            set => __abbreviation = value;
        }

        /// <summary>
        /// <value>The <c>Canonical</c> property represents the canonical time zone name as defined by the IANA time zone database.</value>
        /// <example>e.g. <c>America/Chicago</c>.</example>
        /// </summary>
        public string Canonical
        {
            get => __canonical;
            set => __canonical = value;
        }

        /// <summary>
        /// <value>The <c>Identifier</c> property represents the internal identifier of the time zone.</value>
        /// </summary>
        public int Identifier
        {
            get => __identifier;
            private set => __identifier = value;
        }

        /// <summary>
        /// <value>The <c>MilitaryTimeZone</c> property represents the US Military/Nautical time zone abbreviation.</value>
        /// </summary>
        public string MilitaryTimeZone
        {
            get => __militaryTimeZone;
            set => __militaryTimeZone = value;
        }

        /// <summary>
        /// The <c>Name</c> property represents the common name of the time zone, which differs from the <c>Canonical</c>.
        /// <example>Central Time which canonically is America/Chicago</example>
        /// </summary>
        public string Name
        {
            get => __name;
            set => __name = value;
        }

        /// <summary>
        /// The <c>ObservesDaylightSaving</c> property represents whether or not the time zone is a daylight saving zone.
        /// </summary>
        public bool ObservesDaylightSaving
        {
            get => __observesDaylightSaving;
            set => __observesDaylightSaving = value;
        }
        
        /// <summary>
        /// The <c>UtcOffset</c> property represents the offset from Coordinated Universal Time (UTC). 
        /// </summary>
        public float UtcOffset
        {
            get => __utcOffset;
            set => __utcOffset = value;
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
