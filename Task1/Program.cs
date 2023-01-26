/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double GetDegree()
{
    Console.WriteLine("Введите степень");
    int gegree = Convert.ToInt32(Console.ReadLine());
    return  gegree;
}
int N = GetNumber();
double D = GetDegree();

    Console.Write($"{N}^{D} = {(long)Math.Pow(N, D)}");
   
