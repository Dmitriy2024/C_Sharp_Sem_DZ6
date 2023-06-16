

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.
Console.WriteLine("ВВедите колличество чисел");
int numbersLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numbersLength]; 
int sumPositiveNumbers = 0;


for(int i =0; i < numbersLength; i++)
{
   Console.Write("ВВедите  чисел:  ");
    int numbers = Convert.ToInt32(Console.ReadLine());
    array[i] = numbers;
    Console.WriteLine(numbers);
   }
   for(int i =0; i < numbersLength; i++)
   {
    if(array[i] > 0)
   {
     sumPositiveNumbers = sumPositiveNumbers + 1;
   }
   
   }
   Console.Write($"Массив: [{string.Join(";",array)}]");
Console.WriteLine( "  Чисел больше 0 = " + sumPositiveNumbers);



/*
int[] Array = new int[M]; 
int sumGreaterZero = 0;

for (int i = 0; i < M; i++)
{
   if (Array[i] > 0)
   {
     sumGreaterZero = sumGreaterZero + Array[i];
   } 
}
Console.WriteLine(Array + " " + sumGreaterZero + "чисел больше 0");
*/


/*
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

    Console.WriteLine("b1=" + b1 + ";" + "k1=" + k1 + ";" + "b2=" + b2 + ";" + "k2=" + k2 + "  A(" + x + "," + y + ")") ;
*/

    
