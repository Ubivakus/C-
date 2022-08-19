//Console.WriteLine("Hello, World!");

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Result: " + (int)MathF.Pow(number, 2));

//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.WriteLine("Ведите первое число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите второе число");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("x: " + x);
// Console.WriteLine("y: " + y);

// if (x  == y * y)
// {
// Console.WriteLine("Первое число является квадратом второго числа потому что y * y = " + x);
// } else {
//     Console.WriteLine("Первое число не является квадратом второго числа");
//}

// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница


Console.WriteLine("Ведите день недели числом");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 1) {
    Console.WriteLine("Понедельник");
} else if (x == 2) {
    Console.WriteLine("Вторник");
} else if (x == 3) {
    Console.WriteLine("Среда");
} else if (x == 4) {
    Console.WriteLine("Четверг");
} else if (x == 5) {
    Console.WriteLine("Пятница");
} else if (x == 6) {
    Console.WriteLine("Суббота");
} else if (x == 7) {
    Console.WriteLine("Воскресенье");
} else {
    Console.WriteLine("Такого дня недели не бывает!");
}