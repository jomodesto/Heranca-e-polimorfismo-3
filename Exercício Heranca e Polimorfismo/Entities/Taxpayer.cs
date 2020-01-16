using System.Globalization;

namespace Exercício_Heranca_e_Polimorfismo.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnnualIcome { get; set; }

        public TaxPayer()
        {

        }

        protected TaxPayer(string name, double annualIcome)
        {
            Name = name;
            AnnualIcome = annualIcome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
