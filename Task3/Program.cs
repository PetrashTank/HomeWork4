/*
Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int [] CreateArray()
{
int [] Array = new int [8];
Random number = new Random();
for (int i = 0; i < Array.Length; i++)
{
Array[i] = number.Next(100);
}
return Array;
}
int [] a = CreateArray();

void PrintArray (int[] array1)
{
for (int i = 0; i < 1; i++)
{
Console.WriteLine($"Массив  {array1[0]} ,{array1[1]}, {array1[2]}, {array1[3]}, {array1[4]} -> [{array1[0]} ,{array1[1]}, {array1[2]}, {array1[3]}, {array1[4]}]");
Console.WriteLine($"Массив  {array1[5]} ,{array1[6]}, {array1[7]} -> [{array1[5]} ,{array1[6]}, {array1[7]}]");
}
}
PrintArray(a);