using System.Text.RegularExpressions;

namespace _004___StructComArray
{
    internal class Program
    {//Feito por: Ricardo Moura a22309442
        struct Aluno
        {
            public string nome;
            public double[] notas;
        }
        static void Main(string[] args)
        {
            //Definir Variaveis
            int numAlunos = 3;
            int numDisciplinas = 5;
            Aluno[] aAlunos = new Aluno[numAlunos];

            int opcao = 0;
            do
            {
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("1 - Inserir Dados.");
                Console.WriteLine("2 - Listar Alunos.");
                Console.WriteLine("3 - ");
                Console.WriteLine("4 - ");
                Console.WriteLine("5 - ");
                Console.WriteLine("6 - ");
                Console.WriteLine("7 - ");
                Console.WriteLine("8 - ");
                Console.WriteLine("0 - Sair do programa");
                Console.WriteLine("----------------------------");

                Console.Write("Digite uma opção.");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (opcao)
                {
                    case 1://Preencher struct
                        for (int i = 0; i < numAlunos; i++)
                        {
                            Console.WriteLine($"Escreve o nome do {i + 1} aluno: ");
                            aAlunos[i].nome = Console.ReadLine();

                            aAlunos[i].notas = new double[numDisciplinas];
                            for (int j = 0; j < aAlunos[i].notas.Length; j++)
                            {
                                Console.WriteLine($"Disciplina: {j + 1} - Nota: ");
                                aAlunos[i].notas[j] = Convert.ToDouble(Console.ReadLine());
                            }
                        }
                        Console.Clear();
                        break;
                    case 2://Listar Alunos
                        for (int i = 0; i < aAlunos.Length; i++)
                        {
                            Console.WriteLine($"Aluno{i + 1}: {aAlunos[i].nome}");

                            for (int j = 0; j < aAlunos[i].notas.Length; j++)
                            {
                                Console.WriteLine($"Disciplina {i + 1}: {aAlunos[i].notas[j]}");
                            }
                        }
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção não existe.");
                        break;
                }
            } while (opcao != 0);
            Console.ReadLine();
        }
    }
}