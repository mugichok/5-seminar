// void f(ref int n) // ref ссылка на ячейку памяти изначальной переменной, а не её копии. Работает для всех типов данных, кроме массивов
// {
//     n += 5;
// }
// Console.Clear();
// int m = 10;
// f(ref m);
// Console.WriteLine(m);


// void f(int[] n)
// {
//     n[0] = n[0] + 5;
// }
// Console.Clear();
// int[] m = {5,3,6,1,8};
// f(m);
// Console.WriteLine($"[{string.Join(", ", m)}]");

// void f(int n, int m =15)
// {
//     Console.WriteLine($"{n} + {m} = {n+m}");
// }
// Console.Clear();
// f(10, 4);

// int MaxNumbers(int n, int m)
// {
//     if(n >m)
//         return n;
//     return m;
// }
// Console.Clear();
// int result = MaxNumbers(10,20);
// Console.WriteLine(result);
// Console.WriteLine(MaxNumbers(-3,45));

// задача 31. Задайте массив из 12 элементов, заполненный случайными числами от -9 до 9 и найдите сумму отрицательный и положительных значений массива

// void NewArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }


// void SearchSumm(int[] array)
// {
//     int SumPositive = 0, AllSum = 0;
//     foreach (int element in array)
//     {
//         if(element > 0)
//             SumPositive += element;
//         AllSum += element;
//     }
//     Console.WriteLine($"Сумма положительных элементов: {SumPositive}");
//     Console.WriteLine($"Сумма отрицательных элементов: {AllSum-SumPositive}");
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов массива: ");
// int x = int.Parse(Console.ReadLine()!);
// int[] array = new int[x];
// NewArray(array);
// Console.WriteLine($"{string.Join(", ", array)}");
// SearchSumm(array);

// задача 32. Напишите код, который меняет знак элементов массива

// void NewArray(int[] array)
// {
//     for(int i =0; i < array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void ChangeEl(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] *= -1;
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов массива: ");
// int x = int.Parse(Console.ReadLine()!);
// int[] array = new int[x];
// NewArray(array);
// Console.WriteLine($"{string.Join(", ", array)}");
// ChangeEl(array);
// Console.WriteLine($"{string.Join(", ", array)}");

// void NewArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9,9);
// }

// string SearchEl(int[] array, ref int y)
// {
//     foreach(int element in array)
//     {
//         if(element == y)
//             return "yes";
//     }
//     return "no";
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов: ");
// int x = int.Parse(Console.ReadLine()!);
// int[] array = new int[x];
// NewArray(array);
// Console.WriteLine($"Массив: {String.Join(", ", array)}");
// Console.WriteLine("Введите число: ");
// int y = int.Parse(Console.ReadLine()!);
// Console.WriteLine(SearchEl(array, ref y));

// void NewArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(5, 111);
// }

// int CheckEl(int[] array, ref int x, ref int y)
// {
//     int n = 0;
//     foreach(int elemetn in array)
//     {
//         if(elemetn >= x && elemetn <= y)
//             n++;
//     }
//     return n;
// }

// Console.Clear();
// int[] array = new int[123];
// NewArray(array);
// Console.WriteLine($"Массив: {string.Join(", ", array)}");
// Console.WriteLine("Введите нижний предел: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите верхний предел: ");
// int y = int.Parse(Console.ReadLine()!);
// Console.WriteLine(CheckEl(array, ref x, ref y));


// void NewArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// int[] ProdEl(int[] array1, int[] array2)
// {
//     for(int i =0; i < array1.Length/2 + array1.Length%2; i++)
//     {
//             array2[i] = array1[i] * array1[array1.Length - i -1];
//     }
//     return array2;
// }

// Console.Clear();
// Console.WriteLine("Введите количетсво элементов масиива: ");
// int x = int.Parse(Console.ReadLine()!);
// int[] array1 = new int [x];
// int[] array2 = new int [(x/2+x%2)];
// NewArray(array1);
// Console.WriteLine($"Заданный массив: {string.Join(", ", array1)}");
// ProdEl(array1,array2);
// Console.WriteLine($"Преобразованный массив: {string.Join(", ", ProdEl(array1, array2))}");
// Console.WriteLine(9%2);

// void NewArray(int[] array)
// {
//     int begin =10 , end = 90;
//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().NextDouble() * (end - begin) + begin; // создание массива вещественных чисел. NextDouble - 0<array[i]<1. NextDouble() * (end - begin) + begin - 10 + 0 * 80< 10+ array[i]*80< 1 * 80 + 10
// }


// доп задача про сбор черники

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int [n];
// for ( int i = 0; i < array.Length; i++)
// {
//     array[i] = int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"{string.Join(", ", array)}");
// int max_summa = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     if (max_summa < array[i] + array[(i+1%n)] + array[(i+2)%n])
//         max_summa = array[i] + array[(i+1%n)] + array[(i+2)%n];
// }
// Console.WriteLine(max_summa);