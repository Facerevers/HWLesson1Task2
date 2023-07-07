Console.WriteLine("Введите первое число и нажмите Enter");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите Enter");
int b = int.Parse(Console.ReadLine());
if (a > b) Console.WriteLine ($"max = {a}");
if (a < b) Console.WriteLine ($"max = {b}");
if (a == b) Console.WriteLine ("Оба числа равны, решайте сами");