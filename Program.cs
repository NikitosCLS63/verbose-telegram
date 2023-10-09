
class Program
{
    static double plus(double a, double b)
    {
        return a + b;
    }

    static double vyichest(double a, double b)
    {
        return a - b;
    }

    static double opopumnojit(double a, double b)
    {
        return a * b;
    }

    static double deleteeee(double a, double b)
    {
        return a / b;
    }

    static double Power(double a, int n)
    {
        return Math.Pow(a, n);
    }

    static double SquareRoot(double c)
    {
        return Math.Sqrt(c);
    }

    static double Percent(double c)
    {
        return c / 100;
    }

    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("  ");
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("  ");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выйти из программы");

            string choice = Console.ReadLine();

            if (choice == "9")
                break;

            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            if (choice == "6" || choice == "7" || choice == "8")
            {
                if (choice == "6")
                {
                    double result = SquareRoot(num1);
                    Console.WriteLine($"Квадратный корень из {num1} равен {result}");
                }
                else if (choice == "7")
                {
                    double result = Percent(num1);
                    Console.WriteLine($"1 процент от {num1} равен {result}");
                }
                else if (choice == "8")
                {
                    int result = Factorial((int)num1);
                    Console.WriteLine($"Факториал числа {num1} равен {result}");
                }
            }
            else
            {
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                if (choice == "1")
                {
                    double result =    plus(num1, num2);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Сумма чисел {num1} и {num2} равна {result}");
                }
                else if (choice == "2")
                {
                    double result = vyichest(num1, num2);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Разность чисел {num1} и {num2} равна {result}");
                }
                else if (choice == "3")
                {
                    double result = opopumnojit(num1, num2);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Произведение чисел {num1} и {num2} равно {result}");
                }
                else if (choice == "4")
                {
                    if (num2 != 0)
                    {
                        double result = deleteeee(num1, num2);
                            Console.WriteLine(" ");
                        Console.WriteLine($"Частное чисел {num1} и {num2} равно {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль");
                    }
                }
                else if (choice == "5")
                {
                    double result = Power(num1, (int)num2);
                    Console.WriteLine(" ");
                    Console.WriteLine($"{num1} в степени {num2} равно {result}");
                }
            }
        }
    }
}




