// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212->нет
// 12821->да
// 23432->да
// int a, b;
// Console.Write("Введите число:");
// int n = int.Parse(Console.ReadLine()!);

// if (n > 9999 && n <= 99999)
// {
//     a = n % 10;
//     Console.WriteLine("Последняя цифра=" + a);
//     b = n / 10000;
//     Console.WriteLine("Первая цифра=" + b);
//     if (a == b)
//     {
//         a = (n % 100) / 10;
//         b = n / 1000 % 10;
//         Console.WriteLine("Предпоследняя цифра=" + a);
//         Console.WriteLine("Вторая с начала цифра=" + b);
//     }
//     if (a == b)
//     {
//         Console.WriteLine("Число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Число не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Не является пятизначным числом");
// }


//Нахождение длины отрезка в пространстве
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// double c;
// int i;
// int[] x = new int[2];
// int[] y = new int[2];
// int[] z = new int[2];

// for (i = 0; i <= 1; i++)
// {
//     Console.Write("Введите x точки " + (char)(65 + i) + ":  x" + (i + 1) + "=");
//     x[i] = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите y точки " + (char)(65 + i) + ":  y" + (i + 1) + "=");
//     y[i] = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите z точки " + (char)(65 + i) + ":  z" + (i + 1) + "=");
//     z[i] = int.Parse(Console.ReadLine()!);
// }
// c = Math.Round(Math.Sqrt(Math.Pow(x[0] - x[1], 2) + Math.Pow(y[0] - y[1], 2) + Math.Pow(z[0] - z[1], 2)),2);
// Console.Write("Длина отрезка равна:" + c);


//Кубы
// int x, i;

// Console.Write("Enter end of range:");
// int n = int.Parse(Console.ReadLine()!);

// for (i = 1; i <= n; i++)
// {
//     x = (int)Math.Pow(i, 3);
//     Console.WriteLine("Куб от " + i + "=" + x);
// }

