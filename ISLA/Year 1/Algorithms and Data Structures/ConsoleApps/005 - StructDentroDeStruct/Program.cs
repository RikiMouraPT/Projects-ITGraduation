namespace _005___StructDentroDeStruct
{
    internal class Program
    {
        struct Aluno
        {
            public string nome;
            public Disciplina[] aDisciplinasAluno;
        }
        struct Disciplina
        {
            public int codigo;
            public string designacao;
            public double nota;
        }
        static void Main(string[] args)
        {
            int numAluno = 3;
            int numDiscplinas = 4;

            Aluno[] aAlunos = new Aluno[numAluno];
            Disciplina[] aDisciplinasExistentes = new Disciplina[numDiscplinas];

            //Preencer as disciplinas existenes, a nota apenas é preenchido com o Aluno
            for (int i = 0; i < aDisciplinasExistentes.Length; i++)
            {
                Console.WriteLine($"Escreve o código da disciplina {i + 1}: ");
                aDisciplinasExistentes[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Designação: ");
                aDisciplinasExistentes[i].designacao = Console.ReadLine();
            }

            for (int i = 0; i < aAlunos.Length; i++)
            {
                Console.WriteLine($"Nome do aluno {i + 1}");
                aAlunos[i].nome = Console.ReadLine();
                aAlunos[i].aDisciplinasAluno = aDisciplinasExistentes;

                for (int k = 0; k < aAlunos[i].aDisciplinasAluno.Length; k++)
                {
                    Console.WriteLine($"Disciplina: {aAlunos[i].aDisciplinasAluno[k].codigo} - {aAlunos[i].aDisciplinasAluno[k].designacao}");
                    Console.WriteLine($"Nota: ");
                    aAlunos[i].aDisciplinasAluno[k].nota = Convert.ToDouble(Console.ReadLine());
                }
            }

            //LISTAR ALUNOS

            for (int i = 0; i < aAlunos.Length; i++)
            {
                Console.WriteLine($"Nome do aluno {i + 1}: {aAlunos[i].nome}");
                for (int j = 0; j < aAlunos[i].aDisciplinasAluno.Length; j++)
                {
                    Console.WriteLine($"Disciplina: {aAlunos[i].aDisciplinasAluno[j].codigo} - {aAlunos[i].aDisciplinasAluno[j].designacao}");
                    Console.WriteLine($"Nota: {aAlunos[i].aDisciplinasAluno[j].nota}");
                }

            }
            Console.ReadLine();
        }
    }
}