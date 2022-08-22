namespace PriceCalcultator.Main
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