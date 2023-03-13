Console.Clear();
int n = new Random().Next(100, 1000);
Console.WriteLine($"Трехзначное число {n}");
int n1 = n / 10;
int n2 = n1 % 10;
Console.WriteLine(n2);
