//Задания 2,4,6,8
//Нужно выбрать задание из списка

using System.ComponentModel.Design;

Console.WriteLine("Выберите задание, доступные 2,4,6 и 8");
int num = int.Parse(Console.ReadLine());
 
switch (num)
{
    case 2:
        Console.WriteLine("Вы выбрали задание 2");
        // Домашка 1
        Console.WriteLine("Задание: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
        Console.WriteLine("Введите число A");
         int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число B"); 
         int B = int.Parse(Console.ReadLine());

        Console.WriteLine("Отлично, делаем проверку.");
        Console.WriteLine(" ");
        
         if (A > B)
    {
        Console.WriteLine("Число " + A + " больше");
        Console.WriteLine("Число " + B + " меньше");
    }
        else
    {
        Console.WriteLine("Число " + B + " больше");   
        Console.WriteLine("Число " + A + " меньше");  
    }
        Console.WriteLine(" ");
        break;

    case 4:
        Console.WriteLine("Вы выбрали задание 4");
        // Домашка 4
        Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
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

    case 6:
        Console.WriteLine("Вы выбрали задание 6");
        // Домашка 6
        Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
        Console.WriteLine("Введите число");

        int X = int.Parse(Console.ReadLine());

        if (X%2 == 0)
            Console.WriteLine("Число четное");
        else
            Console.WriteLine("Число не четное");
            Console.WriteLine(" ");
        break;

    case 8:
        Console.WriteLine("Вы выбрали задание 8");
        // Домашка 8
        Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
        Console.WriteLine("Введите число N");

        int N = int.Parse(Console.ReadLine());
        int chet = 0;
        
        if (N > 1) //Остановка скрипта, раз не будет четных и положительных

         for (int i = 1; i <= N; i++)
             {   
               if (i%2 == 0)
                { 
                Console.WriteLine("Четное число " + i);    
                }   
             }
        else Console.WriteLine("Четных положительных чисел нет"); 
        Console.WriteLine(" ");   

        break;
}




