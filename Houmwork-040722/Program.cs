// See https://aka.ms/new-console-template for more information
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

double Stepen (int A, int B)
{
double N = Math.Pow(A, B);
return (N);

}
Console.WriteLine("Введите положительное целое число раз возведения числа А в степень,   ");
int j = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < j; i++)
{
Console.WriteLine("Введите положительное целое число А,   ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное целое число степени, в которую возводим А,   ");
int Num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Number + "," + Num + " -> " + Stepen(Number, Num)); 
}



/*// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumInteger (int Num)
{
    int j = 0;
    while (Num > 0)
    {
        j = j + Num % 10;
        Num = Num / 10;
    } 
        return j;
    }

    Console.WriteLine("Введите целое положительное число");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{N} -> " +SumInteger(N));
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int start, int end)
// {
//     int[] RandomArray = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//         Console.Write(RandomArray[i]+",");
//     }
//     return RandomArray;
// }

//  void ShowArray(int[] array)
// {   Console.Write("  ->  [");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ",");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Console.WriteLine("Введите первое число случайно генерируемого диапазона 8-ми элементов");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона 8-ми элементов");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateRandomArray(min, max);
// ShowArray(myRandomArray);
