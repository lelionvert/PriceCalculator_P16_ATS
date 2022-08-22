using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceCalcultator.Main;
using System;

namespace PriceCalcultator.Tests
{
    [TestClass]
    public class TaxCalculatorTests
    {
        [TestMethod]
        public void ToRename()
        {
            Product book = new Product()
            {
                name = "The Little Prince",
                upc = 12345,
                price = 20.25
            };

            TaxRate taxRate = new TaxRate()
            {
                rate = 20
            };

            String appliedTax = TaxCalculator.GetFormatedReturn(book, taxRate);
            Console.WriteLine(appliedTax);
            Assert.AreEqual("Book with name = \"The Little Prince\", UPC = 12345, price =$20.25.\r\nProduct price reported as $20.25 before tax and $24.30 after 20 % tax.", appliedTax);
        }

        [TestMethod]
        public void Apply20RateTax()
        {
            float price = 20.25f;
            TaxRate taxRate = new TaxRate()
            {
                rate = 20
            };
            Assert.AreEqual(24.30, TaxCalculator.ApplyTax(price, taxRate));
        }
    }
}