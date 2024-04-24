namespace _008___JaggedArray_Exercicio
{
    internal class Program
    {//Ricardo Moura 17/04/2024
        struct Student
        {
            public string nome;
            public int[][] uc; //Unidade Curricular
        }
        static void Main(string[] args)
        {
            //Variaveis
            Student[] aStudents = new Student[2];

            InserirAlunos(ref aStudents);
            ListarAlunos(aStudents);

        }
        static void ListarAlunos(Student[] aStudents)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("------- LISTAGEM -------");
            Console.WriteLine("------------------------\n");

            for (int i = 0; i < aStudents.Length ; i++)
            { 
                Console.WriteLine($"--- {i + 1}º Aluno ---");
                Console.WriteLine($"Nome: {aStudents[i].nome}");

                for (int j = 0; j < aStudents[i].uc.Length; j++) 
                {
                    Console.WriteLine($"Disciplina {j + 1}");

                    for (int k = 0; k < aStudents[i].uc[j].Length; k++)
                    {
                        Console.WriteLine($"Nota {k + 1}: {aStudents[i].uc[j][k]}");
                    }
                    Console.WriteLine("");
                }               
            }

            Console.WriteLine("Pressione ENTER p/ continuar.");
            Console.ReadKey();
        }
        static void InserirAlunos(ref Student[] aStudents)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("------- INSERIR --------");
            Console.WriteLine("------------------------\n");

            for (int l = 0; l < aStudents.Length; l++)  
            {
                aStudents[l] = new Student();
                Console.Write("Nome: ");
                aStudents[l].nome = Console.ReadLine();

                Console.Write("Numero de Disciplinas: ");
                int nDisciplinas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                aStudents[l].uc = new int[nDisciplinas][];// Atribui o tamanho das UCs consoante o valor inserido

                for (int i = 0; i < nDisciplinas; i++)
                {
                    Console.WriteLine($"Disciplina {i + 1}");
                    Console.Write("Quantidade de Notas: ");
                    int nNotas = Convert.ToInt32(Console.ReadLine());
                    aStudents[l].uc[i] = new int[nNotas];// Atribui o tamanho das notas consoante o valor inserido

                    for (int j = 0; j < nNotas; j++)
                    {
                        Console.Write($"{j + 1}ª Nota: ");
                        aStudents[l].uc[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Pressione ENTER p/ continuar.");
            Console.ReadKey();
        }
    }
}