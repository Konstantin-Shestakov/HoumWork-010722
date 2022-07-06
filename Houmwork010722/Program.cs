// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да
internal class Program
{
    private static void Main(string[] args)
    {
        {
            //Console.WriteLine("Input number,    ");
            //int N = Convert.ToInt32(Console.ReadLine())
            
                                                                          //  void ChNumber (int Integer)//Вывод развернутого числа
            {
                           //int CurrNumber = N;                             //int CurrNumber = Integer % 10; 
                           //Console.Write(CurrNumber);
                           // //    for (int i = 0; i < 4; i++)
                           // {
                           //  CurrNumber = N / 10 % 10;                       //CurrNumber = Integer / 10 % 10;
                           //  N = N / 10;                                   //Integer = Integer / 10;
                           //     Console.Write(CurrNumber);
                            // }
            
                            // }
                                                         // Сравнение 1,5 и 2,4 чисел на равенство
            
                                                                                      //void Palindrom (double Num)
                                                                                         //{
              Console.WriteLine("Input number,    ");
            int Num = Convert.ToInt32(Console.ReadLine());
            
                double b5 = Num % 10; 
                double b4 = Num / 10 % 10; 
                double b3 = Num / 100 % 10 ; 
                double b2 = Num / 1000 % 10 ;
                double b1 = Num / 10000 % 10;

                if (b1 == b5 && b2 == b4)
                {
                Console.Write(Num + " -> да ");
                }
                else
                {
                Console.Write(Num + " -> нет ");
                }
              
            //}
        }
                                                                     //Console.WriteLine("Input number,    ");
                                                                    //int N = Convert.ToInt32(Console.ReadLine());
                                                                   //ChNumber(N);
                                                                  //Palindrom(N);
    }}}



/*
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53    
       
       
    Console.Write("Введите х1, y1, z1 .");
int[] Input()
{
    int[] Array = new int[3];
    Console.Write("Введите координату x: ");
    Array[0] = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите координату y: ");
    Array[1]  = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z: ");
    Array[2]  = Convert.ToInt32(Console.ReadLine());
    return Array;
}
int[] calc_point_C(int[] arr1, int[] arr2)
{
    int[] arr_vector = new int[3];
    arr_vector[0] = arr2[0]- arr1[0];
    arr_vector[1] = arr2[1]- arr1[1];
    arr_vector[2] = arr2[2]- arr1[2];
    return arr_vector;
}
void print_point(int[] arr1)
{
Console.Write('['+Convert.ToString(arr1[0]) +';'+ Convert.ToString(arr1[1]) +';' + Convert.ToString(arr1[2])+']');

}
Console.WriteLine("Введите координаты начала отрезка");
    int[] arr_point_A = Input();
Console.WriteLine("Введите координаты конца отрезка");
    int[] arr_point_B = Input();
int[] arr_point_C = calc_point_C(arr_point_A,arr_point_B);
double vector_len = Math.Sqrt(Math.Pow(arr_point_C[0],2) + Math.Pow(arr_point_C[1],2) + Math.Pow(arr_point_C[2],2));
Console.Write("Длина отрезка по точкам ");
    print_point(arr_point_A); 
Console.Write(" и ");
    print_point(arr_point_B); 
Console.Write(" -> " + Math.Round(vector_len,2));
        Console.WriteLine();
*/

/*
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write(number + " ->  ");
        
         if (number >= 0)
        {
            for (int current = 0; current <= number; current ++)
                Console.Write(Math.Pow(current,3) + " ");      
        }
        else
        {
            for (int current = -1; current >= number; current --)
                Console.Write(Math.Pow(current,3) + " ");
        }
*/


