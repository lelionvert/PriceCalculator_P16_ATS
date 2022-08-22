namespace PriceCalcultator.Tests
{
    public class TaxRate
    {
        public double rate;
        
        public double ConvertTaxRateToPercentage()
        {
            return (1 + (this.rate / 100));
        }
    }
}