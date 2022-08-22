using System;

namespace PriceCalcultator.Main
{
    public class Product
    {
        private string name;

        private int upc;

        private double price;

        public Product(string name, int upc, double price)
        {
            this.name = name;
            this.upc = upc;
            this.price = price;
        }

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

        public string ToStringWithTaxe(TaxRate taxRate)
        {
            return String.Format("Product price reported as ${0} before tax and ${1} after {2} % tax.", this.price, this.ConvertPriceToString(this.ApplyTax(taxRate)), taxRate.ToString());
        }
    }
}