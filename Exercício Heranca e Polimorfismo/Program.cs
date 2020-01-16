using System;
using System.Globalization;
using System.Collections.Generic;
using Exercício_Heranca_e_Polimorfismo.Entities;


namespace Exercício_Heranca_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healtExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annualIncome, healtExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, annualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxes Paid:");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer);
            }

            double sum = 0.0;
            foreach(TaxPayer taxPayer in list)
            {
                sum += taxPayer.Tax();

            }

            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
