using System;
using System.Text;

namespace PriceCalcultator.Tests
{
    public static class TaxCalculator
    {
        public static double ApplyTax(double price, TaxRate taxRate)
        {
            return Math.Round(price * ConvertTaxRateToPercentage(taxRate), 2);
        }

        private static double ConvertTaxRateToPercentage(TaxRate taxRate)
        {
            return (1 + (taxRate.rate / 100));
        }

        private static string ConvertPriceToString(double price)
        {
            return string.Format("{0:f2}", price);
        }

        public static string GetFormatedReturn(Product book, TaxRate taxValue)
        {
            StringBuilder sb = new StringBuilder();
            double priceWithAppliedTax = ApplyTax(book.price, taxValue);
            string priceWithAppliedTaxAsString = ConvertPriceToString(priceWithAppliedTax);

            sb.AppendLine(String.Format("Book with name = \"{0}\", UPC = {1}, price =${2}.", book.name, book.upc, ConvertPriceToString(book.price)));
            sb.Append(string.Format("Product price reported as ${0} before tax and ${1} after {2} % tax.", book.price, priceWithAppliedTaxAsString, taxValue.rate));

            return sb.ToString();
        }
    }
}