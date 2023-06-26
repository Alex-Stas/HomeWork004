// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16
// int InputNum(string message)
// {
// Console.WriteLine(message);
// return int.Parse(Console.ReadLine()!);
// }
// int PowOneTwo (int a, int b)
// {
//     int result = a;
//     for (int i = 1; i < b; i++)
//     {
//         result *= a; 
//     }
//     return result;
// }

// int a = InputNum ("Enter the first number:");
// int b = InputNum ("Enter the second number:");
// Console.WriteLine ($"{a} in the power of {b} is {PowOneTwo(a,b)}");

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// int InputNum(string message) // Ввод числа
// {
//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// int DigitsCount(int num) // Подсчет числа разрядов
// {
//     int temp = num;

//     int count = 0;
//     while (temp != 0)
//     {
//         temp = temp / 10; // num /= 10;
//         count++;
//     }
//     return count;
// }

// int[] FillArray(int num, int digits) // Заполнение массива
// {
//     int[] array = new int[digits];

//     for (int i = array.Length - 1; i >= 0; i--)
//     {
//         array[i] = num % 10;
//         num /= 10;
//     }
//     return array;
// }

// int SumOfAllDigits (int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         sum = sum + array[i];
//     }
//     return sum;
// }

// int number = InputNum("Enter your number please: ");
// int digits = DigitsCount (number);
// int [] array = FillArray (number, digits);
// int sum = SumOfAllDigits(array); 
// Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputNum(string message)
{
Console.WriteLine(message);
return int.Parse(Console.ReadLine()!);
}
int[] ArrayInput(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = InputNum ($"Please enter {i+1} number:");
}
return array;
}
void PrintArray(int[] array)
{
int size = array.Length;
for (int i = 0; i < size; i++)
{
Console.Write(array[i]+" ");
}
}
int len = InputNum("Введите длину массива: ");
int[] arr = ArrayInput(len);
PrintArray(arr);