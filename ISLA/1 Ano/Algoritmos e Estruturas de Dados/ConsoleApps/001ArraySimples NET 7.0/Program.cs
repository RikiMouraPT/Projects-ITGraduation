using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace _001ArraySimples_NET_7
{
    internal class Program
    {   // Autor: Ricardo Moura 14/02/2024
        // Programa para gestão de notas
        static void Main(string[] args)
        {
            //Declaração de variaveis
            Console.WriteLine("Gestão de Notas de um Array!");
            int[] notas = new int[5];

            while (true)
            {
                int opcao = Menu();

                switch (opcao)
                {
                    case 1://Preencher notas
                        InserirDados(ref notas);
                        break;

                    case 2://Remover um elemento
                        RemoverNota(ref notas);
                        break;

                    case 3://Dar print às notas
                        PrintNotas(notas);
                        break;

                    case 4://Melhor nota
                        MelhorNota(notas);
                        break;

                    case 5://Pior Nota
                        PiorNota(notas);
                        break;

                    case 6://Numero de positivas
                        QntPositivas(notas);
                        break;

                    case 7://Numero de negativas
                        QntNegativas(notas);
                        break;
                    case 8://Calcular media
                        Media(notas);
                        break;
                }
            }

        }

        static int Menu()
        {

            Console.WriteLine("--------MENU--------");
            Console.WriteLine("1 - Preencher Notas.");
            Console.WriteLine("2 - Remover uma nota.");
            Console.WriteLine("3 - Ver as notas.");
            Console.WriteLine("4 - Melhor nota.");
            Console.WriteLine("5 - Pior Nota.");
            Console.WriteLine("6 - Numero de positivas.");
            Console.WriteLine("7 - Numero de negativas.");
            Console.WriteLine("8 - Calcular a média.");
            Console.WriteLine("--------------------");


            Console.Write("Digite uma opção.");
            return Convert.ToInt32(Console.ReadLine());
        }

        static bool IsValid(int input)
        {
            if (input < 0 || input > 20)
            {
                return false;
            }
            return true;
        }

        static void InserirDados(ref int[] notas)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite a {i + 1}º nota: ");
                notas[i] = Convert.ToInt32(Console.ReadLine());

                if (!IsValid(notas[i])) //Verifica se a nota não é válida
                {
                    Console.WriteLine("Nota inválida, por favor insira uma nota entre 0 e 20.");
                    i--;
                }
            }

            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }

        static void RemoverNota(ref int[] notas)
        {
            Console.WriteLine("Qual é o nº da nota que quer remover?");
            int index = Convert.ToInt32(Console.ReadLine());

            List<int> lista = notas.ToList();                       //Convert as notas para uma lista para poder usar o .RemoveAt()
            lista.RemoveAt(index - 1);                              //Remove o index desejado
            notas = lista.ToArray();                                //Converte a lista para um array novamente

            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }
        
        static void PrintNotas(int[] notas)
        {
            for (int j = 0; j < notas.Length; j++)
            {
                Console.WriteLine($"Nota {j + 1}: {notas[j]}");
            }

            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }
        
        static void MelhorNota(int[] notas)
        {
            int maiorNota = notas[0]; //Inicializa a nota com a primeira nota do array

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > maiorNota) //Se a nota do array for maior que a maiorNota atual, maiorNota toma o valor atual do array
                {
                    maiorNota = notas[i];
                }
            }

            Console.WriteLine($"A maior nota é {maiorNota}");
            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }

        static void PiorNota(int[] notas)
        {
            int menorNota = notas[0];

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < menorNota)
                {
                    menorNota = notas[i];
                }
            }

            Console.WriteLine($"A pior nota é {menorNota}");
            Console.WriteLine("\nPressione ENTER p/ Continuar");
            Console.ReadLine();
            Console.Clear();
        }

        static void QntPositivas(int[] notas)
        {
            int numPos = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 10)
                {
                    numPos++;
                }
            }
            Console.WriteLine($"Existe {numPos} positivas.");
        }

        static void QntNegativas(int[] notas)
        {
            int numNeg = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < 10)
                {
                    numNeg++;
                }
            }
            Console.WriteLine($"Existe {numNeg} negativas.");
        }
        static void Media(int[] notas)
        {
            double media;
            double soma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            media = Math.Round(soma / notas.Length, 2);
            Console.WriteLine($"A média é de: {media:N2}");
        }
    }
}