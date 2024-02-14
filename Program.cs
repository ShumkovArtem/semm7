// Домашние задание:
// Задача 1: Задайте значение M и N. Напишите программу, которая выдает все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void ShowNumbers(int M, int N)
// {
//     if (M == N)
//     {
//         Console.Write(M);
//         return;
//     }
//     Console.Write(M + " ");
//     ShowNumbers(M + 1, N);
// }
// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(1, N);
// Console.WriteLine();
// ShowNumbers(4, b);




// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// Console.Write("Введите значение M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int FunctionAkkerman(int M, int N)
// {
//     if (M == 0) return N + 1;
//     else if (N == 0) return FunctionAkkerman(M - 1, 1);
//     else return FunctionAkkerman(M - 1, FunctionAkkerman(M, N - 1));
// }
// Console.Write($"Функция Аккермана равно {FunctionAkkerman (M, N)}");

// Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

// int[] arr = {1, 2, 3, 0, 10, 34};
// int size = arr.Length;
// void ShowArrayReverse(int[] arr, int size)
// {
//     int j = size - 1;
//     if (j == 0) 
//     {
//         Console.Write(arr[j]);
//         return;
//     }
//     Console.Write(arr[j] + ", ");
//     ShowArrayReverse(arr, size - 1);
// }
// ShowArrayReverse(arr, size);