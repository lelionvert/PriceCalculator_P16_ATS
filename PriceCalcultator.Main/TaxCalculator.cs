using System;

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
            throw new NotImplementedException();
        }
    }
}