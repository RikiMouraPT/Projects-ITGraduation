using System.Security.AccessControl;
using System.Security.Cryptography;
using System;
using System.IO;
using System.Text;
using System.Globalization;
using System.Diagnostics;

namespace _003___ArrayDeEstruturas_Exercicio
{//Feito por: RicardoMoura e VitorRocha
    internal class Program
    {
        struct sAluno
        {//Definição da estrutura Colaborador.
            public string codAlu, nomAlu;
            public int idaAlu;
            public float medAlu, propAlu, salAlu;
            public bool teveDivida; //Para saber se o aluno já esteve em divida.
        }
        static void Main(string[] args)
        {
            int opcao = 0;
            //Definição do array de estruturas.
            sAluno[] aAlunos = new sAluno[0];
            do
            {
                opcao = Menu();
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        InserirAluno(ref aAlunos);
                        break;
                    case 2:
                        ListagemAlunos(aAlunos);
                        break;
                    case 3:
                        ConsultarAluno(aAlunos);
                        break;
                    case 4:
                        AlterarAluno(ref aAlunos);
                        break;
                    case 5:
                        EliminarAluno(ref aAlunos);
                        break;
                    case 6:
                        PagarPropinas(ref aAlunos);
                        break;
                    case 7:
                        ListagemDividas(aAlunos);
                        break;
                    case 8:
                        ListagemDividasProximas(aAlunos);
                        break;
                    case 9:
                        CarregarSaldo(ref aAlunos);
                        break;
                    case 10:
                        CalcularMelhorPiorAluno(aAlunos);
                        break;
                    case 11:
                        CalcularAlunoSemDividas(aAlunos);
                        break;
                    case 12:
                        GuardarFicheiro(aAlunos);
                        break;
                    case 13:
                        LerFicheiro(ref aAlunos);
                        break;
                    case 20:
                        MediaIdades(aAlunos);
                        break;
                    case 21:
                        MediaMedias(aAlunos);
                        break;
                    case 22:
                        MediaSaldos(aAlunos);
                        break;
                    case 23:
                        PercentagemDividas(aAlunos);
                        break;
                    case 0:
                        Console.WriteLine("A fechar...");
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
            Console.WriteLine("1 - Inserir Aluno.");
            Console.WriteLine("2 - Listagem de registos de Alunos.");
            Console.WriteLine("3 - Consultar o registo de um Aluno.");
            Console.WriteLine("4 - Alterar dados de Aluno");
            Console.WriteLine("5 - Eliminar Aluno.");
            Console.WriteLine("6 - Pagar propinas (todos os alunos).");
            Console.WriteLine("7 - Listagem de dívidas.");
            Console.WriteLine("8 - Listagem de dívidas proximas.");
            Console.WriteLine("9 - Carregar o saldo de um Aluno.");
            Console.WriteLine("10 - Calcular melhor e pior Aluno sem dívidas.");
            Console.WriteLine("11 - Calcular Aluno que nunca teve dívidas.");
            Console.WriteLine("----------Ficheiro----------");
            Console.WriteLine("12 - Guardar Ficheiro.");
            Console.WriteLine("13 - Ler Ficheiro.");
            Console.WriteLine("--------Estatísticas--------");
            Console.WriteLine("20 - Média de idades.");
            Console.WriteLine("21 - Média das médias. ");
            Console.WriteLine("22 - Média dos saldos.");
            Console.WriteLine("23 - Percentagem de Alunos com dividas.");
            Console.WriteLine("\n0 - Sair do programa");
            Console.WriteLine("----------------------------");

            Console.Write("Digite uma opção.");
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                return -1;
            }
        }
        static void InserirAluno(ref sAluno[] aAlunos)//Função para inserir um ou vários alunos.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Inserir-------------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("Quantos Alunos quer inserir?");
            int nAlunos = Convert.ToInt32(Console.ReadLine());

