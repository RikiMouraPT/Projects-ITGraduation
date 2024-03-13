using System.Security.AccessControl;
using System.Security.Cryptography;
using System;
using System.IO;
using System.Text;
using System.Globalization;

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
                    case 5:
                        EliminarColaborador(ref aColaboradores);
                        break;
                    case 6:
                        GuardarFicheiro(aColaboradores);
                        break;
                    case 7:
                        LerFicheiro(ref aColaboradores);
                        break;
                    case 8:
                        MaxMinMedVencimento(aColaboradores);
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
            Console.WriteLine("5 - Remover Colaborador.");
            Console.WriteLine("6 - Guardar Ficheiro.");
            Console.WriteLine("7 - Ler Ficheiro.");
            Console.WriteLine("8 - Max,Min e Média dos salários.");
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

            for (int i = tamanhoAtual; i < novoTamanhoArray; i++)
            {
                Console.WriteLine("--- Inserir Dados ---");

                bool fNumValido = false;
                do
                {
                    Console.Write("Inserir o código: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    if (!VerificaCodigo(aColaboradores, codigo)) //Verifica se se o codigo do colab já está em uso ou não
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
                    $"--- Colaborador ---\n" +
                    $"Código: {aColaboradores[i].codColab}\n" +
                    $"Nome: {aColaboradores[i].nomColab}\n" +
                    $"Morada: {aColaboradores[i].morColab}\n" +
                    $"Género: {aColaboradores[i].genColab} \n" +
                    $"Idade: {aColaboradores[i].idaColab} \n" +
                    $"Vencimento: {aColaboradores[i].venColab}\n" +
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
                    return true;
                }
            }
            return false;
        }
        static void ConsultarColaborador(sColaborador[] aColaboradores)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Consulta------------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("Qual o codigo do colaborador a consultar?");
            int codigoColab = Convert.ToInt32(Console.ReadLine());
            if (VerificaCodigo(aColaboradores, codigoColab))
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

            ListarColab(aColaboradores);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("----------AlterarDados----------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("Qual o codigo do colaborador a alterar?");
            int codigoColab = Convert.ToInt32(Console.ReadLine());

            if (VerificaCodigo(aColaboradores, codigoColab))
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
        static void EliminarColaborador(ref sColaborador[] aColaboradores)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Eliminar------------");
            Console.WriteLine("--------------------------------\n");
            ListarColab(aColaboradores);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Eliminar------------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("Qual o codigo do colaborador a apagar?");
            int codigoColab = Convert.ToInt32(Console.ReadLine());

            if (VerificaCodigo(aColaboradores, codigoColab))
            {
                for (int i = 0; i < aColaboradores.Length; i++)
                {
                    if (codigoColab == aColaboradores[i].codColab)
                    {
                        for (int j = i; j < aColaboradores.Length - 1; j++)
                        {
                            aColaboradores[j].codColab = aColaboradores[j + 1].codColab;
                            aColaboradores[j].nomColab = aColaboradores[j + 1].nomColab;
                            aColaboradores[j].morColab = aColaboradores[j + 1].morColab;
                            aColaboradores[j].idaColab = aColaboradores[j + 1].idaColab;
                            aColaboradores[j].genColab = aColaboradores[j + 1].genColab;
                            aColaboradores[j].venColab = aColaboradores[j + 1].venColab;
                        }

                        Array.Resize(ref aColaboradores, aColaboradores.Length - 1);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("-----------Nova Lista-----------");
                        Console.WriteLine("--------------------------------\n");
                        ListarColab(aColaboradores);
                    }
                }
            }
            Console.WriteLine("Esse codigo não existe!");
        }
        static void GuardarFicheiro(sColaborador[] aColaboradores)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-------FICHEIRO GUARDADO--------");
            Console.WriteLine("--------------------------------\n");

            string dados = "Código; Nome; Morada; Género; Idade; Vencimento\n";
            for (int i = 0; i < aColaboradores.Length; i++)
            {
                dados += $"{aColaboradores[i].codColab};{aColaboradores[i].nomColab};{aColaboradores[i].morColab};{aColaboradores[i].genColab};{aColaboradores[i].idaColab};{aColaboradores[i].venColab}\n";
            }
            string path = "C:\\Users\\a22309442\\Desktop\\colaboradores.csv";
            //string path = "C:\\Users\\rikim\\OneDrive\\Ambiente de Trabalho\\colaboradores.csv";
            File.WriteAllText(path, dados, Encoding.UTF8);
        }
        static void LerFicheiro(ref sColaborador[] aColaboradores)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("---------FICHEIRO LIDO----------");
            Console.WriteLine("--------------------------------\n");

            // string path = "C:\\Users\\rikim\\OneDrive\\Ambiente de Trabalho\\colaboradores.csv";
            string path = "C:\\Users\\a22309442\\Desktop\\colaboradores.csv";
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            Array.Resize(ref aColaboradores, lines.Length - 1);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] colunas = lines[i].Split(";");

                aColaboradores[i - 1].codColab = Convert.ToInt32(colunas[0]);
                aColaboradores[i - 1].nomColab = colunas[1];
                aColaboradores[i - 1].morColab = colunas[2];
                aColaboradores[i - 1].genColab = colunas[3];
                aColaboradores[i - 1].idaColab = Convert.ToInt32(colunas[4]);
                aColaboradores[i - 1].venColab = Convert.ToInt32(colunas[5]);
            }
        }
        static void MaxMinMedVencimento(sColaborador[] aColaboradores)
        {
            double max = aColaboradores[0].venColab;
            double min = aColaboradores[0].venColab;
            double soma = 0;
            for (int i = 0; i < aColaboradores.Length; i++)
            {
                if (aColaboradores[i].venColab > max)
                {
                    max = aColaboradores[i].venColab;
                }
                else if (aColaboradores[i].venColab < min)
                {
                    min = aColaboradores[i].venColab;
                }
                soma += aColaboradores[i].venColab;
            }
            float media = (float) (soma / aColaboradores.Length);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------VALORES-------------");
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("-----------MAIOR-----------");
            Console.WriteLine($"O maior vencimento é: {max}");
            Console.WriteLine("-----------MENOR-----------");
            Console.WriteLine($"O menor vencimento é: {min}");
            Console.WriteLine("-----------MEDIO-----------");
            Console.WriteLine($"A media vencimento é: {media}");
            Console.WriteLine();

        }
    }
}