/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
string str = number.ToString();
int summ = 0;
int[] b = new int[amount];

for( int i=0; i< amount; i++)
{
    b[i] = int.Parse(str[i].ToString());
}
for (int i = 0; i < b.Length; i++)
{
    summ = b[i] + summ;
}

Console.WriteLine(summ);