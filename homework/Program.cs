// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// void NewArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100,1000);
// }

// int f(int[] array)
// {
//     int count = 0;
//     foreach(int element in array)
//     {
//         if(element % 2 == 0)
//             count++;
//     }
//     return count;
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов массива: ");
// int x = int.Parse(Console.ReadLine()!);
// int[] array = new int[x];
// NewArray(array);
// Console.WriteLine($"Массив: {string.Join(", ", array)}");
// Console.WriteLine(f(array));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// void NewArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// int SumEL(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(i%2!=0)
//         sum += array[i];
//     }
//     return sum;
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов массива: ");
// int x = int.Parse(Console.ReadLine()!);
// int[] array = new int[x];
// NewArray(array);
// Console.WriteLine($"Массив: {string.Join(", ", array)}");
// Console.WriteLine(SumEL(array));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// void NewArray(double[] array, ref int x, ref int y)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = Math.Round((new Random().NextDouble() * (y-x) + x),2);
// }

// double diff(double[] array)
// {
//     double max = array[0]; 
//     double min = array[0];
//     for(int i = 1; i < array.Length; i++)
//     {
//         if(array[i] > max)
//             max = array[i];
//         if(array[i] < min)
//             min = array[i];
//     }
//     return max-min;
// }
// Console.Clear();
// Console.WriteLine("Введите количество элементв: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите нижний предел: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите верхний предел элементв: ");
// int y = int.Parse(Console.ReadLine()!);
// double[] array = new double[n];
// NewArray(array, ref x, ref y);
// Console.WriteLine($"Массив: {string.Join(", ", array)}");
// Console.WriteLine(diff(array));