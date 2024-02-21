namespace _002.ArrayDeEstruturas
{
    internal class Program
    {
        struct sColaborador
        {//Definição da estrutura Colaborador.
            public int codColab;
            public string nomColab, morColab, genColab;
            public int idaColab;
            public double venColab;

        }
        static void Main(string[] args)
        {
            sColaborador Ricardo = new sColaborador();

            Console.WriteLine("Gestão de Colaboradores");

            Console.Write("Inserir o código: ");
            Ricardo.codColab = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserir o nome: ");
            Ricardo.nomColab = Console.ReadLine();

            Console.Write("Inserir a morada: ");
            Ricardo.morColab = Console.ReadLine();

            Console.Write("Inserir o género: ");
            Ricardo.genColab = Console.ReadLine();

            Console.Write("Inserir a idade: ");
            Ricardo.idaColab = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserir o vencimento: ");
            Ricardo.venColab = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("APRESENTAÇÃO DOS DADOS");

            Console.WriteLine(
                $"Código: {Ricardo.codColab}\n" +
                $"Nome: {Ricardo.nomColab}\n" +
                $"Morada: {Ricardo.morColab}\n" +
                $"Género: {Ricardo.genColab} \n" +
                $"Idade: {Ricardo.idaColab} \n" +
                $"Vencimento: {Ricardo.venColab}"
                );

            Console.ReadLine();
        }
    }
}