            //Verificar tamanho do array atual
            int tamanhoAtual = aAlunos.Length;
            //Obter tamanho total
            int novoTamanhoArray = tamanhoAtual + nAlunos;
            //Redimensionar o array para o novoTamanhoArray
            Array.Resize(ref aAlunos, novoTamanhoArray);
            //Inserir os dados no array
            for (int i = tamanhoAtual; i < novoTamanhoArray; i++)
            {
                //Inserir os dados de acordo com as validações definidas nas funções de Validação no fim do codigo.
                string codigo;
                do
                {
                    Console.Write("Inserir o código do Aluno: ");
                    codigo = Console.ReadLine();
                    if (CodigoExiste(aAlunos, codigo))
                    {
                        Console.WriteLine("ERRO - Esse código já existe!");
                    }
                } while (!ValidarCodigo(codigo) || CodigoExiste(aAlunos, codigo));
                aAlunos[i].codAlu = codigo;
                do
                {
                    Console.Write("Inserir o nome do Aluno: ");
                    aAlunos[i].nomAlu = Console.ReadLine();
                } while (!ValidarNome(aAlunos[i].nomAlu));
                do
                {
                    Console.Write("Inserir a idade do Aluno: ");
                    aAlunos[i].idaAlu = Convert.ToInt32(Console.ReadLine());
                } while (!ValidarIdade(aAlunos[i].idaAlu));
                do
                {
                    Console.Write("Inserir a média do Aluno: ");
                    aAlunos[i].medAlu = Convert.ToSingle(Console.ReadLine());
                } while (!ValidarMedia(aAlunos[i].medAlu));
                do
                {
                    Console.Write("Inserir a propina do Aluno: ");
                    aAlunos[i].propAlu = Convert.ToSingle(Console.ReadLine());
                } while (!ValidarPropina(aAlunos[i].propAlu));
                do
                {
                    Console.Write("Inserir o saldo do Aluno: ");
                    aAlunos[i].salAlu = Convert.ToSingle(Console.ReadLine());
                } while (!ValidarSaldo(aAlunos[i].salAlu));
                
                aAlunos[i].teveDivida = false;
            }
        }
        static void ListagemAlunos(sAluno[] aAlunos)//Função para listar todos os alunos.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Listagem------------");
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine($"{"Codigo",-9} {"Nome",-20} {"Idade",-7} {"Média",-8:N2} {"Propina",-9:N2} {"Saldo",-8:N2} {"TeveDivida", -10}");
            for (int i = 0; i < aAlunos.Length; i++)
            {
                Console.WriteLine($"{aAlunos[i].codAlu,-9} {aAlunos[i].nomAlu,-20} {aAlunos[i].idaAlu,-7} {aAlunos[i].medAlu,-8:N2} {aAlunos[i].propAlu,-9:N2} {aAlunos[i].salAlu,-8:N2} {aAlunos[i].teveDivida, -10}");
            }
            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }
        static void ConsultarAluno(sAluno[] aAlunos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-----------Consultar------------");
            Console.WriteLine("--------------------------------\n");
            
            string codigoAluno;
            do
            {
                Console.WriteLine("Qual o código do Aluno a consultar?");
                codigoAluno = Console.ReadLine();

                if (!CodigoExiste(aAlunos, codigoAluno))
                {
                    Console.WriteLine("ERRO - Esse código não existe!");
                }
            } while (!ValidarCodigo(codigoAluno) || !CodigoExiste(aAlunos, codigoAluno));

            for (int i = 0; i < aAlunos.Length; i++)
            {
                if (codigoAluno == aAlunos[i].codAlu)
                {
                    Console.WriteLine(
                        "------- Aluno ------\n" +
                        $"Código: {aAlunos[i].codAlu}\n" +
                        $"Nome: {aAlunos[i].nomAlu}\n" +
                        $"Idade: {aAlunos[i].idaAlu}\n" +
                        $"Média: {aAlunos[i].medAlu} \n" +
                        $"Propina: {aAlunos[i].propAlu} \n" +
                        $"Saldo: {aAlunos[i].salAlu}\n" +
                        "--------------------\n");
                    Console.WriteLine("\nPressione ENTER para Continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
            }
        }
        static void AlterarAluno(ref sAluno[] aAlunos)//Função para alterar os dados de um aluno.
        {
            ListagemAlunos(aAlunos);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Alterar-------------");
            Console.WriteLine("--------------------------------\n");

            string codigoAluno;
            do
            {
                Console.Write("Inserir o código do Aluno: ");
                codigoAluno = Console.ReadLine();
                if (!CodigoExiste(aAlunos, codigoAluno))
                {
                    Console.WriteLine("ERRO - Esse código não existe!");
                }
            } while (!ValidarCodigo(codigoAluno) || !CodigoExiste(aAlunos, codigoAluno));

            if (CodigoExiste(aAlunos, codigoAluno))
            {
                for (int i = 0; i < aAlunos.Length; i++)
                {
                    if (codigoAluno == aAlunos[i].codAlu)
                    {
                        Console.Write("Quer alterar um(1) ou os dados todos(2)? ");
                        int opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao == 1)
                        {
                            Console.WriteLine("Qual o dado que quer alterar?");
                            Console.WriteLine("1 - Nome");
                            Console.WriteLine("2 - Idade");
                            Console.WriteLine("3 - Média");
                            Console.WriteLine("4 - Propina");
                            Console.WriteLine("5 - Saldo");
                            int opcao2 = Convert.ToInt32(Console.ReadLine());

                            switch (opcao2)
                            {
                                case 1:
                                    do
                                    {
                                        Console.Write("Inserir o nome do Aluno: ");
                                        aAlunos[i].nomAlu = Console.ReadLine();
                                    } while (!ValidarNome(aAlunos[i].nomAlu));
                                    break;
                                case 2:
                                    do
                                    {
                                        Console.Write("Inserir a idade do Aluno: ");
                                        aAlunos[i].idaAlu = Convert.ToInt32(Console.ReadLine());
                                    } while (!ValidarIdade(aAlunos[i].idaAlu));
                                    break;
                                case 3:
                                    do
                                    {
                                        Console.Write("Inserir a média do Aluno: ");
                                        aAlunos[i].medAlu = Convert.ToSingle(Console.ReadLine());
                                    } while (!ValidarMedia(aAlunos[i].medAlu));
                                    break;
                                case 4:
                                    do
                                    {
                                        Console.Write("Inserir a propina do Aluno: ");
                                        aAlunos[i].propAlu = Convert.ToSingle(Console.ReadLine());
                                    } while (!ValidarPropina(aAlunos[i].propAlu));
                                    break;
                                case 5:
                                    do
                                    {
                                        Console.Write("Inserir o saldo do Aluno: ");
                                        aAlunos[i].salAlu = Convert.ToSingle(Console.ReadLine());
                                    } while (!ValidarSaldo(aAlunos[i].salAlu));
                                    break;
                                default:
                                    Console.WriteLine("Opção não existe.");
                                    break;
                            }
                        }
                        else if (opcao == 2)
                        {
                            do
                            {
                                Console.Write("Inserir o nome do Aluno: ");
                                aAlunos[i].nomAlu = Console.ReadLine();
                            } while (!ValidarNome(aAlunos[i].nomAlu));
                            do
                            {
                                Console.Write("Inserir a idade do Aluno: ");
                                aAlunos[i].idaAlu = Convert.ToInt32(Console.ReadLine());
                            } while (!ValidarIdade(aAlunos[i].idaAlu));
                            do
                            {
                                Console.Write("Inserir a média do Aluno: ");
                                aAlunos[i].medAlu = Convert.ToSingle(Console.ReadLine());
                            } while (!ValidarMedia(aAlunos[i].medAlu));

                            do
                            {
                                Console.Write("Inserir a propina do Aluno: ");
                                aAlunos[i].propAlu = Convert.ToSingle(Console.ReadLine());
                            } while (!ValidarPropina(aAlunos[i].propAlu));
                            do
                            {
                                Console.Write("Inserir o saldo do Aluno: ");
                                aAlunos[i].salAlu = Convert.ToSingle(Console.ReadLine());
                            } while (!ValidarSaldo(aAlunos[i].salAlu));
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
        static void EliminarAluno(ref sAluno[] aAlunos)//Função para eliminar um aluno.
        {
            ListagemAlunos(aAlunos);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------Eliminar------------");
            Console.WriteLine("--------------------------------\n");

            string numAluno;
            do
            {
                Console.Write("Inserir o código do Aluno: ");
                numAluno = Console.ReadLine();
                if (!CodigoExiste(aAlunos, numAluno))
                {
                    Console.WriteLine("ERRO - Esse código não existe!");
                }
            } while (!ValidarCodigo(numAluno) || !CodigoExiste(aAlunos, numAluno));

            do
            {
                for (int i = 0; i < aAlunos.Length; i++)
                {
                    if (numAluno == aAlunos[i].codAlu)
                    {
                        for (int j = i; j < aAlunos.Length - 1; j++)
                        {
                            aAlunos[j].codAlu = aAlunos[j + 1].codAlu;
                            aAlunos[j].nomAlu = aAlunos[j + 1].nomAlu;
                            aAlunos[j].idaAlu = aAlunos[j + 1].idaAlu;
                            aAlunos[j].medAlu = aAlunos[j + 1].medAlu;
                            aAlunos[j].propAlu = aAlunos[j + 1].propAlu;
                            aAlunos[j].salAlu = aAlunos[j + 1].salAlu;
                        }
                        Array.Resize(ref aAlunos, aAlunos.Length - 1);
                        return;
                    }
                }

            } while (ValidarCodigo(numAluno));
        }
        static void PagarPropinas(ref sAluno[] aAlunos)//Função para pagar propinas a um ou todos os alunos.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("---------Pagar Propinas---------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("1 - Pagar as propinas de todos os alunos");
            Console.WriteLine("2 - Pagar as propinas de um aluno");
            Console.WriteLine("0 - Sair");
            int opcao = Convert.ToInt16(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    for (int i = 0; i < aAlunos.Length; i++)
                    {
                        aAlunos[i].salAlu -= aAlunos[i].propAlu;
                        if (aAlunos[i].salAlu < 0)
                        {
                            aAlunos[i].teveDivida = true;
                        }
                    }
                    break;
                case 2:
                    ListagemAlunos(aAlunos);

                    string codigoAluno;
                    do
                    {
                        Console.Write("Inserir o código do Aluno: ");
                        codigoAluno = Console.ReadLine();
                        if (!CodigoExiste(aAlunos, codigoAluno))
                        {
                            Console.WriteLine("ERRO - Esse código não existe!");
                        }
                    } while (!ValidarCodigo(codigoAluno) || !CodigoExiste(aAlunos, codigoAluno));

                    for (int j = 0; j < aAlunos.Length; j++)
                    {
                        if (codigoAluno == aAlunos[j].codAlu)
                        {
                            aAlunos[j].salAlu -= aAlunos[j].propAlu;
                            if (aAlunos[j].salAlu < 0)
                            {
                                aAlunos[j].teveDivida = true;
                            }
                        }
                    }
                    break;
                case 0:
                    Console.WriteLine("A fechar...");
                    break;
            }

        }
        static void ListagemDividas(sAluno[] aAlunos)//Função para listar as dívidas.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("---------Listagem Dividas-------");
            Console.WriteLine("--------------------------------\n");


            Console.WriteLine($"{"Codigo",-9} {"Nome",-20} {"Idade",-7} {"Média",-8:N2} {"Propina",-9:N2} {"Saldo",-8:N2}");
            for (int i = 0; i < aAlunos.Length; i++)
            {
                if (aAlunos[i].salAlu < 0)
                {
                    Console.WriteLine($"{aAlunos[i].codAlu,-9} {aAlunos[i].nomAlu,-20} {aAlunos[i].idaAlu,-7} {aAlunos[i].medAlu,-8:N2} {aAlunos[i].propAlu,-9:N2} {aAlunos[i].salAlu,-8:N2}");

                }
            }
            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();


        }
        static void ListagemDividasProximas(sAluno[] aAlunos)//Função para listar as dívidas próximas.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("----Listagem Dividas Proximas---");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine($"{"Codigo",-9} {"Nome",-20} {"Idade",-7} {"Média",-8:N2} {"Propina",-9:N2} {"Saldo",-8:N2}");
            for (int i = 0; i < aAlunos.Length; i++)
            {
                if (aAlunos[i].salAlu - aAlunos[i].propAlu < 0)
                {
                    Console.WriteLine($"{aAlunos[i].codAlu,-9} {aAlunos[i].nomAlu,-20} {aAlunos[i].idaAlu,-7} {aAlunos[i].medAlu,-8:N2} {aAlunos[i].propAlu,-9:N2} {aAlunos[i].salAlu,-8:N2}");

                }
            }
        }
        static void CarregarSaldo(ref sAluno[] aAlunos)//Função para carregar o saldo de um aluno.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("---------Carregar Saldo---------");
            Console.WriteLine("--------------------------------\n");

            ListagemAlunos(aAlunos);

            string codigoAluno;
            do
            {
                Console.Write("Inserir o código do Aluno: ");
                codigoAluno = Console.ReadLine();
                if (!CodigoExiste(aAlunos, codigoAluno))
                {
                    Console.WriteLine("ERRO - Esse código não existe!");
                }
            } while (!ValidarCodigo(codigoAluno) || !CodigoExiste(aAlunos, codigoAluno));
            
            float saldoACarregar;
            for (int i = 0; i < aAlunos.Length; i++)
            {
                if (codigoAluno == aAlunos[i].codAlu)
                {
                    do
                    {
                        Console.Write("Inserir o saldo do Aluno: ");
                        saldoACarregar = Convert.ToSingle(Console.ReadLine());
                    } while (!ValidarSaldo(saldoACarregar));
                    aAlunos[i].salAlu += saldoACarregar;
                }
            }


        }
        static void CalcularMelhorPiorAluno(sAluno[] aAlunos)//Função para calcular o melhor e o pior aluno sem dívidas.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-Melhor e Pior Aluno Sem Divida-");
            Console.WriteLine("--------------------------------\n");

            float maxMedia = -1;
            float minMedia = 21;
            int maxIndex = -1;
            int minIndex = -1;
            for (int i = 0; i < aAlunos.Length; i++)
            {
                if (aAlunos[i].salAlu >= 0)
                {
                    if (aAlunos[i].medAlu > maxMedia)
                    {
                        maxMedia = aAlunos[i].medAlu;
                        maxIndex = i;
                    }
                    if (aAlunos[i].medAlu < minMedia)
                    {
                        minMedia = aAlunos[i].medAlu;
                        minIndex = i;
                    }
                }
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("----------Melhor Aluno----------");
            Console.WriteLine("--------------------------------");
            if (maxIndex == -1)
            {
                Console.WriteLine("Não há alunos sem divida.");
            }
            else
            {
                Console.WriteLine($"{"Codigo",-9} {"Nome",-20} {"Idade",-7} {"Média",-8:N2} {"Propina",-9:N2} {"Saldo",-8:N2}");
                Console.WriteLine($"{aAlunos[maxIndex].codAlu,-9} {aAlunos[maxIndex].nomAlu,-20} {aAlunos[maxIndex].idaAlu,-7} {aAlunos[maxIndex].medAlu,-8:N2} {aAlunos[maxIndex].propAlu,-9:N2} {aAlunos[maxIndex].salAlu,-8:N2}\n");
            }
            

            Console.WriteLine("--------------------------------");
            Console.WriteLine("-----------Pior Aluno-----------");
            Console.WriteLine("--------------------------------");
            if (minIndex == -1)
            {
                Console.WriteLine("Não há alunos sem divida.");
            }
            else
            {
                Console.WriteLine($"{"Codigo",-9} {"Nome",-20} {"Idade",-7} {"Média",-8:N2} {"Propina",-9:N2} {"Saldo",-8:N2}");
                Console.WriteLine($"{aAlunos[minIndex].codAlu,-9} {aAlunos[minIndex].nomAlu,-20} {aAlunos[minIndex].idaAlu,-7} {aAlunos[minIndex].medAlu,-8:N2} {aAlunos[minIndex].propAlu,-9:N2} {aAlunos[minIndex].salAlu,-8:N2}\n");
            }
            


            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }
        static void CalcularAlunoSemDividas(sAluno[] aAlunos)//Função para calcular o aluno que nunca teve dívidas.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("---Aluno que Nunca Teve Divida--");
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine($"{"Codigo",-9} {"Nome",-20} {"Idade",-7} {"Média",-8:N2} {"Propina",-9:N2} {"Saldo",-8:N2} {"TeveDivida",-10}");
            for (int i = 0; i < aAlunos.Length; i++)
            {
                if (aAlunos[i].teveDivida == false)
                {
                    Console.WriteLine($"{aAlunos[i].codAlu,-9} {aAlunos[i].nomAlu,-20} {aAlunos[i].idaAlu,-7} {aAlunos[i].medAlu,-8:N2} {aAlunos[i].propAlu,-9:N2} {aAlunos[i].salAlu,-8:N2} {aAlunos[i].teveDivida, -10}");
                }
            }
            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }
        //----------------------------------------------------------------------------
        //---------------------------------FICHEIROS----------------------------------
        //----------------------------------------------------------------------------
        static void GuardarFicheiro(sAluno[] aAlunos)//Função para guardar o ficheiro
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("---------Guardar Ficheiro-------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------Ficheiro Guardado-------");
            Console.WriteLine("--------------------------------\n");

            string dados = "Código; Nome; Idade; Média; Propina; Saldo; TeveDivida\n";
            for (int i = 0; i < aAlunos.Length; i++)
            {
                dados += $"{aAlunos[i].codAlu};{aAlunos[i].nomAlu};{aAlunos[i].idaAlu};{aAlunos[i].medAlu};{aAlunos[i].propAlu};{aAlunos[i].salAlu};{aAlunos[i].teveDivida}\n";
            }
            string path = "C:\\Users\\rikim\\OneDrive\\Ambiente de Trabalho\\alunos.csv";
            File.WriteAllText(path, dados, Encoding.UTF8);

            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }
        static void LerFicheiro(ref sAluno[] aAlunos)//Função para ler o ficheiro.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("----------Ler Ficheiro----------");
            Console.WriteLine("--------------------------------\n");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("----------Ficheiro Lido---------");
            Console.WriteLine("--------------------------------\n");

            string path = "C:\\Users\\rikim\\OneDrive\\Ambiente de Trabalho\\alunos.csv";
            string[] linhas = File.ReadAllLines(path);
            //Redimensionar o array para o tamanho do ficheiro.
            Array.Resize(ref aAlunos, linhas.Length - 1);
            //FOR começa em 1 para não ler a primeira linha que é o cabeçalho.
            for (int i = 1; i < linhas.Length; i++)
            {
                string[] campos = linhas[i].Split(';');
                aAlunos[i - 1].codAlu = campos[0];
                aAlunos[i - 1].nomAlu = campos[1];
                aAlunos[i - 1].idaAlu = Convert.ToInt32(campos[2]);
                aAlunos[i - 1].medAlu = Convert.ToSingle(campos[3]);
                aAlunos[i - 1].propAlu = Convert.ToSingle(campos[4]);
                aAlunos[i - 1].salAlu = Convert.ToSingle(campos[5]);
                aAlunos[i - 1].teveDivida = Convert.ToBoolean(campos[6]);
            }

            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }
        //----------------------------------------------------------------------------
        //--------------------------------ESTATISTICAS--------------------------------
        //----------------------------------------------------------------------------
        static void MediaIdades(sAluno[] aAlunos)//Função para calcular a média das idades.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("---------Média das Idades-------");
            Console.WriteLine("--------------------------------\n");
            float somaIdades = 0;

            for (int i = 0; i < aAlunos.Length; i++)
            {
                somaIdades += aAlunos[i].idaAlu;
            }
            Console.WriteLine($"Média das idades: {somaIdades / aAlunos.Length:N2}\n");
        }
        static void MediaMedias(sAluno[] aAlunos)//Função para calcular a média das médias.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("---------Média das Médias-------");
            Console.WriteLine("--------------------------------\n");
            float somaMedias = 0;

            for (int i = 0; i < aAlunos.Length; i++)
            {
                somaMedias += aAlunos[i].medAlu;
            }
            Console.WriteLine($"Média das idades: {somaMedias / aAlunos.Length:N2}\n");

        }
        static void MediaSaldos(sAluno[] aAlunos)//Função para calcular a média dos saldos.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("---------Média dos Saldos-------");
            Console.WriteLine("--------------------------------\n");
            float somaSaldos = 0;

            for (int i = 0; i < aAlunos.Length; i++)
            {
                somaSaldos += aAlunos[i].salAlu;
            }
            Console.WriteLine($"Média dos saldos: {somaSaldos / aAlunos.Length:N2}\n");

        }
        static void PercentagemDividas(sAluno[] aAlunos)//Função para calcular a percentagem de alunos com dívidas.
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-----Percentagem de Dividas-----");
            Console.WriteLine("--------------------------------\n");
            int counterDividas = 0;

            for (int i = 0; i < aAlunos.Length; i++)
            {
                if (aAlunos[i].salAlu < 0)
                {
                    counterDividas++;
                }
            }
            Console.WriteLine($"Percentagem de alunos com dívidas: {((float)counterDividas / aAlunos.Length) * 100:N2}%\n");

        }
        //----------------------------------------------------------------------------
        //---------------------------------VALIDAÇÕES---------------------------------
        //----------------------------------------------------------------------------
        static bool CodigoExiste(sAluno[] aAlunos, string codAlu)//Função para verificar se um código já existe.
        {
            for (int i = 0; i < aAlunos.Length; i++)
            {
                if (codAlu == aAlunos[i].codAlu)
                {
                    return true;
                }
            }
            return false;
        }
        static bool ValidarCodigo(string codigo)
        {
            if (String.IsNullOrEmpty(codigo))
            {
                Console.WriteLine("ERRO - Código não pode ser vazio!");
                return false;
            }
            else if (codigo.Length != 7)
            {
                Console.WriteLine("ERRO - Código tem de ter 7 caracteres!");
                return false;
            }
            else if (codigo[0] != 'a' || codigo[1] != '2' || codigo[2] != '4')
            {
                Console.WriteLine("ERRO - Código tem de começar por 'a24'!");
                return false;
            }
            return true;
        }
        static bool ValidarNome(string nome)//Função para validar o nome.
        {
            if (String.IsNullOrEmpty(nome))
            {
                Console.WriteLine("ERRO - Nome não pode ser vazio!");
                return false;
            }
            return true;
        }
        static bool ValidarIdade(int idade)//Função para validar a idade.
        {
            if (idade < 1 || idade > 25)
            {
                Console.WriteLine("ERRO - Idade tem de ser entre 1 e 25.");
                return false;
            }
            return true;
        }
        static bool ValidarMedia(float media)//Função para validar a média.
        {
            if (media < 0 || media > 20)
            {
                Console.WriteLine("ERRO - Média tem de ser entre 0 e 20.");
                return false;
            }
            return true;
        }
        static bool ValidarPropina(float propina)//Função para validar a propina.
        {
            if (propina < 0)
            {
                Console.WriteLine("ERRO - Propina tem de ser positiva.");
                return false;
            }
            else if (propina > 500)
            {
                Console.WriteLine("ERRO - Propina tem de ser menos de 500.");
                return false;
            }
            return true;
        }
        static bool ValidarSaldo(float saldo)//Função para validar o saldo.
        {
            if (saldo < 0)
            {
                Console.WriteLine("ERRO - Saldo tem de ser positivo.");
                return false;
            }
            return true;
        }
    }
}
