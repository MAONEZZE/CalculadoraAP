namespace Calculadora.AP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("O que deseja fazer?: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Tabuada de um número");
            Console.WriteLine("6 - Sair");
            Console.Write("Opção: ");
            op = Convert.ToInt32(Console.ReadLine());

            while(op != 6)
            {
                double n1, n2, calc;
                while (op != 1 && op != 2 && op != 3 && op != 4 && op != 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção Invalida!");
                    Console.WriteLine("O que deseja fazer?: ");
                    Console.WriteLine("1 - Somar");
                    Console.WriteLine("2 - Subtrair");
                    Console.WriteLine("3 - Multiplicar");
                    Console.WriteLine("4 - Dividir");
                    Console.WriteLine("5 - Tabuada de um número");
                    Console.Write("Opção: ");
                    op = Convert.ToInt32(Console.ReadLine());
                }
                if (op == 5)
                {
                    Console.WriteLine();
                    int num;
                    Console.Write("Digite o número que você quer a tabuada: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    for (int i = 0; i <= 10; i++)
                    {
                        if(i%2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        int tabuada;
                        tabuada = num * i;
                        Console.WriteLine(num + " x " + i + " = " + tabuada);
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Digite o primeiro numero: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo numero: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            calc = n1 + n2;
                            Console.WriteLine("A soma entre os dois valores: " + calc);
                            break;

                        case 2:
                            calc = n1 - n2;
                            Console.WriteLine("A subtração entre os dois valores: " + calc);
                            break;

                        case 3:
                            calc = n1 * n2;
                            Console.WriteLine("A multiplicação entre os dois valores: " + calc);
                            break;

                        case 4:
                            if (n2 == 0)
                            {
                                Console.WriteLine("ERRO, nao dá para dividir por 0");
                            }
                            else
                            {
                                calc = n1 / n2;
                                Console.WriteLine("A divisão entre os dois valores: " + Math.Round(calc, 2));
                            }
                            break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("O que deseja fazer?: ");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Tabuada de um número");
                Console.WriteLine("6 - Sair");
                Console.Write("Opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                
            }
            Console.WriteLine("Tchau!");
        }
    }
}