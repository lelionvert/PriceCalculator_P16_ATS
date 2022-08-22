namespace PriceCalcultator.Main
{
    public class TaxRate
    {
        private double rate;

        public TaxRate(double rate)
        {
            this.rate = rate;
        }

        public double ConvertTaxRateToPercentage()
        {
            return (1 + (this.rate / 100));
        }

        public override string ToString()
        {
            return rate.ToString();
        }
    }
}