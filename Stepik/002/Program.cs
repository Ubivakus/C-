

string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int a = Convert.ToInt32(splitString[0]);
        int b = Convert.ToInt32(splitString[1]);
        int c = Convert.ToInt32(splitString[2]);
        int d = Convert.ToInt32(splitString[3]);

        int minValue = 0;
        int maxValue = 0;

        //Тут будет Ваш код
        minValue = a;
        maxValue = a;
        if(a < b && a < c && a < d) minValue = a;
        else if(b < a && b < c && b < d) minValue = b;
        else if(c < a && c < b && c < d) minValue = c;
        else if(d < a && d < b && d < c) minValue = d;

        if(a > b && a > c && a > d) maxValue = a;
        else if(b > a && b > c && b > d) maxValue = b;
        else if(c > a && c > b && c > d) maxValue = c;
        else if(d > a && d > b && d > c) maxValue = d;


        Console.WriteLine($"Наименьшее число - {minValue}");
        Console.WriteLine($"Наибольшее число - {maxValue}");
