using System;


Console.WriteLine("Выберите действие :");
Console.WriteLine("1. Сложить 2 числа ");
Console.WriteLine("2. Вычесть первое из второго "); 
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе ");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный  корень из числа");
Console.WriteLine("7. Найти 1 % от числа");
Console.WriteLine("8. Найти факториал из числа ");
Console.WriteLine("9. Выйти из программы");
for (int a = 0; a<9; a++)
{
    Console.WriteLine();
    Console.WriteLine("Напишите номер действия: ");
    
    string input = Console.ReadLine();
    int x = Convert.ToInt32(input);

    do
    {


        if (x == 1)
        {
            Console.WriteLine("Введите первое число: ");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            Console.WriteLine("Введите второе число: ");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            Console.WriteLine("Результат: ");
            Console.WriteLine(num1 + num2);
            break;
        }

        else if (x == 2)
        {
            Console.WriteLine("Введите второе число:");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            Console.WriteLine("Введите первое число: ");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            Console.WriteLine("Результат: ");
            Console.WriteLine(num2 - num1);
            break;
        }
        else if (x == 3)
        {
            Console.WriteLine("Введите первое число: ");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            Console.WriteLine("Введите второе число: ");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            Console.WriteLine("Результат: ");
            Console.WriteLine(num1 * num2);
            break;
        }
        else if (x == 4)
        {
            Console.WriteLine("Введите первое число: ");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            Console.WriteLine("Введите второе число: ");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            Console.WriteLine("Результат: ");
            Console.WriteLine(num1 / num2);
            break;
        }
        else if (x == 5)
        {
            Console.WriteLine("Введите первое число: ");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            Console.WriteLine("Введите число N: ");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            Console.WriteLine("Результат: ");
            double res1 = Math.Pow(num1, num2);
            Console.WriteLine(res1);
            break;
        }
        else if (x == 6)
        {
            Console.WriteLine("Введите число: ");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            Console.WriteLine("Результат: ");
            double res1 = Math.Sqrt(num1);
            Console.WriteLine(res1);
            break;
        }
        else if (x == 7)
        {
            Console.WriteLine("Введите число: ");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            Console.WriteLine("Результат: ");
            double res1 = num1 * 0.01;
            Console.WriteLine(res1);
            break;
        }
        else if (x == 8)
        {
            Console.WriteLine("Введите число: ");
            string number1 = Console.ReadLine();
            int n = Convert.ToInt32(number1);
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Результат: ");
            Console.WriteLine(factorial);
            break;
        }


    } while (x != 9);
if (x==9)
    {
    Console.WriteLine("Вы успешно покинули программу. Пора идти домой!!!");
    break;
    }
}