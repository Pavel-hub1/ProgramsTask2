Console.Clear();
int x1 = number("x1 =");  
int y1 = number("y1 =");
int z1 = number("z1 =");
int x2 = number("x2 =");
int y2 = number("y2 =");
int z2 = number("z2 =");
int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;
double lenght = Math.Sqrt(A*A + B*B +C*C);
Console.WriteLine($"{lenght}");
int number(string message)   
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}