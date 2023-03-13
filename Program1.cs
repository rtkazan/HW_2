Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string nToString = Convert.ToString(n);
if (nToString.Length > 2)
{
    Console.WriteLine(nToString[2]);
}
else {
    Console.WriteLine("Третьей цифры нет");
}