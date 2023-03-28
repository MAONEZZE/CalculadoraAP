namespace CalculadoraAtualizada
{
    internal class Program
    {
        static string menuDeOpcoes()
        {
            string opcao;

            Console.WriteLine("----Menu de opções----");
            Console.WriteLine("-------1 - Somar------");
            Console.WriteLine("-----2 - Subtrair-----");
            Console.WriteLine("----3 - Multiplicar---");
            Console.WriteLine("------4 - Dividir-----");
            Console.WriteLine("------5 - Tabuada-----");
            Console.WriteLine("-----6 - Histórico----");
            Console.WriteLine("-------S - Sair-------");
            Console.WriteLine();
            Console.Write("Opção: ");
            opcao = Console.ReadLine();

            return opcao;
        }

        static void leituraDosNumeros(string opcao)
        {
            Console.WriteLine();
            int num1, num2 = 0;

            Console.Write("Digite um Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (opcao != "5")
            {
                Console.Write("Digite outro Número: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }

            controleDeOperacoes(opcao, num1, num2);
        }

        static void controleDeOperacoes(string opcao, int num1, int num2)
        {
            Console.WriteLine();
            switch (opcao)
            {
                case "1":
                    somarNumeros(num1, num2);
                    break;

                case "2":
                    subtrairNumeros(num1, num2);
                    break;

                case "3":
                    multiplicarNumeros(num1, num2);
                    break;

                case "4":
                    while (num2 == 0)
                    {
                        Console.WriteLine("O divisor digitado (o Segundo número) não pode ser zero, digite outro número");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    dividirNumeros(num1, num2);
                    break;

                case "5":
                    tabuada(num1);
                    break;

                case "6":
                    historicoContas();
                    break;
            }
        }

        static void somarNumeros(int num1, int num2)
        {
            int soma;
            soma = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {soma}");
        }

        static void subtrairNumeros (int num1, int num2)
        {
            int sub;
            sub = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {sub}");
        }

        static void multiplicarNumeros(int num1, int num2)
        {
            int mult;
            mult = num1 * num2;
            Console.WriteLine($"{num1} X {num2} = {mult}");
        }

        static void dividirNumeros(int num1, int num2)
        {
            decimal div;

            div = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {div}");
        }

        static void tabuada(int num1)
        {
            int mult;
            Console.WriteLine("===========================");
            for (int i = 0; i <= 10; i++){
                mult = num1 * i;
                Console.WriteLine($"{num1} X {i} = {mult}");
            }
            Console.WriteLine("===========================");
        }

        static void historicoContas()
        {

        }

        static void Main(string[] args)
        {
            string opcao = null;

            do
            {
                opcao = menuDeOpcoes();

                while(opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s")
                {
                    Console.WriteLine();
                    Console.WriteLine("Operacao inválida, tente novamente...");
                    Console.Write("Opção: ");
                    opcao = Console.ReadLine();
                }

                if (opcao != "s" && opcao != "S")
                {
                    leituraDosNumeros(opcao);
                }

                Console.WriteLine();
            } while (opcao != "s" && opcao != "S");

            Console.WriteLine("Operações encerradas!");
        }
    }
}