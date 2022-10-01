Console.Clear();

int a = number("");
int lenght = Len(a);
sum(a, lenght);
int Len(int x)
{
    int i = 0;
    while (x>0)
    {x= x/10; i++;}
    return i;
}
void sum(int n, int lenght)
{
    int y = 0;
    for (int k = 1; k <=lenght; k++)
    {y += n %10; n=n/10;}
    Console.WriteLine(y);
}
int number(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}