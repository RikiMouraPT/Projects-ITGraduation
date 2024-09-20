namespace _009___Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] fib10 = new int[10];
            fib10[0] = 0;
            fib10[1] = 1;

            Console.Write($"{fib10[0]}, {fib10[1]}, ");
            for (int i = 2; i < fib10.Length; i++) 
            {
                fib10[i] = fib10[i - 1] + fib10[i - 2];
                Console.Write($"{fib10[i]}, ");
                
            }
            Console.ReadKey();
        }
    }
}