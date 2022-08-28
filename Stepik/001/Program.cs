//Напишите программу, которая преобразовывает число из десятеричной системы в шестнадцатеричную.
/*
Console.Clear();

int x;
int y = 16;

while(true)
{
    System.Console.Write("Введите число для переобразования: ");
    x = Convert.ToInt32(Console.ReadLine());    
    string newNumber = Convert.ToString(x, y).ToUpper();
    System.Console.WriteLine(newNumber);
    if(x == 0) break;
}
*/


//Напишите программу, которая преобразовывает число из десятеричной системы в шестнадцатеричную (ручками).
System.Console.Write("Введите число для переобразования: ");
int x = Convert.ToInt32(Console.ReadLine());
string res = "";
string z = "0123456789ABCDEF";
while (x != 0)
{
    res = z[x % 16] + res;
    x = x / 16;
}
Console.WriteLine(res);

