using System;
using System.Text;

namespace PriceCalcultator.Main
{
    public class PrettyDisplay
    {
        public string GetFormatedReturn(Product product, TaxRate taxValue)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(product.ToString());
            sb.Append(System.Environment.NewLine);
            sb.Append(product.ToStringWithTaxe(taxValue));

            return sb.ToString();
        }
    }
}