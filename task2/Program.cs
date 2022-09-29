Console.Clear();
Console.WriteLine("");
string a = Console.ReadLine();
int lenght = a.Length;
if (lenght == 5)
{
    if (a[0] == a[4] & a[1] == a[3])
    {
        Console.WriteLine($"{a} - палиндром");
    }
    else{
        Console.WriteLine($"{a} - не палиндром");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}