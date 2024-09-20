using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CompoundInterest
{
    internal class Investment
    {
        public decimal InitialInvestment { get; set; }
        public decimal MonthlyContribution { get; set; }
        public decimal InterestRate { get; set; }
        public decimal InterestRateRange { get; set; }
        public double Years { get; set; }

        private int _compoundFrequency;
        public int CompoundFrequency 
        {
            get
            {
                return _compoundFrequency;
            }
            set
            {
                if (value != 1 && value != 2 && value != 4 && value != 12)
                {
                    throw new ArgumentException("Compound frequency must be 1, 2, 4 or 12.");
                }
                _compoundFrequency = value;
            }
        }

        public Investment(decimal initialInvestment, decimal monthlyContribution, double years, decimal interestRate, decimal interestRateRange, int compoundFrequency)
        {
            InitialInvestment = initialInvestment;
            MonthlyContribution = monthlyContribution;
            InterestRate = interestRate;
            InterestRateRange = interestRateRange;
            Years = years;
            CompoundFrequency = compoundFrequency;
        }

        public decimal CalculateInterest()
        {
            decimal finalValue = InitialInvestment;
            decimal yearValue;

            int totalPeriods = (int)Years * CompoundFrequency;
            decimal periodInterestRate = InterestRate / CompoundFrequency / 100;
            decimal pediodMonthlyContribution = MonthlyContribution * (12 / CompoundFrequency);

            for (int i = 0; i < totalPeriods; i++)
            {
                yearValue = finalValue * (1 + periodInterestRate);
                yearValue += pediodMonthlyContribution;
                finalValue = yearValue;
            }

            return finalValue;
        }

        public decimal InterestVariance(string sinal)
        {
            decimal finalValue = InitialInvestment;
            decimal yearValue;

            int totalPeriods = (int)Years * CompoundFrequency;
            decimal periodInterestRate = InterestRate / CompoundFrequency / 100;
            decimal periodInterestRateRange = InterestRateRange / CompoundFrequency / 100;
            decimal pediodMonthlyContribution = MonthlyContribution * (12 / CompoundFrequency);

            if (sinal == "+")
                {
                    for (int i = 0; i < totalPeriods; i++)
                    {
                        yearValue = finalValue * (1 + periodInterestRate + periodInterestRateRange);
                        yearValue += pediodMonthlyContribution;
                        finalValue = yearValue;
                    }
            }
            else if (sinal == "-")
                {
                    for (int i = 0; i < totalPeriods; i++)
                    {
                        yearValue = finalValue * (1 + periodInterestRate - periodInterestRateRange);
                        yearValue += pediodMonthlyContribution;
                        finalValue = yearValue;
                    }
            }
            return finalValue;
        }
    }
}
