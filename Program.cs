//Задания 2,4,6,8
//Нужно выбрать задание из списка

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
        Console.WriteLine("");
        // Домашка 6
        break;

    case 8:
        Console.WriteLine("Вы выбрали задание 8");
        Console.WriteLine("8");
        // Домашка 4
        break;
}




