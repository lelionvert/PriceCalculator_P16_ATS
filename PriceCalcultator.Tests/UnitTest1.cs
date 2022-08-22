using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceCalcultator.Main;
using System;

namespace PriceCalcultator.Tests
{
    [TestClass]
    public class TaxCalculatorTests
    {
        [TestMethod]
        public void Apply20TaxToBookPriced20dot25ShouldReturn24dot30()
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
            PrettyDisplay taxDisplay = new PrettyDisplay();
            String formattedReturn = taxDisplay.GetFormatedReturn(book, taxRate);
            Assert.AreEqual("Book with name = \"The Little Prince\", UPC = 12345, price =$20.25.\r\nProduct price reported as $20.25 before tax and $24.30 after 20 % tax.", formattedReturn);
        }

        [TestMethod]
        public void Apply20RateTax()
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
            Assert.AreEqual(24.30, book.ApplyTax(taxRate));
        }
    }
}