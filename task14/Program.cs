/*
//может ли существовать треугольник с тремя введенным сторонами
Console.Clear();
Console.Write("ВВедите длину 1-ой стороны: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите длину 2-ой стороны: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите длину 3-ей стороны: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a+b>c && b+c>a && a+c>b)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
*/


/*
//переводит число в двоичное
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string? s = string.Empty;

while(n>0)
{
    int x = n%2;
    s = Convert.ToString(x) + s;
    n = n/2;
}
Console.WriteLine(s);
*/

/*
//через рекурсию
Console.Clear();

string f(int n)
{
    if (n==0)
        return"";
    return f(n/2) + Convert.ToString(n%2);
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
*/



