using PriceCalcultator.Tests;
using System;
using System.Text;

namespace PriceCalcultator.Tests
{
    public class PrettyDisplay
    {

        public string GetFormatedReturn(Product book, TaxRate taxValue)
        {
            StringBuilder sb = new StringBuilder();
            double priceWithAppliedTax = book.ApplyTax(taxValue);
            string priceWithAppliedTaxAsString = book.ConvertPriceToString(priceWithAppliedTax);

            sb.AppendLine(book.ToString());
            sb.Append(string.Format("Product price reported as ${0} before tax and ${1} after {2} % tax.", book.price, priceWithAppliedTaxAsString, taxValue.rate));

            return sb.ToString();
        }
    }
}