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



/*
Console.Clear();
Console.WriteLine("введите числа: ");
int[] array = numbers(Console.ReadLine());
PrintArray(array);
int sum = 0;
for (int i = 0; i< array.Length; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine(sum);

int[] numbers(string a)
{
    int count = 1;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == ',')
        {
            count++;
        }
    }

    int[] col = new int [count];
    int index = 0;

    for (int i = 0; i < a.Length; i++)
    {
        string temp = "";

        while (a[i] != ',')
        {
        if(i != a.Length - 1)
        {
            temp += a[i].ToString();
            i++;
        }
        else
        {
            temp += a[i].ToString();
            break;
        }
        }
        col[index] = Convert.ToInt32(temp);
        index++;
    }
    return col;
}



void PrintArray(int[] collection)
{
    Console.Write("");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("");
}
*/



/*
Console.Clear();
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y = k2*x + b2;

Console.WriteLine($"прямые пересекутся [{x}, {y}]");
*/

