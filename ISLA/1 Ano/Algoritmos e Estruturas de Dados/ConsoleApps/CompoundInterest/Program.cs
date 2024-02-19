namespace CompoundInterest
{
    internal class Program
    {//Autor: Ricardo Moura 18/02/2024
     //Programa para calcular juros compostos

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Compound Interest Calculator");
            Console.WriteLine("----------------------------\n");
            Investment? investment = null;

            while (true)  
            {
                int opcao = Menu();
                switch (opcao)
                {
                    case 1:
                        investment = PopulateData();
                        break;
                    case 2:
                        if (investment == null)
                        {
                            Console.WriteLine("Please populate data first.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Initial Investment: " + investment.InitialInvestment);
                            Console.WriteLine("Monthly Contribution: " + investment.MonthlyContribution);
                            Console.WriteLine("Lenght of time in years: " + investment.Years);
                            Console.WriteLine("Interest Rate: " + investment.InterestRate);
                            Console.WriteLine("Interest rate variance range: " + investment.InterestRateRange);
                            Console.WriteLine("Times per year that interest will be compounded: " + investment.CompoundFrequency);
                            Console.WriteLine("\nPress ENTER to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }   
                    case 3:
                        if (investment == null)
                        {
                            Console.WriteLine("Please populate data first.");
                            break;
                        }
                        else
                        {
                            CalculateInterest(investment);
                            break;
                        }
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }

        static int Menu()
        {
            Console.WriteLine("---------MENU---------");
            Console.WriteLine("1 - Populate Data.");
            Console.WriteLine("2 - Current Data");
            Console.WriteLine("3 - Calculate Interest.");
            Console.WriteLine("0 - Exit.");
            Console.WriteLine("----------------------");

            Console.Write("Option: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return opcao;
        }
        
        public static Investment PopulateData()
        {
            Console.Write("Inicial Investment: ");
            decimal initialInvestment = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Monthly Contribution: ");
            decimal monthlyContribution = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Lenght of time in years: ");
            double years = Convert.ToDouble(Console.ReadLine());

            Console.Write("Interest Rate: ");
            decimal interestRate = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Interest rate variance range: ");
            decimal interestRateRange = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Times per year that interest will be compounded(1- Anually/ 2- Semiannualy/ 4- Quarterly/ 12- Monthly): ");
            int compoundFrequency = Convert.ToInt32(Console.ReadLine());

            Investment investment = new(initialInvestment, monthlyContribution, years, interestRate, interestRateRange, compoundFrequency);

            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            return investment;
        }

        static void CalculateInterest(Investment investment)
        {
            decimal totalValue = investment.CalculateInterest();

            Console.WriteLine($"Total value in the end of {investment.Years} years with {investment.InterestRate}%: {totalValue:C2}");

            Console.WriteLine($"\nVariances of {investment.InterestRateRange}%: ");
            Console.WriteLine($"With {investment.InterestRate + investment.InterestRateRange}%: {investment.InterestVariance("+"):C2}");
            Console.WriteLine($"With {investment.InterestRate - investment.InterestRateRange}%: {investment.InterestVariance("-"):C2}");

            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
        }
       
    } 
}
