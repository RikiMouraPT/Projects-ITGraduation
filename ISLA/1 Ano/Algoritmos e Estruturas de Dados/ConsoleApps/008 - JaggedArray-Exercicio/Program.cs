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
            InserirAluno();

            aStudents[0] = new Student();
            aStudents[0].uc = new int[3][]; // 3 Disciplinas
            aStudents[0].nome = "Maria";
            aStudents[0].uc[0] = new int[] { 12, 15, 7, 9 };
            aStudents[0].uc[1] = new int[] { 12, 15 };
            aStudents[0].uc[2] = new int[] { 12, 18, 20, 14, 17 };

            aStudents[1] = new Student();
            aStudents[1].uc = new int[2][]; // 3 Disciplinas

            aStudents[1].nome = "Ricardo";
            aStudents[1].uc[0] = new int[] { 12 };
            aStudents[1].uc[1] = new int[] { 12, 15, 17 };

            //listagem
            Console.WriteLine("Listagem de Alunos");
            //inserção dos valores com FORs
        }
        static void ListarDados(Student aStudents)
        {

        }
        static void InserirAluno(Student aStudent)
        {
            aStudents = new Student();
            //Pedir ao utilizador o nome do aluno
            Console.Write("Nome do Aluno: ");
            aStudents.nome = Console.ReadLine();
            Console.

            aStudents.uc = new int[3][]; // 3 Disciplinas
        }
    }
}