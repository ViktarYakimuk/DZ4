//  Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный случайными числами. 
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//  -> 8

int[] Create(int length)
{
   int[] Array = new int[8];
   for (int i = 0; i < Array.Length; i++)
   {
      Array[i] = new Random().Next(1, 100);
   }
   return Array;
}
void PrintArray(int[] Array)
{
   for (int i = 0; i < Array.Length; i++)
   {

      System.Console.Write($"{Array[i]}\t");
   }
}
int[] Array = Create(8);
PrintArray(Array);