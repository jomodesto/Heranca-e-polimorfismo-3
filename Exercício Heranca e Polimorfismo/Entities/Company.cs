using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Heranca_e_Polimorfismo.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if(NumberOfEmployees > 10)
            {
                return AnnualIcome * 0.14;
            }
            else
            {
                return AnnualIcome * 0.16;
            }
        }
    }
}
