namespace _007___ArrayTridimensional
{
    internal class Program
    {//Ricardo Moura 17/04/2024
        static void Main(string[] args)
        {
            int[,,] aTrid = new int[2,3,4];

            InserirDados(aTrid);
            ListarDados(aTrid);
        }
        static void InserirDados(int[,,] aTrid)
        {
            for (int i = 0; i < aTrid.GetLength(0); i++)
            {
                for (int j = 0; j < aTrid.GetLength(1); j++)
                {
                    for (int k = 0; k < aTrid.GetLength(2); k++)
                    {
                        Console.Write($"A - [{i}, {j}, {k}] = ");
                        aTrid[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
        static void ListarDados(int[,,] aTrid)
        {
            Console.WriteLine("ListagemListagemListagemListagemListagemListagem");
            for (int i = 0; i < aTrid.GetLength(0); i++)
            {
                for (int j = 0; j < aTrid.GetLength(1); j++)
                {
                    for (int k = 0; k < aTrid.GetLength(2); k++)
                    {
                        Console.WriteLine($"A - [{i}, {j}, {k}] = {aTrid[i,j,k]}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}