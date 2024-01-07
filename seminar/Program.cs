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

void NewArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9,10);
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int x = int.Parse(Console.ReadLine()!);
int[] array = new int[x];
NewArray(array);
Console.WriteLine