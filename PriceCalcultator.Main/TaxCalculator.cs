using System;
using System.Text;

namespace PriceCalcultator.Tests
{
    public class TaxCalculator
    {
        public static double ApplyTax(double price, TaxRate taxRate)
        {
            return Math.Round(price * CalculateRatePercent(taxRate), 2);
        }

        private static double CalculateRatePercent(TaxRate taxRate)
        {
            return (1 + (taxRate.rate / 100));
        }

        public static string GetFormatedReturn(Product book, TaxRate taxValue)
        {
            StringBuilder sb = new StringBuilder();
            double priceWithAppliedTax = ApplyTax(book.price, taxValue);
            sb.AppendLine(String.Format("Book with name = \"{0}\", UPC = {1}, price =${2}.", book.name, book.upc, book.price));
            sb.Append(string.Format("Product price reported as ${0} before tax and ${1} after {2} % tax.", book.price, string.Format("{0:f2}", priceWithAppliedTax), taxValue.rate));

            return sb.ToString();
        }
    }
}