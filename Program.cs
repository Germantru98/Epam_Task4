using System;

namespace Epam_Task4
{
    internal class Program
    {
        private static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else return n * Factorial(n - 1);
        }

        private static void Main(string[] args)
        {
            int number = 1;
            Console.Write("Введите число для нахождения факториала: ");
            try
            {
                if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
                {
                    throw new Exception("Введено некорректное значение для поиска факториала");
                }
            }
            catch (Exception e)
            {
                int attempt = 3;
                Console.WriteLine($"{e.Message}\nВведите корректное значение для нахождения факториала");
                while (attempt > 0)
                {
                    if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
                    {
                        attempt--;
                        Console.WriteLine($"Значение введено неверно\nПопыток осталось:{attempt}");
                    }
                    else
                    {
                        break;
                    }

                    if (attempt == 0)
                    {
                        Console.WriteLine("Завершение работы с приложением...");
                        break;
                    }
                }
            }
            finally
            {
                int result = Factorial(number);
                Console.WriteLine($"{number}!= {result}");
            }
        }
    }
}