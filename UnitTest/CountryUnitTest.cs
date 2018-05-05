using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCore.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenCoreUnitTest
{
    [TestClass]
    public class CountryUnitTest
    {
        [TestMethod]
        public void Country_IdentifierOnlyCreate()
        {
            try
            {
                Country testCountry = new Country(840);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
                return;
            }
        }

        [TestMethod]
        public void Country_IsoNumericBecomesIdentifier_ShouldBeEqual()
        {
            Country testCountry = new Country(840, "United States of America");
            Assert.AreEqual(testCountry.IsoNumeric, testCountry.Identifier);
        }

        [TestMethod]
        public void Country_WhenCallingCodePrefixIsFormattedIncorrectly_ShouldNotValidate()
        {
            // Set up the validationResults
            var validationResults = new List<ValidationResult>();

            // Create a new Country object with an invalid calling code prefix ON object creation
            Country testCountry = new Country(840, "United States of America", "++1");
            
            // Validate the calling code only
            var actual = Validator.TryValidateProperty(testCountry.CallingCode, new ValidationContext(testCountry) { MemberName = "CallingCode" }, validationResults);
            Assert.IsFalse(actual, "Expected validation to fail.");

            // Create a new Country object with an invalid calling code prefix AFTER object creation
            Country testCountry2 = new Country(840, "United States of America");
            testCountry2.CallingCode = "++1";

            // Validate the calling code only
            actual = Validator.TryValidateProperty(testCountry2.CallingCode, new ValidationContext(testCountry2) { MemberName = "CallingCode" }, validationResults);
            Assert.IsFalse(actual, "Expected validation to fail.");
        }

        [TestMethod]
        public void Country_WhenCallingCodePrefixIsFormattedCorrectly_ShouldValidate()
        {
            // Set up the validationResults
            var validationResults = new List<ValidationResult>();

            // Create a new Country object with a valid calling code prefix ON object creation
            Country testCountry = new Country(840, "United States of America", "+1");

            // Validate the calling code only
            var actual = Validator.TryValidateProperty(testCountry.CallingCode, new ValidationContext(testCountry, null, null) { MemberName = "CallingCode" }, validationResults);
            Assert.IsTrue(actual, "Expected validation to pass.");

            // Create a new Country object with a valid calling code prefix AFTER object creation
            Country testCountry2 = new Country(840, "United States of America");
            testCountry2.CallingCode = "+1";

            // Validate the calling code only
            actual = Validator.TryValidateProperty(testCountry2.CallingCode, new ValidationContext(testCountry2, null, null) { MemberName = "CallingCode" }, validationResults);
            Assert.IsTrue(actual, "Expected validation to pass.");
        }

        [TestMethod]
        public void Country_AllValidation_ShouldValidate()
        {
            // Set up the validationResults
            var validationResults = new List<ValidationResult>();

            // Create a new Country object with valid data ON object creation
            Country testCountry = new Country(840, "United States of America", "+1", "USA", "US");
            
            var actual = Validator.TryValidateObject(testCountry, new ValidationContext(testCountry), validationResults, true);
            try
            {
                Assert.IsTrue(actual, "Expected validation to pass.");
            }
            catch
            {
                Assert.Fail(validationResults[0].ErrorMessage);
            }
        }
    }
}
