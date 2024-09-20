namespace Template_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = Menu();

            do
            {
                SwitchCase(/*Variavel Principal*/);
            } while (opcao != 0);
        }
        static int Menu()
        {
            Console.WriteLine("------------MENU------------");
            Console.WriteLine("1 - ");
            Console.WriteLine("2 - ");
            Console.WriteLine("3 - ");
            Console.WriteLine("4 - ");
            Console.WriteLine("5 - ");
            Console.WriteLine("6 - ");
            Console.WriteLine("7 - ");
            Console.WriteLine("8 - ");
            Console.WriteLine("9 - ");
            Console.WriteLine("0 - Sair do programa");
            Console.WriteLine("----------------------------");

            Console.Write("Digite uma opção.");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void SwitchCase(/*Variavel Principal*/)
        {
            switch (Menu())
            {
                case 1:
                    Console.WriteLine("Funcionei!!");
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();
                    break;
                case 9:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção não existe.");
                    break;
            }
        }
    }
}