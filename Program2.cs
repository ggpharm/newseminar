//Задания 2,4,6,8
//Нужно выбрать задание из списка

using System.ComponentModel.Design;

Console.WriteLine("Выберите задание, доступные 10,13,15");
int num = int.Parse(Console.ReadLine());
 
switch (num)
{
    case 10:
        Console.WriteLine("Вы выбрали задание 10");
        // Домашка 10
        Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

        Console.WriteLine(" ");
        break;

    case 13:
        Console.WriteLine("Вы выбрали задание 13");
        // Домашка 13
        Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        Console.WriteLine("Введите число A");
         int A2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число B"); 
         int B2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число C"); 
         int C2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Отлично, делаем проверку.");
        Console.WriteLine(" ");

        int maxx = A2;

        if (B2 > maxx)
            maxx = B2;
            if (C2 > maxx)
            {
                maxx = C2;
                Console.WriteLine("Максимальное число " + maxx);
            }
        else if (B2 > maxx)
        {
            maxx = B2;
            Console.WriteLine("Максимальное число " + maxx);
        } 
        else
            Console.WriteLine("Максимальное число " + maxx);
            Console.WriteLine(" ");
        break; 

    case 15:
        Console.WriteLine("Вы выбрали задание 15");
        // Домашка 15
        Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        Console.WriteLine("Введите число");

        int X = int.Parse(Console.ReadLine());

        if (X%2 == 0)
            Console.WriteLine("Число четное");
        else
            Console.WriteLine("Число не четное");
            Console.WriteLine(" ");
        break;

   
}




