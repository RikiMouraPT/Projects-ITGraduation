namespace _012___Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o número? ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Resultado do fatorial de {num} é {fatorial(num)}");
            Console.ReadKey();
        }
        public static double fatorial(double n)
        {
            if (n == 1)
            {
                return 1;
            }
            else 
            {
                return n * fatorial(n - 1);
            }
        }
    }
}