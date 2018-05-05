using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCore.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenCoreUnitTest
{
    [TestClass]
    public class AddressUnitTest
    {
        [TestMethod]
        public void Address_Create_ShouldPass()
        {
            try
            {
                // Set up the validationResults
                var validationResults = new List<ValidationResult>();

                // Create a new Address object with valid data
                Address testAddress = new Address
                {
                    City = "Dallas",
                    Country = new Country(840),
                    PostalCode = "75243",
                    StreetAddress = "12500 T I Boulevard"
                };
                          
                var actual = Validator.TryValidateObject(testAddress, new ValidationContext(testAddress), validationResults, true);

                Assert.IsTrue(actual, "Expected validation to pass.");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
                return;
            }
        }

    }
}
