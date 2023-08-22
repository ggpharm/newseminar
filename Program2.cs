
//Нужно выбрать задание из списка
using System.ComponentModel.Design;
using System.Xml.XPath;

int SecondNum(int N) //Функция для задания 10 и 13
{
    N = N%100;
    N = N / 10;
    int result = N;
    return result;  
}

int Find3(int X) //Функция для задания 13
{
    while (X > 999)
    {
        X /= 10;
    }

    return X %10;  
}

bool ValidX (int X)
{
    if  (X < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }

return true;
}

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int WeekDay)
{
    if (WeekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekDay(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели.");
    return false;
}

//Запрашиваем выбор задания
Console.WriteLine("Выберите задание, доступные 10,13,15");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 10:
        Console.WriteLine("Вы выбрали задание 10");
        // Домашка 10
        Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
        Console.Write("Введите трехзначное число ");
        
        int C = int.Parse(Console.ReadLine());
        int res2 = SecondNum(C);

        Console.WriteLine(" ");

        break;

    case 13:
        Console.WriteLine("Вы выбрали задание 13");
        // Домашка 13
        Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        Console.WriteLine("Введите число");

        int P = int.Parse(Console.ReadLine());
        if (ValidX(P))
        {
        int res1 = Find3(P);
        Console.WriteLine("Число " + res1);
        }
        Console.WriteLine(" ");
        break; 

    case 15:
        Console.WriteLine("Вы выбрали задание 15");
        // Домашка 15
        Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        
        int WeekDay = Prompt("Введите день недели ");
        if (ValidateWeekDay(WeekDay))
        {
            if (IsWeekend(WeekDay))
            {
                Console.WriteLine("Выходной!");
            }
            else
            {
                Console.WriteLine("Работаем!");
            }
        }

            Console.WriteLine(" ");
        break;

   
}




