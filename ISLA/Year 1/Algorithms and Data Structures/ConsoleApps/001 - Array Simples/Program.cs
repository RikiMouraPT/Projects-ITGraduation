using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace _001___ArraySimples
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
                        break;

                    case 2://Remover um elemento
                        Console.WriteLine("Qual é o nº da nota que quer remover?");
                        int index = Convert.ToInt32(Console.ReadLine());

                        List<int> lista = notas.ToList();                       //Convert as notas para uma lista para poder usar o .RemoveAt()
                        lista.RemoveAt(index - 1);                              //Remove o index desejado
                        notas = lista.ToArray();                                //Converte a lista para um array novamente

                        Console.WriteLine("\nPressione ENTER p/ Continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3://Dar print às notas
                        for (int j = 0; j < notas.Length; j++)
                        {
                            Console.WriteLine($"Nota {j + 1}: {notas[j]}");
                        }

                        Console.WriteLine("\nPressione ENTER p/ Continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4://Melhor nota
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
                        break;

                    case 5://Pior Nota
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
                        break;

                    case 6://Numero de positivas
                        int numPos = 0;

                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (notas[i] >= 10)
                            {
                                numPos++;
                            }
                        }
                        Console.WriteLine($"Existe {numPos} positivas.");
                        break;

                    case 7://Numero de negativas
                        int numNeg = 0;

                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (notas[i] < 10)
                            {
                                numNeg++;
                            }
                        }
                        Console.WriteLine($"Existe {numNeg} negativas.");
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
    }
}