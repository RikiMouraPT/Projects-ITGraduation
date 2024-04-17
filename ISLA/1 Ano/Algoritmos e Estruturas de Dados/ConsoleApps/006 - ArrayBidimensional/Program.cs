namespace _006___ArrayBidimensional
{
    internal class Program
    {// Ricardo Moura 17/04/2024
        static void Main(string[] args)
        {
            //Definir um array bidimensional
            int linhas = 2, colunas = 3;

            int[,] matrizA = new int[linhas, colunas];
            int[,] matrizB = new int[linhas, colunas];

            InserirDados(matrizA, matrizB);
            MultiplicarMatriz(matrizA, matrizB);
            
        }

        static void InserirDados(int[,] matrizA, int[,] matrizB)
        {
            
            for (int i = 0; i < matrizA.GetLength(0); i++)//Neste caso a dimensão é 2
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)//Neste caso a dimensão é de 3
                {
                    Console.Write($"A- [{i},{j}] = ");
                    matrizA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write($"B- [{i},{j}] = ");
                    matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void MultiplicarMatriz(int[,] matrizA, int[,] matrizB)
        {
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.WriteLine($"A[{i},{j}] * B[{i},{j}] = {matrizA[i, j] * matrizB[i, j]}");
                }
            }
            Console.WriteLine("Clique ENTER p/ continuar.");
            Console.ReadKey();
        }
    }
}