namespace _010___SomasSucessivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double soma = 0;

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Qual o {i+1}º número: ");
                double  numero = Convert.ToDouble(Console.ReadLine());
                soma += numero;
            }
            double media = soma / num;
            Console.WriteLine($"Média = {media}");
        }
    }
}