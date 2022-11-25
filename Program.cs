// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число  в натуральную степень B.
// 3, 5 -> 243 (3?)
// 2, 4 -> 16


// Console.WriteLine("Введите число А ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В ");
// int b = Convert.ToInt32(Console.ReadLine());
// Numbers (b);
// int d = 0;
// int Numbers(int b)
// {
//     int c = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         c = c * a;
//     }
//     return c;
// }
// d = Numbers(b);
// Console.WriteLine($"Число {a} в степени {b} = {d}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());

// void SumNumbers (int n)
// {
//     int a=0;   
//     while (n%10>0 || n>0)
//     {
//         a=a+n%10;
//         n/=10;
//     }

//     Console.WriteLine($"Сумма цифр в числе {a}");    
// }

// SumNumbers (n);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.


// int[]array=new int[8];
// void FillArray(int[]collection)
// {
//     int length = 8;
//     int index = 0;
//     while (index < length)
//     {
//         Console.WriteLine("Введите элемент массива");
//         int n=Convert.ToInt32(Console.ReadLine());
//         collection[index]=n;
//         index++;
//     }
// }
// void PrintArray(int[]array)
// {
//     int count = 8;
//     for (int i=0; i<count; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
//     Console.WriteLine();
// }

// FillArray(array);
// PrintArray(array);

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateFillArray()
// {
//     int[] arr=new int [4];
//     for (int i=0; i<4; i++)
//     {
//         arr[i]=new Random().Next(100,1000);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     return arr;
// }

// void AmNumb(int[] arr)
// {
//     int count=0;
//     foreach (int el in arr)
//     {
//         if (el%2==0) count++;
//     }
//     Console.WriteLine(count);    
// }

// int[]mas=CreateFillArray();
// AmNumb(mas);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateFillArray()
// {
//     int[] arr=new int [4];
//     for (int i=0; i<4; i++)
//     {
//         arr[i]=new Random().Next(-99,100);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     return arr;
// }

// void Summ(int[] arr)
// {
//     int sum=0;
//     for (int j=1; j<4; j=j+2)
//     {
//         sum=sum+arr[j];
//     }
//     Console.WriteLine(sum);    
// }

// int[]mas=CreateFillArray();
// Summ(mas);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



// double[] mas = {1.23, 0, -50.0001, 300.0}; //задаём массив вещественных чисел
// Console.WriteLine($"mas: {mas[0]}, {mas[1]}, {mas[2]}, {mas[3]}");  //вывод на печать заданного массива
// int n = mas.Length; // определяем кол-во элементов массива
// //Console.WriteLine(n);   //вывод на печать кол-во элементов массива

// double max = mas[0];
// for (int i=0; i<n; i++)
//     {
//         if (mas[i] > max) 
//         {
//         max=mas[i];
//         }
//     }
// //Console.WriteLine(max); //вывод на печать max

// double min = mas[0];
// for (int j=0; j<n; j++)
//     {
//         if (mas[j] < min) 
//         {
//         min=mas[j];
//         }
//     }
// //Console.WriteLine(min); //вывод на печать min

// Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max-min}"); 


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// double[] mas = {1.23, 0, -50.0001, 300.0}; //задаём массив вещественных чисел
// Console.WriteLine($"mas: {mas[0]}, {mas[1]}, {mas[2]}, {mas[3]}");  //вывод на печать заданного массива
// int n = mas.Length; // определяем кол-во элементов массива
// //Console.WriteLine(n);   //вывод на печать кол-во элементов массива
// double[] Max (double[] mas)
// {
//     double max = mas[0];
//     double min = mas[0];
//     for (int i=0; i<n; i++)
//         {
//             if (mas[i] > max) max=mas[i];
//             if (mas[i] < min) min=mas[i];
//         }
//         Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max-min}");
//         return mas; 
// }    
// Max (mas);

// ДЗ 6
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел, которые хотите ввести");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
void FillArray(int[] collection)
{
    int length = N;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine($"Введите {index + 1} число");
        int n = Convert.ToInt32(Console.ReadLine());
        collection[index] = n;
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = N;
    int s = 0;
    Console.Write("Вы ввели числа: ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
        if (array[i] > 0) s++;
    }
    Console.WriteLine();
    Console.Write($"Количество чисел больше 0 равно: {s}");
}
FillArray(array);
PrintArray(array);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.WriteLine("Две прятые заданны уравнениями: y = k1 * x + b1 и y = k2 * x + b2");
// Console.WriteLine("Задайте значения: b1, k1, b2, k2 последовательно, по одному: ");
// double[]array=new double[4];
// void FillArray(double[]collection)
// {
//     string [] arr = new string [] {"b1", "k1", "b2", "k2"};
//     int length = 4;
//     int index = 0;
//     while (index < length)
//     {
//         Console.WriteLine($"Введите значение  {arr[index]}");
//         double n=Convert.ToInt32(Console.ReadLine());
//         collection[index]=n;
//         index++;
//     }
// }
// //  // b1, k1, b2, k2    <= значения
// //  //  0,  1,  2,  3    <= индексы
// FillArray(array);

// double x = (array[2]-array[0])/(array[1]-array[3]);
// double y = (array[1]*x + array[0]);
// if(array[1] == array[3] ) Console.Write("Заданные прямые не пересекаются!");
// else Console.WriteLine($"Точка пересечения двух прямых ({x}, {y})");