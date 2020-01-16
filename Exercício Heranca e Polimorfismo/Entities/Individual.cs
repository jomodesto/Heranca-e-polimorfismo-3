namespace Exercício_Heranca_e_Polimorfismo.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnnualIcome < 20000)
            {
                return (AnnualIcome * 0.15) - (HealthExpenditures * 0.5);
            }

            else
            {
                return (AnnualIcome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
