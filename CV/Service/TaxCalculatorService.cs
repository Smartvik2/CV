using CV.Interface;

namespace CV.Service
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        public decimal Calculate(decimal salary)
        {
            decimal remaining = salary, tax = 0;
            var bands = new (decimal Band, decimal Rate)[]
            {
                (300_000m, 0.07m),
                (300_000m, 0.11m),
                (500_000m, 0.15m),
                (500_000m, 0.19m),
                (1_600_000m, 0.21m),
            };
            foreach (var (bandAmt, rate) in bands)
            {
                if (remaining <= 0) break;
                var taxable = Math.Min(remaining, bandAmt);
                tax += taxable * rate;
                remaining -= taxable;
            }
            if (remaining > 0) tax += remaining * 0.24m;
            return tax;
        }
    }
}
