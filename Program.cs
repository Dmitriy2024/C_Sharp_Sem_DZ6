/*
// напишите программу которая перевернет однамерный массив
int[] GetArray(int size, int min, int max)
{
    int[] arr = new int [size];
    for (int i =0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
int[] resultArr = GetArray(10, 0, 10);

Console.Write($"Исходный массив: [{String.Join( " ; ", resultArr)}]");


//

int[] CoryReverseArray (int[] arr)
{
    int reversArray = new int[arr.Length];
    for (int left = 0, right = arr.Length - 1; left < reversArray.Lenght; left++; right--)
    {
      CoryReverseArray[left] = arr[right];
    }
    return reversArray;
}
 int [] revers = CoryReverseArray(resultAArray);
Console.Write($"Перевернутый массив: [{String.Join( " ; ", revers)}]");

int ReverseArray(int[] arr)
{
    for(int i = 0;j = arr.Length - 1; i < arr.Lenght / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
ReversArray(resultArray);
Console.WriteLine($"Перевернутый массив: [{String.Join("; ", resultArray)}]");
*/
/*
int A = 3;
int B = 4;
int C =5;

bool IsTriangle(int a, int b, int c )
{
    return ((A+B)> C && (B+C)> A && (A + C)> B);
}
if (IsTriangle(A, B, C))
{
    Console.WriteLine("ESt");
}
    else
    {
     
        Console.WriteLine("Net");
    }
   */

    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
    
    //уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    Console.Write("Введите b1:");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите k1:");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите b2:");
    double b2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите k2:");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double x = (b2 - b1)/(k1-k2);
    double y = k1*(b2 - b1) / (k1 - k2) + b1;

    Console.WriteLine("b1=" + b1  + "A(" + x + "," + y + ")") ;


    
