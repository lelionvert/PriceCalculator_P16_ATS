using System;

namespace PriceCalcultator.Tests
{
    public class Product
    {
        public string name;

        public int upc;

        public double price;

        public double ApplyTax(TaxRate taxRate)
        {
            return Math.Round(this.price * taxRate.ConvertTaxRateToPercentage(), 2);
        }

        public string ConvertPriceToString(double price)
        {
            return string.Format("{0:f2}", price);
        }

        public override string ToString()
        {
            return String.Format("Book with name = \"{0}\", UPC = {1}, price =${2}.", this.name, this.upc, this.ConvertPriceToString(this.price)); 
        }
    }
}