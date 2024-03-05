using System.Security.AccessControl;
using System.Security.Cryptography;

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
            int opcao = 0;
            sColaborador[] aColaboradores = new sColaborador[0];

            do
            {
                opcao = Menu();
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        InserirColab(ref aColaboradores);
                        break;
                    case 2:
                        ListarColab(aColaboradores);
                        break;
                    case 3:
                        ConsultarColaborador(aColaboradores);
                        break;
                    case 4:
                        AlterarDados(ref aColaboradores);
                        break;
                    default:
                        Console.WriteLine("Opção não existe.");
                        break;
                }
            } while (opcao != 0);
            Console.ReadLine();
        }
        static int Menu()
        { 
            Console.WriteLine("------------MENU------------");
            Console.WriteLine("1 - Inserir Colaboradores.");
            Console.WriteLine("2 - Listar Colaboradores.");
            Console.WriteLine("3 - Consultar Colaborador.");
            Console.WriteLine("4 - Alterar Dados Colaborador.");
            Console.WriteLine("0 - Sair do programa");
            Console.WriteLine("----------------------------");

            Console.Write("Digite uma opção.");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void InserirColab(ref sColaborador[] aColaboradores)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Inserir-------------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("Quantos colaboradores quer inserir?");
            int nColab = Convert.ToInt32(Console.ReadLine());
        
            //Verificar tamanho do array atual
            int tamanhoAtual = aColaboradores.Length;
            //Obter tamanho total
            int novoTamanhoArray = tamanhoAtual + nColab;
            //Redimensionar o array para o novoTamanhoArray
            Array.Resize(ref aColaboradores, novoTamanhoArray);
            //Inserir os dados no array

            for(int i = tamanhoAtual; i < novoTamanhoArray; i++)
            {
                Console.WriteLine("--- Inserir Dados ---");

                bool fNumValido = false;
                do
                {
                    Console.Write("Inserir o código: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    if (VerificaCodigo(aColaboradores, codigo)) //Verifica se se o codigo do colab já está em uso ou não
                    {
                        aColaboradores[i].codColab = codigo;
                        fNumValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Código Existente!");
                    }
                } while (!fNumValido);
                
                Console.Write("Inserir o nome: ");
                aColaboradores[i].nomColab = Console.ReadLine();

                Console.Write("Inserir a morada: ");
                aColaboradores[i].morColab = Console.ReadLine();

                Console.Write("Inserir o género: ");
                aColaboradores[i].genColab = Console.ReadLine();

                Console.Write("Inserir a idade: ");
                aColaboradores[i].idaColab = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserir o vencimento: ");
                aColaboradores[i].venColab = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPressione ENTER p/ Continuar");
                Console.ReadLine();
                Console.Clear();
            }

        }
        static void ListarColab(sColaborador[] aColaboradores)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Listagem------------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("APRESENTAÇÃO DOS DADOS");
            for (int i = 0; i < aColaboradores.Length; i++)
            {
                Console.WriteLine(
                    $"--- Colaborador ---\n"+
                    $"Código: {aColaboradores[i].codColab}\n" +
                    $"Nome: {aColaboradores[i].nomColab}\n" +
                    $"Morada: {aColaboradores[i].morColab}\n" +
                    $"Género: {aColaboradores[i].genColab} \n" +
                    $"Idade: {aColaboradores[i].idaColab} \n" +
                    $"Vencimento: {aColaboradores[i].venColab}\n"+
                    $"--------------------\n"
                    );
            }
            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }
        static bool VerificaCodigo(sColaborador[] aColaboradores, int num)
        {
            for (int i = 0; i < aColaboradores.Length; i++)
            {
                if (num == aColaboradores[i].codColab)
                {
                    return false;
                }
            }
            return true;
        }
        static void ConsultarColaborador(sColaborador[] aColaboradores)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Consulta------------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("Qual o codigo do colaborador a consultar?");
            int codigoColab = Convert.ToInt32(Console.ReadLine());
            if (!VerificaCodigo(aColaboradores, codigoColab))
            {
                for (int i = 0; i < aColaboradores.Length; i++)
                {
                    if (codigoColab == aColaboradores[i].codColab)
                    {
                        Console.WriteLine(
                        $"--- Colaborador ---\n" +
                        $"Código: {aColaboradores[i].codColab}\n" +
                        $"Nome: {aColaboradores[i].nomColab}\n" +
                        $"Morada: {aColaboradores[i].morColab}\n" +
                        $"Género: {aColaboradores[i].genColab} \n" +
                        $"Idade: {aColaboradores[i].idaColab} \n" +
                        $"Vencimento: {aColaboradores[i].venColab}\n" +
                        $"--------------------\n"
                        );

                        Console.WriteLine("\nPressione ENTER p/ Continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                }
            }
            Console.WriteLine("Esse codigo não existe!");

        }
        static void AlterarDados(ref sColaborador[] aColaboradores)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("----------AlterarDados----------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("Qual o codigo do colaborador a alterar?");
            int codigoColab = Convert.ToInt32(Console.ReadLine());

            if (!VerificaCodigo(aColaboradores, codigoColab))
            {
                for (int i = 0; i < aColaboradores.Length; i++)
                {
                    if (codigoColab == aColaboradores[i].codColab)
                    {
                        Console.Write("Quer alterar um(1) ou os dados todos(2)?");
                        int opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao == 1)
                        {
                            Console.WriteLine("Qual o dado que quer alterar?");
                            Console.WriteLine("1 - Nome");
                            Console.WriteLine("2 - Morada");
                            Console.WriteLine("3 - Género");
                            Console.WriteLine("4 - Idade");
                            Console.WriteLine("5 - Vencimento");
                            int opcao2 = Convert.ToInt32(Console.ReadLine());

                            switch (opcao2)
                            {
                                case 1:
                                    Console.Write("Inserir o nome: ");
                                    aColaboradores[i].nomColab = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Write("Inserir a morada: ");
                                    aColaboradores[i].morColab = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Inserir o género: ");
                                    aColaboradores[i].genColab = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Write("Inserir a idade: ");
                                    aColaboradores[i].idaColab = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 5:
                                    Console.Write("Inserir o vencimento: ");
                                    aColaboradores[i].venColab = Convert.ToInt32(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Opção não existe.");
                                    break;
                            }
                        }
                        else if (opcao == 2)
                        {
                            Console.Write("Inserir o nome: ");
                            aColaboradores[i].nomColab = Console.ReadLine();

                            Console.Write("Inserir a morada: ");
                            aColaboradores[i].morColab = Console.ReadLine();

                            Console.Write("Inserir o género: ");
                            aColaboradores[i].genColab = Console.ReadLine();

                            Console.Write("Inserir a idade: ");
                            aColaboradores[i].idaColab = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Inserir o vencimento: ");
                            aColaboradores[i].venColab = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Operação Inválida!");
                        }

                        Console.WriteLine("\nPressione ENTER p/ Continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                }
            }
            Console.WriteLine("Esse codigo não existe!");

        }
    }
}