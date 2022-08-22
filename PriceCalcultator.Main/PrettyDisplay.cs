using System;
using System.Text;

namespace PriceCalcultator.Main
{
    public class PrettyDisplay
    {
        public string GetFormatedReturn(Product product, TaxRate taxValue)
        {
           return new StringBuilder()
                .Append(product.ToString())
                .Append(System.Environment.NewLine)
                .Append(product.ToStringWithTaxe(taxValue))
                .ToString();
        }
    }
}