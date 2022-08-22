using System;
using System.Text;

namespace PriceCalcultator.Main
{
    public class PrettyDisplay
    {
        public string GetFormatedReturn(Product product, TaxRate taxValue)
        {
            StringBuilder sb = new StringBuilder();
            double priceWithAppliedTax = product.ApplyTax(taxValue);
            string priceWithAppliedTaxAsString = product.ConvertPriceToString(priceWithAppliedTax);

            sb.AppendLine(product.ToString());
            sb.Append(product.ToStringWithTaxe(taxValue));

            return sb.ToString();
        }
    }
}