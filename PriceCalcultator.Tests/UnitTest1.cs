using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceCalcultator.Main;
using System;

namespace PriceCalcultator.Tests
{
    [TestClass]
    public class TaxCalculatorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product book = new Product()
            {
                name = "Le Petit Prince",
                upc = 12345,
                price = 20.25f
            };

            TaxValue taxValue = new TaxValue()
            {
                rate = 20
            };

            String appliedTax = TaxCalculator.ApplyTax(book, taxValue);
            Assert.AreEqual("Product price reported as $20.25 before tax and $24.30 after 20% tax.", appliedTax);
        }

    }
}
