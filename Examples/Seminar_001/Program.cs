/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98


int x = new Random().Next(100, 1000);
Console.WriteLine(x);

string first = Convert.ToString(x / 100);
string third = Convert.ToString(x % 10);
Console.WriteLine(first + third);
*/


/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 16, 4 -> кратно
*/

/*int a = new Random().Next(10, 100);
int b = new Random().Next(1, 10);
System.Console.WriteLine(a);
System.Console.WriteLine(b);
int c = a % b;
//System.Console.WriteLine(c);

if (c == 0) 
{
    System.Console.WriteLine("Кратно.");
} else
{
    System.Console.WriteLine("Не кратно. Остаток: " + c);
}
*/

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 46 -> нет 161 -> да


// int a = new Random().Next(10, 1000);
// System.Console.WriteLine(a);
// int x = a % 7;
// int y = a % 23;
// if (x == 0 && y == 0)
// {
//     System.Console.WriteLine($"Кратно обоим числам 7 и 23");
// } else 
// {
//     System.Console.WriteLine($"Не кратно обоим числам 7 и 23, остаток  1 = {x} и остаток 2 = {y}");
// }

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


/*int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.Clear();
System.Console.WriteLine(a);
System.Console.WriteLine(b);

int x = Convert.ToInt32(Math.Pow(a, 2));
if (x == b)
{
    System.Console.WriteLine("Является квадратом");
} else
{
    System.Console.WriteLine("Не является квадратом");
}
*/



